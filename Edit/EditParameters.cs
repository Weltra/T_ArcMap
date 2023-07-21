using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;

namespace TArcMap.Edit
{
    public interface IParameter
    {
        EditParameter EditingParameter
        {
            get;
            set;
        }
    }

    public class EditParameter
    {
        private AxMapControl _mapCtrl;
        public AxMapControl MapCtrl
        {
            get { return this._mapCtrl; }
            set
            {
                this._mapCtrl = value;
                this._iMapCtrl = this._mapCtrl.Object as IMapControlDefault;
            }
        }

        private IMapControlDefault _iMapCtrl;
        public IMapControlDefault iMapCtrl
        {
            get { return this._iMapCtrl; }
            set { this._iMapCtrl = value; }
        }

        private IWorkspaceEdit _workspaceEdit;
        public IWorkspaceEdit WorkspaceEdit
        {
            get
            {
                return this._workspaceEdit;
            }
            set
            {
                this._workspaceEdit = value;
            }
        }

        private IFeatureLayer _featureLayer;
        public IFeatureLayer FeatureLayer
        {
            set
            {
                this._featureLayer = value;
                this.FeatureClass = this._featureLayer.FeatureClass;
            }
            get
            {
                return this._featureLayer;
            }
        }

        private IFeatureClass _editFeatureClass;
        public IFeatureClass FeatureClass
        {
            get
            {
                return this._editFeatureClass;
            }
            set
            {
                this._editFeatureClass = value;
                this._workspaceEdit = (this._editFeatureClass as IDataset).Workspace as IWorkspaceEdit;
            }
        }

        private List<IFeature> _selectedfeatures;
        public List<IFeature> SelectedFeatures
        {
            get { return this._selectedfeatures; }
            set { this._selectedfeatures = value; }
        }

        private IGeometry _geometry;
        public IGeometry CurrentGeomtry
        {
            get { return this._geometry; }
            set
            {
                this._geometry = value;
            }
        }

        private IFeature _curFeature;
        public IFeature CurrentFeature
        {
            get { return this._curFeature; }
            set
            {
                this._curFeature = value;
                this._geometry = this._curFeature.Shape;
            }
        }

        private BaseTool _curTool;
        public BaseTool CurrentTool
        {
            get { return this._curTool; }
            set
            {
                this._curTool = value;
                this._iMapCtrl.CurrentTool = this._curTool;
                //将tool的初始化过程代码放置在这里，简化界面编程。
                this._curTool.OnCreate(this._mapCtrl.Object);
                this._curTool.OnClick();
            }
        }

        private IEngineEditProperties _editProperties;
        public IEngineEditProperties EditProperties
        {
            get { return this._editProperties; }
            set { this._editProperties = value; }
        }

        private ISelectionEnvironment _selectionEnvironment;
        public ISelectionEnvironment SelectionEnvironment
        {
            get { return this._selectionEnvironment; }
            set { this._selectionEnvironment = value; }
        }

        private EditParameter()
        {
            this._editProperties = new EngineEditorClass();
            this._selectionEnvironment = new SelectionEnvironment();
        }

        public EditParameter(AxMapControl mapCtrl)
            : this()
        {
            this._mapCtrl = mapCtrl;
            this._iMapCtrl = mapCtrl.Object as IMapControlDefault;
        }

        public EditParameter(IMapControlDefault iMapCtrlDefault)
            : this()
        {
            this.iMapCtrl = iMapCtrlDefault;
        }
    }
}
