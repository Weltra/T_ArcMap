namespace TArcMap.GeoProcessing
{
    partial class AttributeQueryForm
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
            this.comBoxLayerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxValues = new System.Windows.Forms.ListBox();
            this.ListBoxFields = new System.Windows.Forms.ListBox();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnParentheses = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnLTE = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnMTE = new System.Windows.Forms.Button();
            this.btnMT = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSelectResult = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxLayerName
            // 
            this.comBoxLayerName.FormattingEnabled = true;
            this.comBoxLayerName.Location = new System.Drawing.Point(111, 12);
            this.comBoxLayerName.Name = "comBoxLayerName";
            this.comBoxLayerName.Size = new System.Drawing.Size(345, 23);
            this.comBoxLayerName.TabIndex = 41;
            this.comBoxLayerName.SelectedIndexChanged += new System.EventHandler(this.comBoxLayerName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "图层名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(16, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Select * from Layer Where: ";
            // 
            // ListBoxValues
            // 
            this.ListBoxValues.FormattingEnabled = true;
            this.ListBoxValues.ItemHeight = 15;
            this.ListBoxValues.Location = new System.Drawing.Point(336, 57);
            this.ListBoxValues.Name = "ListBoxValues";
            this.ListBoxValues.Size = new System.Drawing.Size(120, 199);
            this.ListBoxValues.TabIndex = 59;
            // 
            // ListBoxFields
            // 
            this.ListBoxFields.FormattingEnabled = true;
            this.ListBoxFields.ItemHeight = 15;
            this.ListBoxFields.Location = new System.Drawing.Point(15, 57);
            this.ListBoxFields.Name = "ListBoxFields";
            this.ListBoxFields.Size = new System.Drawing.Size(120, 199);
            this.ListBoxFields.TabIndex = 58;
            this.ListBoxFields.SelectedIndexChanged += new System.EventHandler(this.ListBoxFields_SelectedIndexChanged);
            this.ListBoxFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxFields_MouseDoubleClick);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(208, 189);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(59, 27);
            this.btnNot.TabIndex = 57;
            this.btnNot.Text = "Not";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnIs
            // 
            this.btnIs.Location = new System.Drawing.Point(143, 189);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(59, 27);
            this.btnIs.TabIndex = 56;
            this.btnIs.Text = "Is";
            this.btnIs.UseVisualStyleBackColor = true;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnParentheses
            // 
            this.btnParentheses.Location = new System.Drawing.Point(273, 156);
            this.btnParentheses.Name = "btnParentheses";
            this.btnParentheses.Size = new System.Drawing.Size(59, 27);
            this.btnParentheses.TabIndex = 55;
            this.btnParentheses.Text = "()";
            this.btnParentheses.UseVisualStyleBackColor = true;
            this.btnParentheses.Click += new System.EventHandler(this.btnParentheses_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(208, 156);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(59, 27);
            this.btnDiv.TabIndex = 54;
            this.btnDiv.Text = "%";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(143, 156);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(59, 27);
            this.btnSub.TabIndex = 53;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(273, 123);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(59, 27);
            this.btnOr.TabIndex = 52;
            this.btnOr.Text = "Or";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnLTE
            // 
            this.btnLTE.Location = new System.Drawing.Point(208, 123);
            this.btnLTE.Name = "btnLTE";
            this.btnLTE.Size = new System.Drawing.Size(59, 27);
            this.btnLTE.TabIndex = 51;
            this.btnLTE.Text = "<=";
            this.btnLTE.UseVisualStyleBackColor = true;
            this.btnLTE.Click += new System.EventHandler(this.btnLTE_Click);
            // 
            // btnLT
            // 
            this.btnLT.Location = new System.Drawing.Point(143, 123);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(59, 27);
            this.btnLT.TabIndex = 50;
            this.btnLT.Text = "<";
            this.btnLT.UseVisualStyleBackColor = true;
            this.btnLT.Click += new System.EventHandler(this.btnLT_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(273, 90);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(59, 27);
            this.btnAnd.TabIndex = 49;
            this.btnAnd.Text = "And";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnMTE
            // 
            this.btnMTE.Location = new System.Drawing.Point(208, 90);
            this.btnMTE.Name = "btnMTE";
            this.btnMTE.Size = new System.Drawing.Size(59, 27);
            this.btnMTE.TabIndex = 48;
            this.btnMTE.Text = ">=";
            this.btnMTE.UseVisualStyleBackColor = true;
            this.btnMTE.Click += new System.EventHandler(this.btnMTE_Click);
            // 
            // btnMT
            // 
            this.btnMT.Location = new System.Drawing.Point(143, 90);
            this.btnMT.Name = "btnMT";
            this.btnMT.Size = new System.Drawing.Size(59, 27);
            this.btnMT.TabIndex = 47;
            this.btnMT.Text = ">";
            this.btnMT.UseVisualStyleBackColor = true;
            this.btnMT.Click += new System.EventHandler(this.btnMT_Click);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(273, 57);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(59, 27);
            this.btnLike.TabIndex = 46;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(208, 57);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(59, 27);
            this.btnNotEqual.TabIndex = 45;
            this.btnNotEqual.Text = "<>";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(143, 57);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(59, 27);
            this.btnEqual.TabIndex = 44;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(65, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 37);
            this.button1.TabIndex = 64;
            this.button1.Text = "Confirm and Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSelectResult
            // 
            this.txtSelectResult.Location = new System.Drawing.Point(15, 304);
            this.txtSelectResult.Multiline = true;
            this.txtSelectResult.Name = "txtSelectResult";
            this.txtSelectResult.Size = new System.Drawing.Size(441, 115);
            this.txtSelectResult.TabIndex = 62;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comBoxLayerName);
            this.splitContainer1.Panel1.Controls.Add(this.btnEqual);
            this.splitContainer1.Panel1.Controls.Add(this.btnLike);
            this.splitContainer1.Panel1.Controls.Add(this.btnNotEqual);
            this.splitContainer1.Panel1.Controls.Add(this.btnMT);
            this.splitContainer1.Panel1.Controls.Add(this.btnMTE);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnLT);
            this.splitContainer1.Panel1.Controls.Add(this.btnLTE);
            this.splitContainer1.Panel1.Controls.Add(this.btnOr);
            this.splitContainer1.Panel1.Controls.Add(this.btnSub);
            this.splitContainer1.Panel1.Controls.Add(this.btnDiv);
            this.splitContainer1.Panel1.Controls.Add(this.btnParentheses);
            this.splitContainer1.Panel1.Controls.Add(this.btnIs);
            this.splitContainer1.Panel1.Controls.Add(this.btnNot);
            this.splitContainer1.Panel1.Controls.Add(this.ListBoxFields);
            this.splitContainer1.Panel1.Controls.Add(this.ListBoxValues);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtSelectResult);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 519);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 65;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(617, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // AttributeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 519);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AttributeQueryForm";
            this.Text = "AttributeQueryForm";
            this.Load += new System.EventHandler(this.AttributeQueryForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxLayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxValues;
        private System.Windows.Forms.ListBox ListBoxFields;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnParentheses;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnLTE;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnMTE;
        private System.Windows.Forms.Button btnMT;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSelectResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}