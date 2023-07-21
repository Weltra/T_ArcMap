using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using System.IO;

namespace TArcMap.GeoProcessing
{
   public partial class frmGpTools : Form
   {
       private GeoProcessing.GpManager _gpManager;

       public GeoProcessing.GpManager GpToolboxManager
      {
         set
         {
            this._gpManager = value;
            _initialToolboxTree();
         }
         get
         {
            return this._gpManager;
         }
      }

      public frmGpTools()
      {
         InitializeComponent();
         this.GpToolboxManager = new GeoProcessing.GpManager(tbWorkspaceLocation.Text);
      }

      private void _initialToolboxTree()
      {
         if (this._gpManager == null || this._gpManager.CurToolbox == null)
         {
            return;
         }
         IGPToolbox curToolbox = this._gpManager.CurToolbox;

         this.toolTreeView.Nodes.Clear();
         TreeNode boxNode = new TreeNode();
         boxNode.Text = curToolbox.Alias;
         boxNode.ImageIndex = 0;
         this.toolTreeView.Nodes.Add(boxNode);

         IEnumGPTool tmpEnumTool = curToolbox.Tools;
         IGPTool tmpTool = tmpEnumTool.Next();
         while (tmpTool != null)
         {

            TreeNode toolNode = new TreeNode();
            toolNode.Text = tmpTool.DisplayName;
            toolNode.Tag = tmpTool;
            toolNode.ImageIndex = 1;
            boxNode.Nodes.Add(toolNode);
            tmpTool = tmpEnumTool.Next();
         }
         //展开全部树
         this.toolTreeView.ExpandAll();
      }

      private XProps currentToolParameters = new XProps();
      private List<GPParameter> esriToolParameters = new List<GPParameter>();
      private IGPTool currentTool;

      private void toolTreeView_AfterSelect(object sender, TreeViewEventArgs e)
      {
         currentTool = e.Node.Tag as IGPTool;

         currentToolParameters.Clear();
         esriToolParameters.Clear();

         if (currentTool != null)
         {
            //esriGPToolType toolType=currentTool.ToolType;

            for (int i = 0; i < currentTool.ParameterInfo.Count; i++)
            {
               GPParameter curParameter = currentTool.ParameterInfo.Element[i] as GPParameter;
               esriToolParameters.Add(curParameter);

               XProp property = new XProp();
               property.Name = curParameter.DisplayName;
               property.Value = string.Empty;
               currentToolParameters.Add(property);
            }
            //this.propertyGrid1.SelectedObject=currentToolParameters;
            this.propertyGrid1.SelectedObject = currentToolParameters;
         }
      }



      private void runToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.esriToolParameters.Count == currentToolParameters.Count)
         {
            for (int i = 0; i < esriToolParameters.Count; i++)
            {
               IGPParameterEdit parameterEdit = esriToolParameters[i] as IGPParameterEdit;
               IGPParameter parameter = esriToolParameters[i] as IGPParameter;
               //parameterEdit.Value=currentToolParameters[i].Value;

               IGPDataType data = parameter.DataType;
               IGPValue value = data.CreateValue(currentToolParameters[i].Value.ToString());
               parameterEdit.Value = value;
            }
         }

         IArray curParameter = new ESRI.ArcGIS.esriSystem.Array() as IArray;
         for (int i = 0; i < this.esriToolParameters.Count; i++)
         {
            curParameter.Insert(i, esriToolParameters[i]);
         }

         ITrackCancel trackCancel = new TrackCancel() as ITrackCancel;
         IGPEnvironmentManager gpEnviromentManager = new GPEnvironmentManager() as IGPEnvironmentManager;
         IGPMessages gpMessage = new GPMessages() as IGPMessages;

         try
         {
            this.currentTool.Execute(curParameter, trackCancel, gpEnviromentManager, gpMessage);
            this.textBox1.Text = string.Empty;
            if (gpMessage.Count == 0)
            {
               this.textBox1.Text = "Success ^-^!";
            }
            for (int i = 0; i < gpMessage.Count; i++)
            {
               IGPMessage message = gpMessage.GetMessage(i);
               this.textBox1.Text += message.Description;
               this.textBox1.Text += Environment.NewLine;
            }
         }
         catch (Exception exp)
         {
            this.textBox1.Text += exp.Message;
         }
      }

      private void btnWorkspaceLocation_Click(object sender, EventArgs e)
      {
         if (ofdTbx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            string boxPath = this.ofdTbx.FileName;
            this.GpToolboxManager.ToolboxLocation = Path.GetDirectoryName(boxPath);
            this.GpToolboxManager.ToolboxName = Path.GetFileName(boxPath);
            this.tbWorkspaceLocation.Text = boxPath;
            this._initialToolboxTree();
         }
      }
   }
}
