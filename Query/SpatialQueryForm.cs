using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace TArcMap.GeoProcessing
{
    public partial class SpatialQueryForm : Form
    {
        private List<IFeatureLayer> _layers = new List<IFeatureLayer>();
        public IFeatureLayer TargetLayer { get; set; }
        private IMap _IMap;
        private ICursor ResultCursor { get; set; }

        public ISpatialFilter SpatialFilter
        {
            get;
            set;
        }

        public SpatialQueryForm()
        {
            InitializeComponent();
        }

        public SpatialQueryForm(IMap map)
            : this()
        {
            this._IMap = map;
            IEnumLayer layerInterator = map.Layers;
            layerInterator.Reset();
            ILayer tmpLayer = layerInterator.Next();
            while (tmpLayer != null)
            {
                //checking the layer type is the Feature layer
                if (tmpLayer is IFeatureLayer)
                {
                    IFeatureLayer tmpFeatureLayer = tmpLayer as IFeatureLayer;
                    this._layers.Add(tmpFeatureLayer);
                    tmpLayer = layerInterator.Next();
                }
            }
            this.SpatialFilter = new SpatialFilter();
            //set the layer name
            this.initializeControlItems();
        }

        private void initializeControlItems()
        {
            if (this._layers != null && this._layers.Count > 0)
            {
                for (int i = 0; i < this._layers.Count; i++)
                {
                    //add to the target list
                    this.comboBox_targetLayer.Items.Add(_layers[i].Name);
                    //add to the sources list
                    this.comboBox_SourceLayer.Items.Add(_layers[i].Name);
                }
            }

            this.comboBox_spRelation.DataSource = Enum.GetNames(typeof(esriSpatialRelEnum));
        }


        /// <summary>
        /// 1.根据提供的图层名称，找到对应 FeatureLayer；
        /// 2.将对应的FeatureLayer中所有的Feature填充到GeometryBag中，作为返回值；
        /// </summary>
        /// <param name="layerName">图层名称</param>
        /// <returns>图层中所有的要素组成的GeometryBag</returns>
        private GeometryBag extractSourceGeometry(string layerName)
        {
            IFeatureLayer sourceFeatureLayer = GetLayerByName(layerName);

            //新建立一个GeometryBag将所有的FeatureClass中的Geometry作为查询的source。
            GeometryBag geometryBag = new GeometryBag();
            IGeometryCollection geometryCollection = geometryBag as IGeometryCollection;
            //提取FeatureLayer中的FeatureClass，提取其中的sp并赋值给GeometryBag
            IGeoDataset sourceGeoDataset = (IGeoDataset)sourceFeatureLayer.FeatureClass;
            ISpatialReference spRef = sourceGeoDataset.SpatialReference;
            geometryBag.SpatialReference = spRef;
            //提取FeatureClass中的每个Feature并添加到GeometryBag中。
            IFeatureCursor soruceFeatureCursor = sourceFeatureLayer.Search(null, false);
            IFeature pFeature = null;
            object missingType = Type.Missing;
            while ((pFeature = soruceFeatureCursor.NextFeature()) != null)
            {
                geometryCollection.AddGeometry(pFeature.Shape, ref missingType, ref missingType);
            }
            //设置GeometryBag中的空间索引，优化检索速度。
            ISpatialIndex spatialIndex = (ISpatialIndex)geometryBag;
            spatialIndex.AllowIndexing = true;
            spatialIndex.Invalidate();

            return geometryBag;
        }

        /// <summary>
        /// 根据图层名称在this._layers中找到对应的FeatureLayer
        /// </summary>
        /// <param name="layerName">string：提供图层名称</param>
        /// <returns>IFeatureLayer:返回矢量图层</returns>
        private IFeatureLayer GetLayerByName(string layerName)
        {
            IEnumerable<IFeatureLayer> sourceLayers = from IFeatureLayer layer in _layers
                                                      where layer.Name == layerName
                                                      select layer;
            List<IFeatureLayer> sourceLayerList = sourceLayers.ToList();
            IFeatureLayer sourceFeatureLayer = sourceLayerList[0];
            return sourceFeatureLayer;
        }

        private esriSpatialRelEnum extractSpRelation(string spRelationName = "esriSpatialRelIntersects")
        {
            //Enum.Parse(typeof(esriSpatialRelationEnum), spRelationName);//不稳定；
            esriSpatialRelEnum spRelation;
            if (Enum.TryParse(spRelationName, out spRelation))
            {
                return spRelation;
            }
            else
            {
                return esriSpatialRelEnum.esriSpatialRelIntersects;
            }
        }

        private void button_buildSpFilter_Click(object sender, EventArgs e)
        {
            //1 提取筛选用图层，转换为GeometryBag
            GeometryBag geometryBag = this.extractSourceGeometry(this.comboBox_SourceLayer.SelectedItem.ToString());
            esriSpatialRelEnum spRelation = this.extractSpRelation(this.comboBox_spRelation.SelectedItem.ToString());
            //构造SpFilter
            this.SpatialFilter.Geometry = geometryBag;
            //SpatialFilter.GeometryField = pInputFeatureLayer.FeatureClass.ShapeFieldName;
            this.SpatialFilter.SpatialRel = spRelation;
            //SpatialFilter.SpatialRelDescription = overlap_typestring;
            //SpatialFilter.SubFields = "shape";
            this.TargetLayer = this.GetLayerByName(this.comboBox_targetLayer.SelectedItem.ToString());
            if (this.SpatialFilter != null && this.TargetLayer != null)
            {
                IFeatureCursor featureCursor = this.PerformSpatialQuery(this.TargetLayer.FeatureClass, this.SpatialFilter);
                this.ResultCursor = featureCursor as ICursor;
            }
            if (this.dataGridView1 != null && this.ResultCursor != null)
            {
                this.FillDataGrid(this.dataGridView1);
            }
        }

        public IFeatureCursor PerformSpatialQuery(IFeatureClass featureClass, ISpatialFilter filter)
        {
            IFeatureCursor featureCursor = featureClass.Search(filter, false);
            return featureCursor;
        }

        private void FillDataGrid(DataGridView gridView)
        {
            if (gridView == null || this.TargetLayer == null || this.ResultCursor == null)
            {
                return;
            }
            IFeatureClass curFeatureClass = this.TargetLayer.FeatureClass;

            this.dataGridView1.Columns.Clear();
            IFields fields = ResultCursor.Fields;
            for (int i = 0; i < fields.FieldCount; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = fields.get_Field(i).Name;
                this.dataGridView1.Columns.Add(column);
            }
            IRow row = ResultCursor.NextRow();
            while (row != null)
            {
                object[] values = new object[row.Fields.FieldCount];
                for (int i = 0; i < row.Fields.FieldCount; i++)
                {
                    values[i] = row.Value[i];

                }
                this.dataGridView1.Rows.Add(values);
                row = ResultCursor.NextRow();
            }
        }

    }
}
