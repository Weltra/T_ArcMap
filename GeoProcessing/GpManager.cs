using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geodatabase;
using System.IO;

namespace TArcMap.GeoProcessing
{
   public class GpManager
   {
      private string _boxLocation;
      public string ToolboxLocation
      {
         get { return this._boxLocation; }
         set
         {
            if (Directory.Exists(value))
            {
               this._boxLocation = value;
               this._toolboxWorkspace = this._initialWorkspace(this._boxLocation);
            }
         }
      }

      private string _boxName;
      public string ToolboxName
      {
         get { return this._boxName; }
         set
         {
            if (this.ToolboxWorkspace != null)
            {
               this._boxName = value;
               this._curToolbox = GetToolBox(this._boxName);
            }
         }
      }

      private IToolboxWorkspace _toolboxWorkspace;
      public IToolboxWorkspace ToolboxWorkspace
      {
         get { return this._toolboxWorkspace; }
      }

      private IGPToolbox _curToolbox;
      public IGPToolbox CurToolbox
      {
         get { return this._curToolbox; }
      }

      private ToolboxWorkspaceFactory _toolWorkspaceFactory;

      public GpManager()
      {
         this._toolWorkspaceFactory = new ToolboxWorkspaceFactory();
      }

      public GpManager(string toolBoxLocation, string boxName)
         : this()
      {
         this.ToolboxLocation = toolBoxLocation;
         this.ToolboxName = boxName;
      }

      public GpManager(string boxFilePath)
         : this()
      {
         if (File.Exists(boxFilePath))
         {
            string toolboxName = Path.GetFileName(boxFilePath);
            string toolboxLocation = Path.GetDirectoryName(boxFilePath);
            this.ToolboxLocation = toolboxLocation;
            this.ToolboxName = toolboxName;
         }
      }

      private IToolboxWorkspace _initialWorkspace(string boxLocation)
      {
         if (this._toolWorkspaceFactory != null && boxLocation != null)
         {
            IWorkspaceFactory wf = this._toolWorkspaceFactory as IWorkspaceFactory;
            //checking the workspace location
            if (this._toolWorkspaceFactory.IsWorkspace(boxLocation))
            {
               return _toolboxWorkspace = wf.OpenFromFile(boxLocation, 0) as IToolboxWorkspace;
            }
            else
            {
               return null;
            }
         }
         else
         {
            return null;
         }
      }

      private IGPToolbox GetToolBox(string boxName)
      {
         if (this._toolboxWorkspace != null)
         {
            return this._toolboxWorkspace.OpenToolbox(boxName);
         }
         else
         {
            return null;
         }
      }

   }

   public class esriParameter : IGPParameter
   {

      private GPParameter _parameter;
      public esriParameter(GPParameter parameter)
      {
         this._parameter = parameter;
      }

      public bool Altered
      {
         get { return _parameter.Altered; }
         //set { _parameter.Altered=value; }
      }

      public string Category
      {
         get { return _parameter.Category; }
      }

      public IGPChoiceList ChoiceList
      {
         get { return _parameter.ChoiceList; }
      }

      public ESRI.ArcGIS.esriSystem.UID ControlCLSID
      {
         get { return _parameter.ControlCLSID; }
      }

      public IGPDataType DataType
      {
         get { return _parameter.DataType; }
      }

      public string DefaultEnvironmentName
      {
         get { return _parameter.DefaultEnvironmentName; }
      }

      public esriGPParameterDirection Direction
      {
         get { return _parameter.Direction; }
      }

      public string DisplayName
      {
         get { return _parameter.DisplayName; }
      }

      public int DisplayOrder
      {
         get { return _parameter.DisplayOrder; }
      }

      public IGPDomain Domain
      {
         get { return _parameter.Domain; }
      }

      public bool Enabled
      {
         get { return _parameter.Enabled; }
      }

      public bool HasBeenValidated
      {
         get { return _parameter.HasBeenValidated; }
      }

      //public bool Managed
      //{
      //   get { return _parameter.Managed; }
      //}

      public string Name
      {
         get { return _parameter.Name; }
      }

      public ESRI.ArcGIS.esriSystem.IEnumBSTR ParameterDependencies
      {
         get { return _parameter.ParameterDependencies; }
      }

      public esriGPParameterType ParameterType
      {
         get { return _parameter.ParameterType; }
      }

      //public IGPSchema Schema
      //{
      //   get { return _parameter.Schema; }
      //}

      public IGPValue Value
      {
         get { return _parameter.Value; }
         //set { _parameter.Value=value; }
      }
   }
}
