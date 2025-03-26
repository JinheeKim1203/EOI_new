namespace EOI_new.Property
{
    partial class FmInspProp
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiffGv = new System.Windows.Forms.Label();
            this.txtDiffGv = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbDiffGvColor = new System.Windows.Forms.ComboBox();
            this.lblDiffGvSize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtSizeY = new System.Windows.Forms.TextBox();
            this.txtSizeX = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiffGv
            // 
            this.lblDiffGv.AutoSize = true;
            this.lblDiffGv.Location = new System.Drawing.Point(49, 58);
            this.lblDiffGv.Name = "lblDiffGv";
            this.lblDiffGv.Size = new System.Drawing.Size(117, 18);
            this.lblDiffGv.TabIndex = 0;
            this.lblDiffGv.Text = "Differance GV";
            // 
            // txtDiffGv
            // 
            this.txtDiffGv.Location = new System.Drawing.Point(189, 55);
            this.txtDiffGv.Name = "txtDiffGv";
            this.txtDiffGv.Size = new System.Drawing.Size(156, 28);
            this.txtDiffGv.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(49, 127);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 18);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // cbDiffGvColor
            // 
            this.cbDiffGvColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiffGvColor.FormattingEnabled = true;
            this.cbDiffGvColor.Location = new System.Drawing.Point(189, 119);
            this.cbDiffGvColor.Name = "cbDiffGvColor";
            this.cbDiffGvColor.Size = new System.Drawing.Size(156, 26);
            this.cbDiffGvColor.TabIndex = 3;
            // 
            // lblDiffGvSize
            // 
            this.lblDiffGvSize.AutoSize = true;
            this.lblDiffGvSize.Location = new System.Drawing.Point(49, 193);
            this.lblDiffGvSize.Name = "lblDiffGvSize";
            this.lblDiffGvSize.Size = new System.Drawing.Size(41, 18);
            this.lblDiffGvSize.TabIndex = 4;
            this.lblDiffGvSize.Text = "Size";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(112, 193);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 18);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(112, 237);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 18);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y";
            // 
            // txtSizeY
            // 
            this.txtSizeY.Location = new System.Drawing.Point(189, 234);
            this.txtSizeY.Name = "txtSizeY";
            this.txtSizeY.Size = new System.Drawing.Size(156, 28);
            this.txtSizeY.TabIndex = 7;
            // 
            // txtSizeX
            // 
            this.txtSizeX.Location = new System.Drawing.Point(189, 183);
            this.txtSizeX.Name = "txtSizeX";
            this.txtSizeX.Size = new System.Drawing.Size(156, 28);
            this.txtSizeX.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(248, 290);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(97, 45);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // FmInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtSizeX);
            this.Controls.Add(this.txtSizeY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblDiffGvSize);
            this.Controls.Add(this.cbDiffGvColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtDiffGv);
            this.Controls.Add(this.lblDiffGv);
            this.Name = "FmInspProp";
            this.Size = new System.Drawing.Size(572, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiffGv;
        private System.Windows.Forms.TextBox txtDiffGv;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbDiffGvColor;
        private System.Windows.Forms.Label lblDiffGvSize;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtSizeY;
        private System.Windows.Forms.TextBox txtSizeX;
        private System.Windows.Forms.Button btnApply;
    }
}
