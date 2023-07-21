namespace TArcMap.Edit
{
    partial class EditVectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVectorForm));
            this.tsl_toolName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSelectByPoint = new System.Windows.Forms.ToolStripButton();
            this.tsbSelectByPolygon = new System.Windows.Forms.ToolStripButton();
            this.tsbMove = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbCreatePoint = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbSketchLine = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateLine = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsbSketchPolygon = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnEndEdit = new System.Windows.Forms.Button();
            this.btnStartEdit = new System.Windows.Forms.Button();
            this.cbLayerList = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsl_toolName
            // 
            this.tsl_toolName.Name = "tsl_toolName";
            this.tsl_toolName.Size = new System.Drawing.Size(167, 20);
            this.tsl_toolName.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabel1.Text = "Current tool:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsl_toolName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(570, 25);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(24, 135);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(517, 138);
            this.tabControl2.TabIndex = 24;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.toolStrip1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(509, 109);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Basic Tools";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelectByPoint,
            this.tsbSelectByPolygon,
            this.tsbMove});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(3, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 81);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "tsBasicEdit";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSelectByPoint
            // 
            this.tsbSelectByPoint.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectByPoint.Image")));
            this.tsbSelectByPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectByPoint.Name = "tsbSelectByPoint";
            this.tsbSelectByPoint.Size = new System.Drawing.Size(139, 24);
            this.tsbSelectByPoint.Text = "Select by point";
            // 
            // tsbSelectByPolygon
            // 
            this.tsbSelectByPolygon.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectByPolygon.Image")));
            this.tsbSelectByPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectByPolygon.Name = "tsbSelectByPolygon";
            this.tsbSelectByPolygon.Size = new System.Drawing.Size(161, 24);
            this.tsbSelectByPolygon.Text = "Select by polygon";
            // 
            // tsbMove
            // 
            this.tsbMove.Image = ((System.Drawing.Image)(resources.GetObject("tsbMove.Image")));
            this.tsbMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMove.Name = "tsbMove";
            this.tsbMove.Size = new System.Drawing.Size(200, 24);
            this.tsbMove.Text = "Move selected features";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 281);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 86);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(507, 57);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point edit tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCreatePoint});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip2.Location = new System.Drawing.Point(3, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(501, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbCreatePoint
            // 
            this.tsbCreatePoint.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreatePoint.Image")));
            this.tsbCreatePoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreatePoint.Name = "tsbCreatePoint";
            this.tsbCreatePoint.Size = new System.Drawing.Size(119, 24);
            this.tsbCreatePoint.Text = "Create Point";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(507, 57);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Polyline edit tools";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSketchLine,
            this.tsbCreateLine});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip3.Location = new System.Drawing.Point(3, 2);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(501, 54);
            this.toolStrip3.TabIndex = 7;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSketchLine
            // 
            this.tsbSketchLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbSketchLine.Image")));
            this.tsbSketchLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSketchLine.Name = "tsbSketchLine";
            this.tsbSketchLine.Size = new System.Drawing.Size(138, 24);
            this.tsbSketchLine.Text = "Edit line sketch";
            // 
            // tsbCreateLine
            // 
            this.tsbCreateLine.Image = global::TArcMap.Properties.Resources.line;
            this.tsbCreateLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateLine.Name = "tsbCreateLine";
            this.tsbCreateLine.Size = new System.Drawing.Size(138, 24);
            this.tsbCreateLine.Text = "Create Polyline";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(507, 57);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polygon edit tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSketchPolygon});
            this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip4.Location = new System.Drawing.Point(3, 2);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(501, 27);
            this.toolStrip4.TabIndex = 8;
            this.toolStrip4.Text = "toolStrip4";
            this.toolStrip4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSketchPolygon
            // 
            this.tsbSketchPolygon.Image = ((System.Drawing.Image)(resources.GetObject("tsbSketchPolygon.Image")));
            this.tsbSketchPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSketchPolygon.Name = "tsbSketchPolygon";
            this.tsbSketchPolygon.Size = new System.Drawing.Size(173, 24);
            this.tsbSketchPolygon.Text = "Edit polygon sketch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Feature Layer List:";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEdit.Enabled = false;
            this.btnSaveEdit.Location = new System.Drawing.Point(406, 69);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(135, 49);
            this.btnSaveEdit.TabIndex = 21;
            this.btnSaveEdit.Text = "save edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndEdit.Enabled = false;
            this.btnEndEdit.Location = new System.Drawing.Point(216, 69);
            this.btnEndEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(135, 49);
            this.btnEndEdit.TabIndex = 20;
            this.btnEndEdit.Text = "end edit";
            this.btnEndEdit.UseVisualStyleBackColor = true;
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnStartEdit
            // 
            this.btnStartEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartEdit.Enabled = false;
            this.btnStartEdit.Location = new System.Drawing.Point(25, 69);
            this.btnStartEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartEdit.Name = "btnStartEdit";
            this.btnStartEdit.Size = new System.Drawing.Size(135, 49);
            this.btnStartEdit.TabIndex = 19;
            this.btnStartEdit.Text = "start edit";
            this.btnStartEdit.UseVisualStyleBackColor = true;
            this.btnStartEdit.Click += new System.EventHandler(this.btnStartEdit_Click);
            // 
            // cbLayerList
            // 
            this.cbLayerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLayerList.FormattingEnabled = true;
            this.cbLayerList.Location = new System.Drawing.Point(25, 35);
            this.cbLayerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLayerList.Name = "cbLayerList";
            this.cbLayerList.Size = new System.Drawing.Size(516, 23);
            this.cbLayerList.TabIndex = 18;
            this.cbLayerList.SelectedIndexChanged += new System.EventHandler(this.cbLayerList_SelectedIndexChanged_1);
            this.cbLayerList.Click += new System.EventHandler(this.cbLayerList_SelectedIndexChanged);
            // 
            // EditVectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 402);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.btnEndEdit);
            this.Controls.Add(this.btnStartEdit);
            this.Controls.Add(this.cbLayerList);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditVectorForm";
            this.Text = "EditVectorForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditVectorForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tsl_toolName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSelectByPoint;
        private System.Windows.Forms.ToolStripButton tsbSelectByPolygon;
        private System.Windows.Forms.ToolStripButton tsbMove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCreatePoint;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbSketchLine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton tsbSketchPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnEndEdit;
        private System.Windows.Forms.Button btnStartEdit;
        private System.Windows.Forms.ComboBox cbLayerList;
        private System.Windows.Forms.ToolStripButton tsbCreateLine;
    }
}