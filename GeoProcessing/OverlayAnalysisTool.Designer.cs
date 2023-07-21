namespace TArcMap.GeoProcessing
{
    partial class OverlayAnalysisTool
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_InputDataset = new System.Windows.Forms.ComboBox();
            this.comboBox_ClipDataset = new System.Windows.Forms.ComboBox();
            this.textEdit_Output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入数据集：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "裁剪数据集：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "输出路径：";
            // 
            // comboBox_InputDataset
            // 
            this.comboBox_InputDataset.FormattingEnabled = true;
            this.comboBox_InputDataset.Location = new System.Drawing.Point(115, 32);
            this.comboBox_InputDataset.Name = "comboBox_InputDataset";
            this.comboBox_InputDataset.Size = new System.Drawing.Size(399, 23);
            this.comboBox_InputDataset.TabIndex = 3;
            // 
            // comboBox_ClipDataset
            // 
            this.comboBox_ClipDataset.FormattingEnabled = true;
            this.comboBox_ClipDataset.Location = new System.Drawing.Point(115, 79);
            this.comboBox_ClipDataset.Name = "comboBox_ClipDataset";
            this.comboBox_ClipDataset.Size = new System.Drawing.Size(399, 23);
            this.comboBox_ClipDataset.TabIndex = 4;
            // 
            // textEdit_Output
            // 
            this.textEdit_Output.Location = new System.Drawing.Point(115, 123);
            this.textEdit_Output.Name = "textEdit_Output";
            this.textEdit_Output.Size = new System.Drawing.Size(302, 25);
            this.textEdit_Output.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.simpleButton_Output_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_OK_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // OverlayAnalysisTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 243);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEdit_Output);
            this.Controls.Add(this.comboBox_ClipDataset);
            this.Controls.Add(this.comboBox_InputDataset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OverlayAnalysisTool";
            this.Text = "OverlayAnalysisTool";
            this.Load += new System.EventHandler(this.OverlayAnalysisTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_InputDataset;
        private System.Windows.Forms.ComboBox comboBox_ClipDataset;
        private System.Windows.Forms.TextBox textEdit_Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}