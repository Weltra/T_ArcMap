using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;

namespace TArcMap.Tools.Polygon
{
    /// <summary>
    /// Summary description for SketchPolygon.
    /// </summary>
    [Guid("2e650de5-60d9-4b9b-9c0a-04691a6c5dc6")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("TArcMap.Tools.Polygon.SketchPolygon")]
    public sealed class SketchPolygon : BaseTool
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

        private TArcMap.Edit.EditParameter _para;
        public TArcMap.Edit.EditParameter EditingParameter
        {
            get { return this._para; }
            set { this._para = value; }
        }

        public SketchPolygon()
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
                //base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
                base.m_cursor = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        public SketchPolygon(TArcMap.Edit.EditParameter para)
            : this()
        {
            this._para = para;
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

        }

        void _mapCtrl_OnAfterDraw(object sender, IMapControlEvents2_OnAfterDrawEvent e)
        {
            esriViewDrawPhase curPhase = (esriViewDrawPhase)e.viewDrawPhase;
            if (curPhase == esriViewDrawPhase.esriViewForeground && this._para.CurrentGeomtry != null)
            {
                TArcMap.Edit.EditHelper.DrawGeometrySketch(this._para.CurrentGeomtry, e.display as IDisplay);
            }
        }

        public override bool Deactivate()
        {
            if (this._para.MapCtrl == null)
            {
                return false;
            }
            else
            {
                this._para.MapCtrl.OnAfterDraw -= this._mapCtrl_OnAfterDraw;
            }
            return base.Deactivate();
        }

        /// <summary>
        /// Occurs when this tool is clicked
        /// </summary>
        public override void OnClick()
        {
            this._para.MapCtrl.OnAfterDraw += new IMapControlEvents2_Ax_OnAfterDrawEventHandler(_mapCtrl_OnAfterDraw);

            _para.SelectedFeatures = TArcMap.Edit.EditHelper.GetSelectedFeatures(_para.FeatureLayer);
            if (this._para.SelectedFeatures == null)
            {
                return;
            }
            else if (this._para.SelectedFeatures.Count > 0)
            {
                _para.CurrentFeature = _para.SelectedFeatures[0];
                _para.CurrentGeomtry = _para.SelectedFeatures[0].Shape;
                //触发对geometry的绘制。
            }
            else
            {
                return;
            }
            _para.MapCtrl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);

        }

        private bool _mouseDown = false;
        private IPoint _startPoint;
        private IPolygonMovePointFeedback _polygonDisplayFeedback;

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            this._mouseDown = true;
            if (vetexIndex >= 0)
            {
                _startPoint = this._para.iMapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                _polygonDisplayFeedback = new PolygonMovePointFeedbackClass();
                _polygonDisplayFeedback.Display = this._para.iMapCtrl.ActiveView.ScreenDisplay;
                _polygonDisplayFeedback.Start(_para.CurrentGeomtry as IPolygon, vetexOffset + vetexIndex, this._startPoint);
            }
        }

        int vetexOffset = -1;
        int vetexIndex = -1;
        int segmentIndex = -1;

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            //鼠标没有点下去，只修改mouse cursor。
            if (this._mouseDown == false)
            {
                IPoint mousePoint = this._para.iMapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);


                bool hitVetexResult = TArcMap.Edit.EditHelper.GetVertexByPoint(this._para.MapCtrl, mousePoint, this._para.SelectedFeatures[0].Shape, ref vetexOffset, ref vetexIndex);
                bool hitBoundaryResult = TArcMap.Edit.EditHelper.GetSegmentByPoint(this._para.MapCtrl, mousePoint, this._para.SelectedFeatures[0].Shape, ref segmentIndex);
                if (hitVetexResult)
                {
                    IMapControlDefault iMapCtrl = this.m_hookHelper.Hook as IMapControlDefault;
                    System.Windows.Forms.Cursor vetexMove = new System.Windows.Forms.Cursor(Properties.Resources.VetexMove.Handle);
                    this.m_cursor = vetexMove;
                }
                //else if (hitBoundaryResult)
                //{
                //   IMapControlDefault iMapCtrl = this.m_hookHelper.Hook as IMapControlDefault;
                //   System.Windows.Forms.Cursor vetexMove = new System.Windows.Forms.Cursor(Properties.Resources.SegmentMove.Handle);
                //   this.m_cursor = vetexMove;
                //}
                else
                {
                    this.m_cursor = null;
                }
            }
            //如果鼠标按下，则开始移动节点或者Segment。
            else if (this._mouseDown == true)
            {
                if (this._polygonDisplayFeedback != null)
                {
                    IPoint curPoint = this._para.iMapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                    this._polygonDisplayFeedback.MoveTo(curPoint);
                }
            }

        }

        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            if (this._mouseDown == true)
            {
                if (this._polygonDisplayFeedback != null)
                {
                    IPolygon endPolygon = this._polygonDisplayFeedback.Stop();
                    this._para.CurrentFeature.Shape = endPolygon;
                    this._para.CurrentFeature.Store();
                    this._para.iMapCtrl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
                }
            }
            this._mouseDown = false;
        }
        #endregion
    }
}
