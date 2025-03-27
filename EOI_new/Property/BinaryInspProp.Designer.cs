namespace EOI_new.Property
{
    partial class BinaryInspProp
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
                if (trackBarLower != null)
                    trackBarLower.ValueChanged -= OnValueChanged;

                if (trackBarUpper != null)
                    trackBarUpper.ValueChanged -= OnValueChanged;

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBinary = new System.Windows.Forms.GroupBox();
            this.chkShowBinary = new System.Windows.Forms.CheckBox();
            this.chkInvert = new System.Windows.Forms.CheckBox();
            this.chkHighlight = new System.Windows.Forms.CheckBox();
            this.trackBarUpper = new System.Windows.Forms.TrackBar();
            this.trackBarLower = new System.Windows.Forms.TrackBar();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkRotatedRect = new System.Windows.Forms.CheckBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtHeightMax = new System.Windows.Forms.TextBox();
            this.txtHeightMin = new System.Windows.Forms.TextBox();
            this.txtWidthMax = new System.Windows.Forms.TextBox();
            this.txtWidthMin = new System.Windows.Forms.TextBox();
            this.txtAreaMax = new System.Windows.Forms.TextBox();
            this.txtAreaMin = new System.Windows.Forms.TextBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.chkWidth = new System.Windows.Forms.CheckBox();
            this.chkArea = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grpBinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBinary
            // 
            this.grpBinary.Controls.Add(this.chkShowBinary);
            this.grpBinary.Controls.Add(this.chkInvert);
            this.grpBinary.Controls.Add(this.chkHighlight);
            this.grpBinary.Controls.Add(this.trackBarUpper);
            this.grpBinary.Controls.Add(this.trackBarLower);
            this.grpBinary.Location = new System.Drawing.Point(14, 14);
            this.grpBinary.Margin = new System.Windows.Forms.Padding(4);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.Padding = new System.Windows.Forms.Padding(4);
            this.grpBinary.Size = new System.Drawing.Size(434, 255);
            this.grpBinary.TabIndex = 0;
            this.grpBinary.TabStop = false;
            this.grpBinary.Text = "이진화";
            // 
            // chkShowBinary
            // 
            this.chkShowBinary.AutoSize = true;
            this.chkShowBinary.Location = new System.Drawing.Point(179, 188);
            this.chkShowBinary.Name = "chkShowBinary";
            this.chkShowBinary.Size = new System.Drawing.Size(88, 22);
            this.chkShowBinary.TabIndex = 6;
            this.chkShowBinary.Text = "이진화";
            this.chkShowBinary.UseVisualStyleBackColor = true;
            this.chkShowBinary.CheckedChanged += new System.EventHandler(this.chkBinaryOnly_CheckedChanged);
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Location = new System.Drawing.Point(33, 218);
            this.chkInvert.Name = "chkInvert";
            this.chkInvert.Size = new System.Drawing.Size(70, 22);
            this.chkInvert.TabIndex = 5;
            this.chkInvert.Text = "반전";
            this.chkInvert.UseVisualStyleBackColor = true;
            this.chkInvert.CheckedChanged += new System.EventHandler(this.chkInvert_CheckedChanged);
            // 
            // chkHighlight
            // 
            this.chkHighlight.AutoSize = true;
            this.chkHighlight.Checked = true;
            this.chkHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHighlight.Location = new System.Drawing.Point(33, 188);
            this.chkHighlight.Margin = new System.Windows.Forms.Padding(4);
            this.chkHighlight.Name = "chkHighlight";
            this.chkHighlight.Size = new System.Drawing.Size(99, 22);
            this.chkHighlight.TabIndex = 3;
            this.chkHighlight.Text = "Highlight";
            this.chkHighlight.UseVisualStyleBackColor = true;
            this.chkHighlight.CheckedChanged += new System.EventHandler(this.chkHighlight_CheckedChanged);
            // 
            // trackBarUpper
            // 
            this.trackBarUpper.Location = new System.Drawing.Point(33, 111);
            this.trackBarUpper.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarUpper.Maximum = 255;
            this.trackBarUpper.Name = "trackBarUpper";
            this.trackBarUpper.Size = new System.Drawing.Size(313, 69);
            this.trackBarUpper.TabIndex = 1;
            this.trackBarUpper.Value = 255;
            // 
            // trackBarLower
            // 
            this.trackBarLower.Location = new System.Drawing.Point(33, 34);
            this.trackBarLower.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLower.Maximum = 255;
            this.trackBarLower.Name = "trackBarLower";
            this.trackBarLower.Size = new System.Drawing.Size(313, 69);
            this.trackBarLower.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkRotatedRect);
            this.grpFilter.Controls.Add(this.lblMax);
            this.grpFilter.Controls.Add(this.lblMin);
            this.grpFilter.Controls.Add(this.txtHeightMax);
            this.grpFilter.Controls.Add(this.txtHeightMin);
            this.grpFilter.Controls.Add(this.txtWidthMax);
            this.grpFilter.Controls.Add(this.txtWidthMin);
            this.grpFilter.Controls.Add(this.txtAreaMax);
            this.grpFilter.Controls.Add(this.txtAreaMin);
            this.grpFilter.Controls.Add(this.chkHeight);
            this.grpFilter.Controls.Add(this.chkWidth);
            this.grpFilter.Controls.Add(this.chkArea);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Location = new System.Drawing.Point(14, 276);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(434, 314);
            this.grpFilter.TabIndex = 7;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // chkRotatedRect
            // 
            this.chkRotatedRect.AutoSize = true;
            this.chkRotatedRect.Location = new System.Drawing.Point(13, 230);
            this.chkRotatedRect.Name = "chkRotatedRect";
            this.chkRotatedRect.Size = new System.Drawing.Size(132, 22);
            this.chkRotatedRect.TabIndex = 8;
            this.chkRotatedRect.Text = "RotatedRect";
            this.chkRotatedRect.UseVisualStyleBackColor = true;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(336, 24);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(43, 18);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(147, 24);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(36, 18);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "Min";
            // 
            // txtHeightMax
            // 
            this.txtHeightMax.Location = new System.Drawing.Point(284, 172);
            this.txtHeightMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeightMax.Name = "txtHeightMax";
            this.txtHeightMax.Size = new System.Drawing.Size(141, 28);
            this.txtHeightMax.TabIndex = 11;
            // 
            // txtHeightMin
            // 
            this.txtHeightMin.Location = new System.Drawing.Point(106, 172);
            this.txtHeightMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeightMin.Name = "txtHeightMin";
            this.txtHeightMin.Size = new System.Drawing.Size(141, 28);
            this.txtHeightMin.TabIndex = 10;
            // 
            // txtWidthMax
            // 
            this.txtWidthMax.Location = new System.Drawing.Point(284, 118);
            this.txtWidthMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidthMax.Name = "txtWidthMax";
            this.txtWidthMax.Size = new System.Drawing.Size(141, 28);
            this.txtWidthMax.TabIndex = 9;
            // 
            // txtWidthMin
            // 
            this.txtWidthMin.Location = new System.Drawing.Point(106, 118);
            this.txtWidthMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidthMin.Name = "txtWidthMin";
            this.txtWidthMin.Size = new System.Drawing.Size(141, 28);
            this.txtWidthMin.TabIndex = 8;
            // 
            // txtAreaMax
            // 
            this.txtAreaMax.Location = new System.Drawing.Point(284, 64);
            this.txtAreaMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaMax.Name = "txtAreaMax";
            this.txtAreaMax.Size = new System.Drawing.Size(141, 28);
            this.txtAreaMax.TabIndex = 7;
            // 
            // txtAreaMin
            // 
            this.txtAreaMin.Location = new System.Drawing.Point(106, 66);
            this.txtAreaMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaMin.Name = "txtAreaMin";
            this.txtAreaMin.Size = new System.Drawing.Size(141, 28);
            this.txtAreaMin.TabIndex = 6;
            // 
            // chkHeight
            // 
            this.chkHeight.AutoSize = true;
            this.chkHeight.Location = new System.Drawing.Point(13, 180);
            this.chkHeight.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeight.Name = "chkHeight";
            this.chkHeight.Size = new System.Drawing.Size(83, 22);
            this.chkHeight.TabIndex = 5;
            this.chkHeight.Text = "Height";
            this.chkHeight.UseVisualStyleBackColor = true;
            this.chkHeight.CheckedChanged += new System.EventHandler(this.chkHeight_CheckedChanged);
            // 
            // chkWidth
            // 
            this.chkWidth.AutoSize = true;
            this.chkWidth.Location = new System.Drawing.Point(13, 128);
            this.chkWidth.Margin = new System.Windows.Forms.Padding(4);
            this.chkWidth.Name = "chkWidth";
            this.chkWidth.Size = new System.Drawing.Size(77, 22);
            this.chkWidth.TabIndex = 4;
            this.chkWidth.Text = "Width";
            this.chkWidth.UseVisualStyleBackColor = true;
            this.chkWidth.CheckedChanged += new System.EventHandler(this.chkWidth_CheckedChanged);
            // 
            // chkArea
            // 
            this.chkArea.AutoSize = true;
            this.chkArea.Location = new System.Drawing.Point(13, 69);
            this.chkArea.Margin = new System.Windows.Forms.Padding(4);
            this.chkArea.Name = "chkArea";
            this.chkArea.Size = new System.Drawing.Size(72, 22);
            this.chkArea.TabIndex = 3;
            this.chkArea.Text = "Area";
            this.chkArea.UseVisualStyleBackColor = true;
            this.chkArea.CheckedChanged += new System.EventHandler(this.chkArea_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(324, 218);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 34);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "필터적용";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // BinaryInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpBinary);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BinaryInspProp";
            this.Size = new System.Drawing.Size(466, 606);
            this.grpBinary.ResumeLayout(false);
            this.grpBinary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBinary;
        private System.Windows.Forms.TrackBar trackBarUpper;
        private System.Windows.Forms.TrackBar trackBarLower;
        private System.Windows.Forms.CheckBox chkHighlight;
        private System.Windows.Forms.CheckBox chkInvert;
        private System.Windows.Forms.CheckBox chkShowBinary;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtHeightMax;
        private System.Windows.Forms.TextBox txtHeightMin;
        private System.Windows.Forms.TextBox txtWidthMax;
        private System.Windows.Forms.TextBox txtWidthMin;
        private System.Windows.Forms.TextBox txtAreaMax;
        private System.Windows.Forms.TextBox txtAreaMin;
        private System.Windows.Forms.CheckBox chkHeight;
        private System.Windows.Forms.CheckBox chkWidth;
        private System.Windows.Forms.CheckBox chkArea;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox chkRotatedRect;
    }
}
