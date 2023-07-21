using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TArcMap.Edit
{
    public class EditHelper
    {
        public static void StartEditing(IWorkspaceEdit workspaceEdit, IFeatureClass featureClass, bool WithUndoRedo)
        {
            if (featureClass == null)
            {
                return;
            }
            IDataset dataset = featureClass as IDataset;
            workspaceEdit = dataset.Workspace as IWorkspaceEdit;

            try
            {
                workspaceEdit.StartEditing(WithUndoRedo);
            }
            catch
            {
                return;
            }
        }

        public static void StopEditing(IWorkspaceEdit workspaceEdit, bool save)
        {
            if (workspaceEdit == null)
            {
                return;
            }
            if (workspaceEdit.IsBeingEdited() /*== true*/)
            {
                try
                {
                    workspaceEdit.StopEditing(save);
                }
                catch
                {
                    workspaceEdit.AbortEditOperation();
                    return;
                }
            }
        }

        /// <summary>
        /// 将一个可视的距离转换为具体的空间参考下的地理距离
        /// </summary>
        /// <param name="IMapCtrl"></param>
        /// <param name="pixNum"></param>
        /// <returns></returns>
        public static double ConvertPixel2MapUnit(IMapControlDefault IMapCtrl, int pixNum = 3)
        {
            return IMapCtrl.ActiveView.ScreenDisplay.DisplayTransformation.FromPoints(pixNum);
        }

        /// <summary>
        /// 1、对指定的Geometry进行buffer操作；
        /// 2、buffer距离为像素的长度，主要用于根据具体的鼠标操作来选择要素，是一个选择的容差（Tolerance）。
        /// </summary>
        /// <param name="geometry">需要buffer的Geometry</param>
        /// <param name="pixelNum">需要buffer的长度大小</param>
        /// <returns></returns>
        public static IGeometry BufferGeometryByPixel(IMapControlDefault iMapCtrl, IGeometry geometry, int pixelNum = 3)
        {
            double bufferDistance = EditHelper.ConvertPixel2MapUnit(iMapCtrl, pixelNum);
            ITopologicalOperator topoOperator = geometry as ITopologicalOperator;
            IGeometry bufferResult = topoOperator.Buffer(bufferDistance);
            return bufferResult;
        }

        public static List<IFeature> GetFeaturesByGeometry(IMapControlDefault iMapCtrl, IFeatureClass featureClass, IGeometry geometry)
        {
            List<IFeature> selectedFeature = new List<IFeature>();
            selectedFeature.Clear();
            try
            {
                if (geometry is IPoint)
                {
                    geometry = BufferGeometryByPixel(iMapCtrl, geometry);
                }
                ISpatialFilter spatialFilter = new SpatialFilter();
                spatialFilter.Geometry = geometry;
                switch (featureClass.ShapeType)
                {
                    case esriGeometryType.esriGeometryPoint:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                        break;
                    case esriGeometryType.esriGeometryPolygon:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                        break;
                    case esriGeometryType.esriGeometryPolyline:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelCrosses;
                        break;
                }
                spatialFilter.GeometryField = featureClass.ShapeFieldName;
                IQueryFilter filter = spatialFilter as IQueryFilter;

                IFeatureCursor cursor = featureClass.Search(filter, false);
                IFeature pfeature = cursor.NextFeature();
                while (pfeature != null)
                {
                    selectedFeature.Add(pfeature);
                    pfeature = cursor.NextFeature();
                }
                return selectedFeature;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SelectFeature(IMapControlDefault iMapCtrl, IFeatureLayer featureLayer, List<IFeature> featureList)
        {
            foreach (IFeature feature in featureList)
            {
                iMapCtrl.Map.SelectFeature(featureLayer, feature);
            }
            iMapCtrl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
        }

        public static void ClearSelection(IMapControlDefault mapctrl)
        {
            mapctrl.Map.ClearSelection();
            mapctrl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        }

        /// <summary>
        /// 设置鼠标样式
        /// </summary>
        /// <param name="pointer"></param>
        public static void SetMapcontrolMousePointer(IMapControlDefault mapCtrl, esriControlsMousePointer pointer)
        {
            mapCtrl.MousePointer = pointer;
        }

        public static List<IFeature> GetSelectedFeatures(IFeatureLayer featureLayer)
        {
            List<IFeature> selectedFeatureList = new List<IFeature>();
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
            if (featureSelection != null && featureSelection.SelectionSet.Count > 0)
            {
                IEnumIDs enumIds = featureSelection.SelectionSet.IDs;
                //enumIds.Reset();
                int curId = enumIds.Next();
                while (curId != -1)
                {
                    selectedFeatureList.Add(featureLayer.FeatureClass.GetFeature(curId));
                    curId = enumIds.Next();
                }
                return selectedFeatureList;
            }
            else
            {
                return selectedFeatureList;
            }
        }

        /// <summary>
        /// 绘制选择之后的Geometry，高亮显示Segment和Vertex。
        /// </summary>
        /// <param name="geometry">需要绘制的Geometry</param>
        /// <param name="display">绘图设备</param>
        public static void DrawGeometrySketch(IGeometry geometry, IDisplay display)
        {

            IEngineEditProperties engineProperty = new EngineEditorClass();

            ISymbol pointSymbol = engineProperty.SketchVertexSymbol as ISymbol;
            ISymbol sketchSymbol = engineProperty.SketchSymbol as ISymbol;

            ITopologicalOperator pTopo = geometry as ITopologicalOperator;

            sketchSymbol.SetupDC(display.hDC, display.DisplayTransformation);
            sketchSymbol.Draw(pTopo.Boundary);

            IPointCollection pointCol = geometry as IPointCollection;
            for (int i = 0; i < pointCol.PointCount; i++)
            {
                IPoint point = pointCol.get_Point(i);
                pointSymbol.SetupDC(display.hDC, display.DisplayTransformation);
                pointSymbol.Draw(point);
                pointSymbol.ResetDC();
            }

            //m_MapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, m_SelectedLayer, null);
            ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(sketchSymbol);
            ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(pointSymbol);
            ESRI.ArcGIS.ADF.ComReleaser.ReleaseCOMObject(engineProperty);


        }

        public static bool GetVertexByPoint(AxMapControl mapCtrl, IPoint snapLocation, IGeometry snapContainer, ref int vetexOffset, ref int vetexIndex)
        {
            IHitTest iHit = snapContainer as IHitTest;
            IMapControlDefault iMapCtrl = mapCtrl.Object as IMapControlDefault;

            double tol = EditHelper.ConvertPixel2MapUnit(iMapCtrl, 5);
            double hitDist = -1;
            IPoint pHitPoint = null;
            int partIndex = -1;
            int pointIndex = -1;
            bool rightSide = false;

            bool hitResult = iHit.HitTest
                (QueryPoint: snapLocation,
                searchRadius: tol,
                geometryPart: esriGeometryHitPartType.esriGeometryPartVertex,
                hitPoint: pHitPoint,
                hitDistance: ref hitDist,
                hitPartIndex: ref partIndex,
                hitSegmentIndex: ref pointIndex,
                bRightSide: ref rightSide);

            vetexOffset = 0;
            if (partIndex > 0)
            {
                IGeometryCollection geometryList = snapContainer as IGeometryCollection;
                for (int i = 0; i < partIndex; i++)
                {
                    IPointCollection pointCollection = geometryList.Geometry[i] as IPointCollection;
                    vetexOffset += pointCollection.PointCount;
                }
            }
            vetexIndex = pointIndex;

            return hitResult;
        }

        public static bool GetSegmentByPoint(AxMapControl mapCtrl, IPoint snapLocation, IGeometry snapContainer, ref int segmentIndex)
        {
            IHitTest iHit = snapContainer as IHitTest;
            IMapControlDefault iMapCtrl = mapCtrl.Object as IMapControlDefault;

            double tol = EditHelper.ConvertPixel2MapUnit(iMapCtrl, 5);
            double hitDist = -1;
            IPoint pHitPoint = null;
            int partIndex = -1;
            segmentIndex = -1;
            bool rightSide = false;

            bool hitResult = iHit.HitTest
                (QueryPoint: snapLocation,
                searchRadius: tol,
                geometryPart: esriGeometryHitPartType.esriGeometryPartBoundary,
                hitPoint: pHitPoint,
                hitDistance: ref hitDist,
                hitPartIndex: ref partIndex,
                hitSegmentIndex: ref segmentIndex,
                bRightSide: ref rightSide);

            return hitResult;
        }
    }
}
