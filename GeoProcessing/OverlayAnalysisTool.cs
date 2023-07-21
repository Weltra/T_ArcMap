using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;

namespace TArcMap.GeoProcessing
{
    public partial class OverlayAnalysisTool : Form
    {
        public OverlayAnalysisTool()
        {
            InitializeComponent();
        }

        //定义全局变量
        public IMap pMap { get; set; }
        public AxMapControl mapControl { get; set; }

        private void OverlayAnalysisTool_Load(object sender, EventArgs e)
        {
            try
            {
                pMap = mapControl.Map;
                if (pMap == null)
                    return;
                //清空combobox 
                comboBox_InputDataset.Items.Clear();
                comboBox_ClipDataset.Items.Clear();

                string layerName;   //用于储存图层名字 

                for (int i = 0; i < pMap.LayerCount; i++)
                {
                    layerName = pMap.Layer[i].Name;
                    comboBox_InputDataset.Items.Add(layerName);
                    comboBox_ClipDataset.Items.Add(layerName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_OK_Click(object sender, EventArgs e)
        {

            if (pMap == null)
                return;
            //获取数据集
            ILayer inputDataset = GetLayerByName(pMap, comboBox_InputDataset.Text.Trim());
            ILayer clipDataset = GetLayerByName(pMap, comboBox_ClipDataset.Text.Trim());

            if (inputDataset != null && clipDataset != null)
            {
                IFeatureLayer inputLayer = inputDataset as IFeatureLayer;
                IFeatureLayer clipLayer = clipDataset as IFeatureLayer;
                //利用裁剪方法来进行叠加分析
                IBasicGeoprocessor bGP = new BasicGeoprocessorClass();
                bGP.SpatialReference = pMap.SpatialReference;   //设置空间参考

                IFeatureClassName pOutput = new FeatureClassName() as IFeatureClassName;    //创建FeatureClassNameClass对象，用于获取输入数据集的一些基本信息
                pOutput.FeatureType = inputLayer.FeatureClass.FeatureType;
                pOutput.ShapeFieldName = inputLayer.FeatureClass.ShapeFieldName;
                pOutput.ShapeType = inputLayer.FeatureClass.ShapeType;

                //利用IDataset获得IWorkspaceName
                string fileDirectory = System.IO.Path.GetDirectoryName(textEdit_Output.Text.Trim());
                string fileName = System.IO.Path.GetFileName(textEdit_Output.Text.Trim());

                IWorkspaceFactory pWsFc = new ShapefileWorkspaceFactory();
                IWorkspace pWs = pWsFc.OpenFromFile(fileDirectory, 0);	//创建一个工作空间对象
                IDataset pDataset = pWs as IDataset;
                IWorkspaceName pWsN = pDataset.FullName as IWorkspaceName;	//获取工作空间的信息(获取输出路径)

                IDatasetName pDatasetName = pOutput as IDatasetName;	//获取或设置数据集中成员的名称信息
                pDatasetName.Name = fileName;	//设置数据集中的数据成员的名字
                pDatasetName.WorkspaceName = pWsN;	//设置输出的工作空间(输出路径)

                IFeatureClass featureClass = bGP.Clip(inputLayer.FeatureClass as ITable, false, clipLayer.FeatureClass as ITable, false, 0.01, pOutput);

                if (featureClass != null)
                {
                    IFeatureLayer featLayer = new FeatureLayerClass();
                    featLayer.FeatureClass = featureClass;
                    featLayer.Name = featureClass.AliasName;
                    //将结果添加到控件中
                    mapControl.AddLayer(featLayer);
                    mapControl.Refresh();
                }
            }

        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void simpleButton_Output_Click(object sender, EventArgs e)
        {
            SaveFileDialog flg = new SaveFileDialog();
            flg.Title = "保存路径";
            flg.Filter = "ShpFile(*shp)|*.shp";
            flg.ShowDialog();

            textEdit_Output.Text = flg.FileName;
        }
    }
}
