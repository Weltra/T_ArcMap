using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.SpatialAnalyst;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesFile;


namespace TArcMap.GeoProcessing
{
    public partial class BufferAnalysisTool : Form
    {
        public IMap pMap { get; set; }
        public AxMapControl mapControl { get; set; }
        public BufferAnalysisTool()
        {
            InitializeComponent();
        }

        private void BufferAnalysisTool_Load(object sender, EventArgs e)
        {
            pMap = mapControl.Map;
            //向图层comboBox1中预置噪音来源
            if (pMap.LayerCount > 0)
            {
                for (int i = 0; i < pMap.LayerCount; i++)
                {
                    ILayer pLayer = pMap.get_Layer(i);
                    if (pLayer != null)
                    {
                        if (pLayer is IFeatureLayer)
                        {
                            comboBox_InputDataset.Items.Add(pLayer.Name);
                        }
                    }
                }
                comboBox_InputDataset.SelectedIndex = 0;

                DistanceTextBox.Text = "500";
                this.comboBox1.Items.Add("NONE");//选择项1
                this.comboBox1.Items.Add("ALL");
                comboBox1.SelectedIndex = 0;
                textEdit_Output.Text = System.Environment.CurrentDirectory + "buffer.shp";
            }
            else return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog flg = new SaveFileDialog();
            flg.Title = "保存路径";
            flg.Filter = "ShpFile(*shp)|*.shp";
            flg.ShowDialog();

            textEdit_Output.Text = flg.FileName;
        }

        private ILayer GetLayerByName(IMap pMap, string layerName)
        {
            ILayer pLayer = null;
            ILayer tempLayer = null;
            try
            {
                for (int i = 0; i < pMap.LayerCount; i++)
                {
                    tempLayer = pMap.Layer[i];
                    if (tempLayer.Name.ToUpper() == layerName.ToUpper())      //判断名字大写是否一致
                    {
                        pLayer = tempLayer;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return pLayer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ILayer inputDataset = GetLayerByName(pMap, comboBox_InputDataset.Text.Trim());
                IFeatureLayer inputLayer = inputDataset as IFeatureLayer;
                //缓冲区分析-GP工具调用
                Geoprocessor gp = new Geoprocessor();
                gp.OverwriteOutput = true;
                ESRI.ArcGIS.AnalysisTools.Buffer pBuffer = new ESRI.ArcGIS.AnalysisTools.Buffer();
                pBuffer.in_features = inputLayer;
                //设置生成结果存储路径
                pBuffer.out_feature_class = textEdit_Output.Text;
                //设置缓冲区距离
                string buffer_distance = DistanceTextBox.Text + " Meters";
                pBuffer.buffer_distance_or_field = buffer_distance;
                pBuffer.dissolve_option = comboBox1.Text;
                //执行缓冲区分析
                gp.Execute(pBuffer, null);
                //将生成结果添加到地图中
                string pPath = System.IO.Path.GetDirectoryName(textEdit_Output.Text); //获取文件路径
                string pName = System.IO.Path.GetFileName(textEdit_Output.Text); //获取文件名
                this.mapControl.AddShapeFile(pPath, pName);
                this.mapControl.MoveLayerTo(1, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
