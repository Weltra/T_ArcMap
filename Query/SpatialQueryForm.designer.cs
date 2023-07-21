namespace TArcMap.GeoProcessing
{
   partial class SpatialQueryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SourceLayer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_spRelation = new System.Windows.Forms.ComboBox();
            this.button_buildFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_targetLayer = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(15, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标图层：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "源图层：";
            // 
            // comboBox_SourceLayer
            // 
            this.comboBox_SourceLayer.FormattingEnabled = true;
            this.comboBox_SourceLayer.Location = new System.Drawing.Point(16, 356);
            this.comboBox_SourceLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SourceLayer.Name = "comboBox_SourceLayer";
            this.comboBox_SourceLayer.Size = new System.Drawing.Size(374, 23);
            this.comboBox_SourceLayer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "空间选择方法：";
            // 
            // comboBox_spRelation
            // 
            this.comboBox_spRelation.FormattingEnabled = true;
            this.comboBox_spRelation.Location = new System.Drawing.Point(15, 433);
            this.comboBox_spRelation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_spRelation.Name = "comboBox_spRelation";
            this.comboBox_spRelation.Size = new System.Drawing.Size(375, 23);
            this.comboBox_spRelation.TabIndex = 5;
            // 
            // button_buildFilter
            // 
            this.button_buildFilter.AutoSize = true;
            this.button_buildFilter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_buildFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_buildFilter.Location = new System.Drawing.Point(75, 480);
            this.button_buildFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_buildFilter.Name = "button_buildFilter";
            this.button_buildFilter.Size = new System.Drawing.Size(244, 47);
            this.button_buildFilter.TabIndex = 7;
            this.button_buildFilter.Text = "Confirm and excuete query";
            this.button_buildFilter.UseVisualStyleBackColor = true;
            this.button_buildFilter.Click += new System.EventHandler(this.button_buildSpFilter_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 54);
            this.label4.TabIndex = 10;
            this.label4.Text = "根据空间位置选择是使用源图层中的要素与目标图层的空间关系（如覆盖、相交等），在目标图层中选择要素的操作。";
            // 
            // comboBox_targetLayer
            // 
            this.comboBox_targetLayer.FormattingEnabled = true;
            this.comboBox_targetLayer.Location = new System.Drawing.Point(15, 290);
            this.comboBox_targetLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_targetLayer.Name = "comboBox_targetLayer";
            this.comboBox_targetLayer.Size = new System.Drawing.Size(375, 23);
            this.comboBox_targetLayer.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_targetLayer);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_SourceLayer);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_spRelation);
            this.splitContainer1.Panel1.Controls.Add(this.button_buildFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1052, 538);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TArcMap.Properties.Resources.openstreet;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 177);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(647, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // SpatialQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1052, 538);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpatialQueryForm";
            this.ShowInTaskbar = false;
            this.Text = "SpatialQueryForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox comboBox_SourceLayer;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox comboBox_spRelation;
      private System.Windows.Forms.Button button_buildFilter;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox comboBox_targetLayer;
      private System.Windows.Forms.SplitContainer splitContainer1;
      public System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}