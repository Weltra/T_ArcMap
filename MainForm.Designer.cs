namespace TArcMap
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMdbFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGdbFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInbyRectangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInbyCircleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInbyGeometryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutbyRectangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutbyCircleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutbyGeometryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.geoProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoProcessingToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.tocMenu4Layer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAttributeTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectByPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectByPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMenu4Map = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开所有图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭所有图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMenu4Legend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolToolsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.tocMenu4Layer.SuspendLayout();
            this.tocMenu4Map.SuspendLayout();
            this.tocMenu4Legend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolStripMenuItem2,
            this.queryToolStripMenuItem,
            this.geoProcessingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1416, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.menuSeparator,
            this.menuExitApp,
            this.openFileToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuNewDoc
            // 
            this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
            this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuNewDoc.Name = "menuNewDoc";
            this.menuNewDoc.Size = new System.Drawing.Size(210, 24);
            this.menuNewDoc.Text = "New Document";
            this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
            // 
            // menuOpenDoc
            // 
            this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
            this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenDoc.Name = "menuOpenDoc";
            this.menuOpenDoc.Size = new System.Drawing.Size(210, 24);
            this.menuOpenDoc.Text = "Open Document...";
            this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
            // 
            // menuSaveDoc
            // 
            this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
            this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveDoc.Name = "menuSaveDoc";
            this.menuSaveDoc.Size = new System.Drawing.Size(210, 24);
            this.menuSaveDoc.Text = "SaveDocument";
            this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(210, 24);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(207, 6);
            // 
            // menuExitApp
            // 
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(210, 24);
            this.menuExitApp.Text = "Exit";
            this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openShapefileToolStripMenuItem,
            this.openMdbFileToolStripMenuItem,
            this.openGdbFileToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openFileToolStripMenuItem.Text = "Open file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.openToolStripMenuItem.Text = "Open mxd file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openMxdFileToolStripMenuItem_Click);
            // 
            // openShapefileToolStripMenuItem
            // 
            this.openShapefileToolStripMenuItem.Name = "openShapefileToolStripMenuItem";
            this.openShapefileToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.openShapefileToolStripMenuItem.Text = "Open shape file";
            this.openShapefileToolStripMenuItem.Click += new System.EventHandler(this.openShapefileToolStripMenuItem_Click);
            // 
            // openMdbFileToolStripMenuItem
            // 
            this.openMdbFileToolStripMenuItem.Name = "openMdbFileToolStripMenuItem";
            this.openMdbFileToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.openMdbFileToolStripMenuItem.Text = "Open mdb file";
            this.openMdbFileToolStripMenuItem.Click += new System.EventHandler(this.openMdbFileToolStripMenuItem_Click);
            // 
            // openGdbFileToolStripMenuItem
            // 
            this.openGdbFileToolStripMenuItem.Name = "openGdbFileToolStripMenuItem";
            this.openGdbFileToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.openGdbFileToolStripMenuItem.Text = "Open gdb file";
            this.openGdbFileToolStripMenuItem.Click += new System.EventHandler(this.openGdbFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomInToolStripMenuItem,
            this.ZoomOutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem1.Text = "View";
            // 
            // ZoomInToolStripMenuItem
            // 
            this.ZoomInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomInbyRectangleToolStripMenuItem1,
            this.ZoomInbyCircleToolStripMenuItem1,
            this.ZoomInbyGeometryToolStripMenuItem1});
            this.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem";
            this.ZoomInToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ZoomInToolStripMenuItem.Text = "放大";
            // 
            // ZoomInbyRectangleToolStripMenuItem1
            // 
            this.ZoomInbyRectangleToolStripMenuItem1.Name = "ZoomInbyRectangleToolStripMenuItem1";
            this.ZoomInbyRectangleToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomInbyRectangleToolStripMenuItem1.Text = "按矩形框放大";
            this.ZoomInbyRectangleToolStripMenuItem1.Click += new System.EventHandler(this.按矩形框放大ToolStripMenuItem_Click);
            // 
            // ZoomInbyCircleToolStripMenuItem1
            // 
            this.ZoomInbyCircleToolStripMenuItem1.Name = "ZoomInbyCircleToolStripMenuItem1";
            this.ZoomInbyCircleToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomInbyCircleToolStripMenuItem1.Text = "按圆形放大";
            this.ZoomInbyCircleToolStripMenuItem1.Click += new System.EventHandler(this.按圆形放大ToolStripMenuItem_Click);
            // 
            // ZoomInbyGeometryToolStripMenuItem1
            // 
            this.ZoomInbyGeometryToolStripMenuItem1.Name = "ZoomInbyGeometryToolStripMenuItem1";
            this.ZoomInbyGeometryToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomInbyGeometryToolStripMenuItem1.Text = "按多边形放大";
            this.ZoomInbyGeometryToolStripMenuItem1.Click += new System.EventHandler(this.按多边形放大ToolStripMenuItem_Click);
            // 
            // ZoomOutToolStripMenuItem
            // 
            this.ZoomOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomOutbyRectangleToolStripMenuItem1,
            this.ZoomOutbyCircleToolStripMenuItem1,
            this.ZoomOutbyGeometryToolStripMenuItem1});
            this.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem";
            this.ZoomOutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ZoomOutToolStripMenuItem.Text = "缩小";
            // 
            // ZoomOutbyRectangleToolStripMenuItem1
            // 
            this.ZoomOutbyRectangleToolStripMenuItem1.Name = "ZoomOutbyRectangleToolStripMenuItem1";
            this.ZoomOutbyRectangleToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomOutbyRectangleToolStripMenuItem1.Text = "按矩形框缩小";
            this.ZoomOutbyRectangleToolStripMenuItem1.Click += new System.EventHandler(this.按矩形框缩小ToolStripMenuItem_Click);
            // 
            // ZoomOutbyCircleToolStripMenuItem1
            // 
            this.ZoomOutbyCircleToolStripMenuItem1.Name = "ZoomOutbyCircleToolStripMenuItem1";
            this.ZoomOutbyCircleToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomOutbyCircleToolStripMenuItem1.Text = "按圆形缩小";
            this.ZoomOutbyCircleToolStripMenuItem1.Click += new System.EventHandler(this.按圆形缩小ToolStripMenuItem_Click);
            // 
            // ZoomOutbyGeometryToolStripMenuItem1
            // 
            this.ZoomOutbyGeometryToolStripMenuItem1.Name = "ZoomOutbyGeometryToolStripMenuItem1";
            this.ZoomOutbyGeometryToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.ZoomOutbyGeometryToolStripMenuItem1.Text = "按多边形缩小";
            this.ZoomOutbyGeometryToolStripMenuItem1.Click += new System.EventHandler(this.按多边形缩小ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 24);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attributeQueryToolStripMenuItem,
            this.toolStripMenuItem3});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // attributeQueryToolStripMenuItem
            // 
            this.attributeQueryToolStripMenuItem.Name = "attributeQueryToolStripMenuItem";
            this.attributeQueryToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.attributeQueryToolStripMenuItem.Text = "Attribute Query";
            this.attributeQueryToolStripMenuItem.Click += new System.EventHandler(this.attributeQueryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 24);
            this.toolStripMenuItem3.Text = "Spatial Query";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.spatialQueryToolSripMenuItem_Click);
            // 
            // geoProcessingToolStripMenuItem
            // 
            this.geoProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geoProcessingToolsToolStripMenuItem,
            this.bufferToolToolStripMenuItem,
            this.overlapToolToolStripMenuItem});
            this.geoProcessingToolStripMenuItem.Name = "geoProcessingToolStripMenuItem";
            this.geoProcessingToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.geoProcessingToolStripMenuItem.Text = "GeoProcessing";
            // 
            // geoProcessingToolsToolStripMenuItem
            // 
            this.geoProcessingToolsToolStripMenuItem.Image = global::TArcMap.Properties.Resources.GeoprocessingToolbox64;
            this.geoProcessingToolsToolStripMenuItem.Name = "geoProcessingToolsToolStripMenuItem";
            this.geoProcessingToolsToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.geoProcessingToolsToolStripMenuItem.Text = "GeoProcessing Tools";
            this.geoProcessingToolsToolStripMenuItem.Click += new System.EventHandler(this.geoProcessingToolsToolStripMenuItem_Click);
            // 
            // bufferToolToolStripMenuItem
            // 
            this.bufferToolToolStripMenuItem.Name = "bufferToolToolStripMenuItem";
            this.bufferToolToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.bufferToolToolStripMenuItem.Text = "Buffer Tool";
            this.bufferToolToolStripMenuItem.Click += new System.EventHandler(this.bufferToolToolStripMenuItem_Click);
            // 
            // overlapToolToolStripMenuItem
            // 
            this.overlapToolToolStripMenuItem.Name = "overlapToolToolStripMenuItem";
            this.overlapToolToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.overlapToolToolStripMenuItem.Text = "Overlap Tool";
            this.overlapToolToolStripMenuItem.Click += new System.EventHandler(this.overlapToolToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 56);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 620);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
            this.statusStrip1.Location = new System.Drawing.Point(4, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1412, 25);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(71, 20);
            this.statusBarXY.Text = "Test 123";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(472, 226);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 28);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1416, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(239, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 595);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axLicenseControl1);
            this.tabPage1.Controls.Add(this.axMapControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(1169, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(3, 3);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1163, 560);
            this.axMapControl1.TabIndex = 2;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axPageLayoutControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(1169, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Layout";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(1163, 560);
            this.axPageLayoutControl1.TabIndex = 3;
            // 
            // tocMenu4Layer
            // 
            this.tocMenu4Layer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveLayerToolStripMenuItem,
            this.OpenAttributeTableToolStripMenuItem1,
            this.selectToolStripMenuItem});
            this.tocMenu4Layer.Name = "contextMenuStrip1";
            this.tocMenu4Layer.Size = new System.Drawing.Size(173, 76);
            // 
            // RemoveLayerToolStripMenuItem
            // 
            this.RemoveLayerToolStripMenuItem.Name = "RemoveLayerToolStripMenuItem";
            this.RemoveLayerToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.RemoveLayerToolStripMenuItem.Text = "移除(R)";
            this.RemoveLayerToolStripMenuItem.Click += new System.EventHandler(this.移除ToolStripMenuItem_Click);
            // 
            // OpenAttributeTableToolStripMenuItem1
            // 
            this.OpenAttributeTableToolStripMenuItem1.Name = "OpenAttributeTableToolStripMenuItem1";
            this.OpenAttributeTableToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.OpenAttributeTableToolStripMenuItem1.Text = "打开属性表(T)";
            this.OpenAttributeTableToolStripMenuItem1.Click += new System.EventHandler(this.OpenAttributeTableToolStripMenuItem1_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectByPointToolStripMenuItem,
            this.selectByPolygonToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectByPointToolStripMenuItem
            // 
            this.selectByPointToolStripMenuItem.Name = "selectByPointToolStripMenuItem";
            this.selectByPointToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.selectByPointToolStripMenuItem.Text = "Select by point";
            this.selectByPointToolStripMenuItem.Click += new System.EventHandler(this.selectByPointToolStripMenuItem_Click);
            // 
            // selectByPolygonToolStripMenuItem
            // 
            this.selectByPolygonToolStripMenuItem.Name = "selectByPolygonToolStripMenuItem";
            this.selectByPolygonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.selectByPolygonToolStripMenuItem.Text = "Select by polygon";
            this.selectByPolygonToolStripMenuItem.Click += new System.EventHandler(this.selectByPolygonToolStripMenuItem_Click);
            // 
            // tocMenu4Map
            // 
            this.tocMenu4Map.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.打开所有图层ToolStripMenuItem,
            this.关闭所有图层ToolStripMenuItem});
            this.tocMenu4Map.Name = "contextMenuStrip2";
            this.tocMenu4Map.Size = new System.Drawing.Size(188, 76);
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.addDataToolStripMenuItem.Text = "添加数据(T)";
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.addDataToolStripMenuItem_Click);
            // 
            // 打开所有图层ToolStripMenuItem
            // 
            this.打开所有图层ToolStripMenuItem.Name = "打开所有图层ToolStripMenuItem";
            this.打开所有图层ToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.打开所有图层ToolStripMenuItem.Text = "打开所有图层(Y)";
            // 
            // 关闭所有图层ToolStripMenuItem
            // 
            this.关闭所有图层ToolStripMenuItem.Name = "关闭所有图层ToolStripMenuItem";
            this.关闭所有图层ToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.关闭所有图层ToolStripMenuItem.Text = "关闭所有图层(L)";
            // 
            // tocMenu4Legend
            // 
            this.tocMenu4Legend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem});
            this.tocMenu4Legend.Name = "contextMenuStrip3";
            this.tocMenu4Legend.Size = new System.Drawing.Size(159, 28);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.changeColorToolStripMenuItem.Text = "更改颜色(C)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axTOCControl1.Location = new System.Drawing.Point(4, 56);
            this.axTOCControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(235, 595);
            this.axTOCControl1.TabIndex = 4;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolToolsStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editToolToolsStripMenuItem
            // 
            this.editToolToolsStripMenuItem.Name = "editToolToolsStripMenuItem";
            this.editToolToolsStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.editToolToolsStripMenuItem.Text = "Edit Tools";
            this.editToolToolsStripMenuItem.Click += new System.EventHandler(this.editToolToolsStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 676);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "TArcMap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.tocMenu4Layer.ResumeLayout(false);
            this.tocMenu4Map.ResumeLayout(false);
            this.tocMenu4Legend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private System.Windows.Forms.ToolStripMenuItem ZoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomInbyRectangleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZoomInbyCircleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZoomInbyGeometryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutbyRectangleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutbyCircleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutbyGeometryToolStripMenuItem1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMdbFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGdbFileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private System.Windows.Forms.ContextMenuStrip tocMenu4Layer;
        private System.Windows.Forms.ToolStripMenuItem RemoveLayerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tocMenu4Map;
        private System.Windows.Forms.ContextMenuStrip tocMenu4Legend;
        private System.Windows.Forms.ToolStripMenuItem OpenAttributeTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开所有图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭所有图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectByPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectByPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem attributeQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geoProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geoProcessingToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlapToolToolStripMenuItem;
        public ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolToolsStripMenuItem;
    }
}

