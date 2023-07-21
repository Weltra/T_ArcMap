# T_ArcMap
地信开发实验写的所有代码，实现了ArcGIS的一些基础功能，仿照了HomeWin老师的代码，封装了类和对象，但是比HomeWin的代码要简单易懂，代码详细解释在我的博客https://www.cnblogs.com/tangjielin/

项目文件结构：
```
MapControlApplication1
├─ AddFile
│  ├─ Addfiledb
│  │  ├─ Openfilegdb.bmp
│  │  └─ Openfilegdb.cs
│  ├─ Addmdb
│  │  ├─ Openmdb.bmp
│  │  └─ Openmdb.cs
│  ├─ Addmxdfile
│  │  ├─ Openmxdfile.bmp
│  │  └─ Openmxdfile.cs
│  ├─ Addshpfile
│  │  ├─ Openshpfile.bmp
│  │  └─ Openshpfile.cs
│  └─ FileClass.cs
├─ AttributeTable.cs
├─ AttributeTable.Designer.cs
├─ AttributeTable.resx
├─ bin
│  ├─ Debug
│  │  ├─ MapControlApplication1.exe
│  │  ├─ MapControlApplication1.pdb
│  │  ├─ MapControlApplication1.vshost.exe.manifest
│  │  ├─ TArcMap.exe
│  │  ├─ TArcMap.pdb
│  │  ├─ TArcMap.vshost.exe
│  │  └─ TArcMap.vshost.exe.manifest
│  └─ Release
├─ CoClass.cs
├─ CreateNewDocument.cs
├─ Earth.ico
├─ Edit
│  ├─ EditHelper.cs
│  ├─ EditParameters.cs
│  ├─ EditVectorForm.cs
│  ├─ EditVectorForm.Designer.cs
│  └─ EditVectorForm.resx
├─ GeoProcessing
│  ├─ BufferAnalysisTool.cs
│  ├─ BufferAnalysisTool.Designer.cs
│  ├─ BufferAnalysisTool.resx
│  ├─ frmGpTools.cs
│  ├─ frmGpTools.Designer.cs
│  ├─ frmGpTools.resx
│  ├─ GpManager.cs
│  ├─ GpParameterCtrl.cs
│  ├─ GpParameterCtrl.Designer.cs
│  ├─ GpParameterCtrl.resx
│  ├─ KeyValuePropertyGrid.cs
│  ├─ OverlayAnalysisTool.cs
│  ├─ OverlayAnalysisTool.Designer.cs
│  └─ OverlayAnalysisTool.resx
├─ MainForm.cs
├─ MainForm.Designer.cs
├─ MainForm.resx
├─ Navigation
│  ├─ ZoomInByCircle.bmp
│  ├─ ZoomInByCircle.cs
│  ├─ ZoomInByCircle.cur
│  ├─ ZoomInByPolygon.bmp
│  ├─ ZoomInByPolygon.cs
│  ├─ ZoomInByPolygon.cur
│  ├─ ZoomInByRectangle.bmp
│  ├─ ZoomInByRectangle.cs
│  ├─ ZoomInByRectangle.cur
│  ├─ ZoomOutByCircle.bmp
│  ├─ ZoomOutByCircle.cs
│  ├─ ZoomOutByCircle.cur
│  ├─ ZoomOutByPolygon.bmp
│  ├─ ZoomOutByPolygon.cs
│  ├─ ZoomOutByPolygon.cur
│  ├─ ZoomOutByRectangle.bmp
│  ├─ ZoomOutByRectangle.cs
│  └─ ZoomOutByRectangle.cur
├─ obj
│  └─ x86
│     └─ Debug
│        ├─ DesignTimeResolveAssemblyReferences.cache
│        ├─ DesignTimeResolveAssemblyReferencesInput.cache
│        ├─ MapControlApplication1.csproj.FileListAbsolute.txt
│        ├─ MapControlApplication1.csproj.GenerateResource.Cache
│        ├─ MapControlApplication1.csprojResolveAssemblyReference.cache
│        ├─ MapControlApplication1.exe
│        ├─ MapControlApplication1.pdb
│        ├─ TArcMap.AttributeTable.resources
│        ├─ TArcMap.csproj.FileListAbsolute.txt
│        ├─ TArcMap.csproj.GenerateResource.Cache
│        ├─ TArcMap.csprojResolveAssemblyReference.cache
│        ├─ TArcMap.Edit.EditVectorForm.resources
│        ├─ TArcMap.exe
│        ├─ TArcMap.GeoProcessing.AttributeQueryForm.resources
│        ├─ TArcMap.GeoProcessing.BufferAnalysisTool.resources
│        ├─ TArcMap.GeoProcessing.frmGpTools.resources
│        ├─ TArcMap.GeoProcessing.OverlayAnalysisTool.resources
│        ├─ TArcMap.GeoProcessing.SpatialQueryForm.resources
│        ├─ TArcMap.GpParameterCtrl.resources
│        ├─ TArcMap.MainForm.resources
│        ├─ TArcMap.pdb
│        ├─ TArcMap.Properties.Resources.resources
│        ├─ TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
│        ├─ TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
│        ├─ TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
│        └─ TempPE
│           └─ Properties.Resources.Designer.cs.dll
├─ Program.cs
├─ Properties
│  ├─ AssemblyInfo.cs
│  ├─ Resources.Designer.cs
│  ├─ Resources.resx
│  ├─ Settings.Designer.cs
│  └─ Settings.settings
├─ Query
│  ├─ AttributeQueryForm.cs
│  ├─ AttributeQueryForm.Designer.cs
│  ├─ AttributeQueryForm.resx
│  ├─ SpatialQueryForm.cs
│  ├─ SpatialQueryForm.designer.cs
│  └─ SpatialQueryForm.resx
├─ Resources
│  ├─ GenericBlackAdd.ico
│  ├─ GenericBlackAddSmall.ico
│  ├─ GenericBlackArrowBottom.ico
│  ├─ GenericBlackArrowDown.ico
│  ├─ GenericBlackArrowDownSmall.ico
│  ├─ GenericBlackArrowEnd.ico
│  ├─ GenericBlackArrowLeft.ico
│  ├─ GenericBlackArrowRight.ico
│  ├─ GenericBlackArrowStart.ico
│  ├─ GenericBlackArrowTop.ico
│  ├─ GenericBlackArrowUp.ico
│  ├─ GenericBlackArrowUpSmall.ico
│  ├─ GenericBlackDelete.ico
│  ├─ GenericBlackEndSmall.ico
│  ├─ GenericBlackNextSmall.ico
│  ├─ GenericBlackPlay.ico
│  ├─ GenericBlackPreviousSmall.ico
│  ├─ GenericBlackPreviousTiny.ico
│  ├─ GenericBlackRightArrowNoTail.ico
│  ├─ GenericBlackStartSmall.ico
│  ├─ GenericBlackStop.ico
│  ├─ GenericBlackSubtractSmall.ico
│  ├─ GenericBlackZoomTo100Percent.ico
│  ├─ GeoprocessingToolbox64.png
│  ├─ line.png
│  ├─ QQ图片20230406113411.png
│  └─ VetexMove.ico
├─ Select
│  ├─ ByPoint
│  │  ├─ PointSelect.bmp
│  │  ├─ PointSelect.cs
│  │  └─ PointSelect.cur
│  ├─ ByPolygon
│  │  ├─ PolygonSelect.bmp
│  │  ├─ PolygonSelect.cs
│  │  └─ PolygonSelect.cur
│  └─ SelectionProperty.cs
├─ TArcMap.csproj
├─ TArcMap.csproj.user
├─ TOCControlHelper.cs
├─ Tools
│  ├─ Basic
│  │  ├─ Move.bmp
│  │  ├─ Move.cs
│  │  ├─ Move.cur
│  │  ├─ SelectByPoint.bmp
│  │  ├─ SelectByPoint.cs
│  │  ├─ SelectByPoint.cur
│  │  ├─ SelectByPolygon.bmp
│  │  ├─ SelectByPolygon.cs
│  │  ├─ SelectByPolygon.cur
│  │  ├─ SelectByRectangle.bmp
│  │  ├─ SelectByRectangle.cs
│  │  └─ SelectByRectangle.cur
│  ├─ Point
│  │  ├─ Create.bmp
│  │  ├─ Create.cs
│  │  └─ Create.cur
│  ├─ Polygon
│  │  ├─ .docstates.suo
│  │  ├─ SketchPolygon.bmp
│  │  ├─ SketchPolygon.cs
│  │  └─ SketchPolygon.cur
│  └─ Polyline
│     ├─ CreatePolyline.bmp
│     ├─ CreatePolyline.cs
│     └─ CreatePolyline.cur
└─ XMLSchema1.xsd

```

