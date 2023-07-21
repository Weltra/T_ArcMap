using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;

namespace TArcMap.Edit
{
    public partial class EditVectorForm : Form
    {
        #region Property and field

        private EditParameter _editParameter;
        public EditParameter Parameters
        {
            get { return this._editParameter; }
        }

        #endregion

        public EditVectorForm()
        {
            InitializeComponent();
        }

        public EditVectorForm(AxMapControl mapControl)
            : this()
        {
            this._editParameter = new EditParameter(mapControl);
            this._initializeLayer(this._editParameter.iMapCtrl);

            this.initializeTools();
        }

        private List<IFeatureLayer> FeatureLayers = new List<IFeatureLayer>();
        private List<string> NameList = new List<string>();

        private void _initializeLayer(IMapControlDefault mapControl)
        {
            for (int i = 0; i < mapControl.LayerCount; i++)
            {
                IFeatureLayer tmpLayer = mapControl.Layer[i] as IFeatureLayer;
                if (tmpLayer != null)
                {
                    this.FeatureLayers.Add(tmpLayer);
                    this.NameList.Add(tmpLayer.Name);
                }
            }
            this.cbLayerList.DataSource = this.NameList;
            this._editParameter.FeatureLayer = this._getLayerByName(this.cbLayerList.SelectedItem.ToString());
        }

        private void initializeTools()
        {
            this.tsbSelectByPoint.Tag = new Tools.Basic.SelectByPoint(this._editParameter);

            this.tsbSelectByPolygon.Tag = new Tools.Basic.SelectByPolygon(this._editParameter);

            this.tsbMove.Tag = new Tools.Basic.Move(this._editParameter);

            this.tsbCreatePoint.Tag = new Tools.Point.Create(this._editParameter);

            this.tsbSketchPolygon.Tag = new Tools.Polygon.SketchPolygon(this._editParameter);

            this.tsbSketchLine.Tag = new Tools.Polygon.SketchPolygon(this._editParameter);

            this.tsbCreateLine.Tag = new Tools.Polyline.CreatePolyline(this._editParameter);
        }

        private IFeatureLayer _getLayerByName(string layerName)
        {
            var curLayer = from layer in this.FeatureLayers
                           where layer.Name == layerName
                           select layer;
            if (curLayer.Count() == 1)
            {
                return curLayer.ToArray()[0];
            }
            else
            {
                return null;
            }
        }

        private void cbLayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLayerList.SelectedItem == null)
            {
                this.btnEndEdit.Enabled = false;
                this.btnSaveEdit.Enabled = false;
                this.btnStartEdit.Enabled = false;
            }
            else
            {
                this.btnEndEdit.Enabled = true;
                this.btnSaveEdit.Enabled = true;
                this.btnStartEdit.Enabled = true;

                string layerName = this.cbLayerList.SelectedItem.ToString();
                this._editParameter.FeatureLayer = this._getLayerByName(layerName);
            }
        }

        private void btnStartEdit_Click(object sender, EventArgs e)
        {
            EditHelper.StartEditing(this.Parameters.WorkspaceEdit, this.Parameters.FeatureClass, false);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            EditHelper.StopEditing(this.Parameters.WorkspaceEdit, true);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            BaseTool curTool = e.ClickedItem.Tag as BaseTool;
            if (curTool == null)
            {
                return;
            }
            else
            {
                tsl_toolName.Text = curTool.GetType().ToString();
                this._editParameter.CurrentTool = curTool;
            }
        }

        private void cbLayerList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {

        }

        private void EditVectorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
