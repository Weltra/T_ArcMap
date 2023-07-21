using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.DisplayUI;
using ESRI.ArcGIS.Display;

namespace TArcMap
{
    public sealed partial class MainForm : Form
    {
        #region class private members
        private IMapControl3 m_mapControl = null;
        private string m_mapDocumentName = string.Empty;
        TocHelper _tocHelper;
        #endregion


        #region class constructor
        public MainForm()
        {
            InitializeComponent();
            _tocHelper = new TocHelper(this.axTOCControl1, this.tocMenu4Map, this.tocMenu4Layer, null, this.tocMenu4Legend);
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //disable the Save menu (since there is no document yet)
            menuSaveDoc.Enabled = false;
        }

        #region Main Menu event handlers
        private void menuNewDoc_Click(object sender, EventArgs e)
        {
            //execute New Document command
            ICommand command = new CreateNewDocument();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuOpenDoc_Click(object sender, EventArgs e)
        {
            //execute Open Document command
            ICommand command = new ControlsOpenDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuSaveDoc_Click(object sender, EventArgs e)
        {
            //execute Save Document command
            if (m_mapControl.CheckMxFile(m_mapDocumentName))
            {
                //create a new instance of a MapDocument
                IMapDocument mapDoc = new MapDocumentClass();
                mapDoc.Open(m_mapDocumentName, string.Empty);

                //Make sure that the MapDocument is not readonly
                if (mapDoc.get_IsReadOnly(m_mapDocumentName))
                {
                    MessageBox.Show("Map document is read only!");
                    mapDoc.Close();
                    return;
                }

                //Replace its contents with the current map
                mapDoc.ReplaceContents((IMxdContents)m_mapControl.Map);

                //save the MapDocument in order to persist it
                mapDoc.Save(mapDoc.UsesRelativePaths, false);

                //close the MapDocument
                mapDoc.Close();
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //execute SaveAs Document command
            ICommand command = new ControlsSaveAsDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        #endregion

        //listen to MapReplaced evant in order to update the statusbar and the Save menu
        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //get the current document name from the MapControl
            m_mapDocumentName = m_mapControl.DocumentFilename;

            //if there is no MapDocument, diable the Save menu and clear the statusbar
            if (m_mapDocumentName == string.Empty)
            {
                menuSaveDoc.Enabled = false;
                statusBarXY.Text = string.Empty;
            }
            else
            {
                //enable the Save manu and write the doc name to the statusbar
                menuSaveDoc.Enabled = true;
                statusBarXY.Text = System.IO.Path.GetFileName(m_mapDocumentName);
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }

        //定义按矩形框放大ToolStripMenuItem_Click事件
        private void 按矩形框放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomInByRectangle tool1 = new TArcMap.Navigation.ZoomInByRectangle();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //定义按矩形框缩小ToolStripMenuItem_Click事件
        private void 按矩形框缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomOutByRectangle tool1 = new TArcMap.Navigation.ZoomOutByRectangle();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //定义按多边形放大ToolStripMenuItem_Click事件
        private void 按多边形放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomInByPolygon tool1 = new TArcMap.Navigation.ZoomInByPolygon();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //定义按多边形缩小ToolStripMenuItem_Click事件
        private void 按多边形缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomOutByPolygon tool1 = new TArcMap.Navigation.ZoomOutByPolygon();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //定义按圆形放大ToolStripMenuItem_Click事件
        private void 按圆形放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomInByCircle tool1 = new TArcMap.Navigation.ZoomInByCircle();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //定义按圆形缩小ToolStripMenuItem_Click事件
        private void 按圆形缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Navigation.ZoomOutByCircle tool1 = new TArcMap.Navigation.ZoomOutByCircle();
            tool1.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = tool1;
        }

        //打开mxd文档
        private void openMxdFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile.Addmxdfile.Openmxdfile mxdcommand = new AddFile.Addmxdfile.Openmxdfile();
            mxdcommand.OnCreate(this.axMapControl1.Object);
            mxdcommand.OnClick();
        }

        //打开矢量数据
        private void openShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile.Addshpfile.Openshpfile shpcommand = new AddFile.Addshpfile.Openshpfile();
            shpcommand.OnCreate(this.axMapControl1.Object);
            shpcommand.OnClick();
        }

        //打开个人地理数据库
        private void openMdbFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile.Addmdb.Openmdb mdbcommand = new AddFile.Addmdb.Openmdb();
            mdbcommand.OnCreate(this.axMapControl1.Object);
            mdbcommand.OnClick();
        }

        //打开文件地理数据库
        private void openGdbFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile.Addfiledb.Openfilegdb gdbcommand = new AddFile.Addfiledb.Openfilegdb(this.axMapControl1);
            gdbcommand.OnClick();
        }

        //移除图层菜单
        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axMapControl1.Map.DeleteLayer(_tocHelper._hitTestLayer);
        }

        //打开属性表菜单
        private void OpenAttributeTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AttributeTable pAttributeTable = new AttributeTable();
            pAttributeTable.PFeatureLayer = _tocHelper._hitTestLayer as IFeatureLayer;
            pAttributeTable.Show();
        }

        //添加属性
        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand pCommand = new ControlsAddDataCommand();
            pCommand.OnCreate(axMapControl1.Object);
            pCommand.OnClick();
        }

        //按点选择
        private void selectByPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select.ByPoint.PointSelect selectbypoint = new Select.ByPoint.PointSelect();
            selectbypoint.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = selectbypoint;
        }

        //按多边形选择
        private void selectByPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TArcMap.Select.ByPolygon.PolygonSelect selectbypolygon = new TArcMap.Select.ByPolygon.PolygonSelect();
            selectbypolygon.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = selectbypolygon;
        }

        private void spatialQueryToolSripMenuItem_Click(object sender, EventArgs e)
        {
            GeoProcessing.SpatialQueryForm spQueryForm = new GeoProcessing.SpatialQueryForm(this.axMapControl1.Map);
            spQueryForm.Show();
        }

        private void attributeQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建新建属性查询窗体
            GeoProcessing.AttributeQueryForm frmQureyByAttribute = new GeoProcessing.AttributeQueryForm();
            //将当前主窗体的MapControl控件中的Map对象赋值给FormQueryByAttribute窗体的CurrentMap属性
            frmQureyByAttribute.currentMap = this.axMapControl1.Map;
            //显示属性查询窗体
            frmQureyByAttribute.Show();
        }

        private void geoProcessingToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeoProcessing.frmGpTools frmGpTools = new GeoProcessing.frmGpTools();
            if (frmGpTools.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void bufferToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeoProcessing.BufferAnalysisTool BF = new GeoProcessing.BufferAnalysisTool();
            BF.mapControl = this.axMapControl1;
            BF.ShowDialog();
        }

        private void overlapToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeoProcessing.OverlayAnalysisTool oA = new GeoProcessing.OverlayAnalysisTool();
            oA.mapControl = this.axMapControl1;
            oA.ShowDialog();
        }

        private void editToolToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapControlDefault mapControl = this.axMapControl1.Object as IMapControlDefault;
            Edit.EditVectorForm editForm = new Edit.EditVectorForm(this.axMapControl1);
            editForm.Show();
        }
    }
}