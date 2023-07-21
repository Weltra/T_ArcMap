using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using System.Collections.Generic;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using TArcMap.Edit;

namespace TArcMap.Tools.Basic
{
    /// <summary>
    /// Summary description for Move.
    /// </summary>
    [Guid("fa329423-5b4d-4bc0-8fdf-e65c1a6da226")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("TArcMap.Tools.Basic.Move")]
    public sealed class Move : BaseTool
    {
        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Register(regKey);
            ControlsCommands.Register(regKey);
        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Unregister(regKey);
            ControlsCommands.Unregister(regKey);
        }

        #endregion
        #endregion

        private IHookHelper m_hookHelper = null;

        private EditParameter _para;
        public EditParameter EditingParameter
        {
            get { return this._para; }
            set { this._para = value; }
        }

        private List<IDisplayFeedback> _feedBackList = new List<IDisplayFeedback>();


        public Move()
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text 
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyTool")
            try
            {
                //
                // TODO: change resource name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        public Move(EditParameter para)
            : this()
        {
            this._para = para;
        }

        private void synchronizeSelectionSet()
        {
            this._para.SelectedFeatures.Clear();
            IFeatureSelection featureSelection = this._para.FeatureLayer as IFeatureSelection;
            if (featureSelection != null && featureSelection.SelectionSet.Count > 0)
            {
                IEnumIDs enumIds = featureSelection.SelectionSet.IDs;
                //enumIds.Reset();
                int curId = enumIds.Next();
                while (curId != -1)
                {
                    this._para.SelectedFeatures.Add(this._para.FeatureClass.GetFeature(curId));
                    curId = enumIds.Next();
                }
            }
        }

        private IDisplayFeedback _buildFeedback(esriGeometryType geometryType)
        {
            IDisplayFeedback feedback;
            switch (geometryType)
            {
                case esriGeometryType.esriGeometryPoint:
                    feedback = new MovePointFeedbackClass();
                    return feedback;
                case esriGeometryType.esriGeometryPolyline:
                    feedback = new MoveLineFeedbackClass();
                    return feedback;
                case esriGeometryType.esriGeometryPolygon:
                    feedback = new MovePolygonFeedbackClass();
                    return feedback;
                default:
                    return null;
            }
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this tool is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            try
            {
                m_hookHelper = new HookHelperClass();
                m_hookHelper.Hook = hook;
                if (m_hookHelper.ActiveView == null)
                {
                    m_hookHelper = null;
                }
            }
            catch
            {
                m_hookHelper = null;
            }

            if (m_hookHelper == null)
                base.m_enabled = false;
            else
                base.m_enabled = true;

            // TODO:  Add other initialization code
        }

        /// <summary>
        /// Occurs when this tool is clicked
        /// </summary>
        public override void OnClick()
        {
        }

        private bool mouseIsDown = false;
        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            this.mouseIsDown = true;
            IMapControlDefault mapCtrl = this.m_hookHelper.Hook as IMapControlDefault;
            IPoint startPoint = mapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
            this.synchronizeSelectionSet();
            this._feedBackList.Clear();
            foreach (IFeature curFeature in this._para.SelectedFeatures)
            {
                IGeometry curGeometry = curFeature.Shape;
                switch (this._para.FeatureClass.ShapeType)
                {
                    case esriGeometryType.esriGeometryPoint:
                        IMovePointFeedback pointFeedBack = new MovePointFeedbackClass();
                        this._feedBackList.Add(pointFeedBack);
                        pointFeedBack.Display = mapCtrl.ActiveView.ScreenDisplay;
                        IMovePointFeedback pointMoveFeedback = pointFeedBack as IMovePointFeedback;
                        pointMoveFeedback.Start(curGeometry as IPoint, startPoint);
                        break;
                    case esriGeometryType.esriGeometryPolygon:

                        IMovePolygonFeedback movePolygonfeedBack = new MovePolygonFeedbackClass();
                        this._feedBackList.Add(movePolygonfeedBack);
                        movePolygonfeedBack.Display = mapCtrl.ActiveView.ScreenDisplay;
                        IMovePolygonFeedback polygonMoveFeedback = movePolygonfeedBack as IMovePolygonFeedback;
                        polygonMoveFeedback.Start(curGeometry as IPolygon, startPoint);
                        break;
                    case esriGeometryType.esriGeometryPolyline:
                        IMoveLineFeedback movePolylineFeedBack = new MoveLineFeedbackClass();
                        this._feedBackList.Add(movePolylineFeedBack);
                        movePolylineFeedBack.Display = mapCtrl.ActiveView.ScreenDisplay;
                        IMoveLineFeedback lineMoveFeedback = movePolylineFeedBack as IMoveLineFeedback;
                        lineMoveFeedback.Start(curGeometry as IPolyline, startPoint);
                        break;
                    default:
                        break;
                }
            }
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            if (mouseIsDown && this._feedBackList != null && this._para.SelectedFeatures.Count > 0)
            {
                IMapControlDefault mapCtrl = this.m_hookHelper.Hook as IMapControlDefault;
                IPoint movePoint = mapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                foreach (var curFeedback in this._feedBackList)
                {
                    curFeedback.MoveTo(movePoint);
                }
            }
        }

        List<IGeometry> endGeometryList = new List<IGeometry>();
        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            IMapControlDefault mapCtrl = this.m_hookHelper.Hook as IMapControlDefault;
            this.mouseIsDown = false;
            this.endGeometryList.Clear();
            foreach (var curFeedback in this._feedBackList)
            {
                IGeometry endGeometry = null;
                if ((curFeedback as IMovePointFeedback) != null)
                {
                    IMovePointFeedback pointMoveFeedback = curFeedback as IMovePointFeedback;
                    endGeometry = pointMoveFeedback.Stop();
                }
                else if ((curFeedback as IMoveLineFeedback) != null)
                {
                    IMoveLineFeedback lineMoveFeedback = curFeedback as IMoveLineFeedback;
                    endGeometry = lineMoveFeedback.Stop();
                }
                else if ((curFeedback as IMovePolygonFeedback) != null)
                {
                    IMovePolygonFeedback polygonMoveFeedback = curFeedback as IMovePolygonFeedback;
                    endGeometry = polygonMoveFeedback.Stop();
                }
                this.endGeometryList.Add(endGeometry);
            }
            //update feature shape
            this._para.WorkspaceEdit.StartEditOperation();

            for (int i = 0; i < _para.SelectedFeatures.Count; i++)
            {
                _para.SelectedFeatures[i].Shape = this.endGeometryList[i];
                _para.SelectedFeatures[i].Store();
            }
            mapCtrl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);

            _para.WorkspaceEdit.StopEditOperation();
        }
        #endregion
    }
}
