namespace EOI_new.Setting
{
    partial class NetworkSetting
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
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblCommunicationType = new System.Windows.Forms.Label();
            this.cbCommunicationType = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(47, 159);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(96, 18);
            this.lblIpAddress.TabIndex = 0;
            this.lblIpAddress.Text = "IP Address";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(50, 196);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(304, 28);
            this.txtIpAddress.TabIndex = 1;
            // 
            // lblCommunicationType
            // 
            this.lblCommunicationType.AutoSize = true;
            this.lblCommunicationType.Location = new System.Drawing.Point(47, 39);
            this.lblCommunicationType.Name = "lblCommunicationType";
            this.lblCommunicationType.Size = new System.Drawing.Size(179, 18);
            this.lblCommunicationType.TabIndex = 2;
            this.lblCommunicationType.Text = "Communication Type";
            // 
            // cbCommunicationType
            // 
            this.cbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommunicationType.FormattingEnabled = true;
            this.cbCommunicationType.Location = new System.Drawing.Point(50, 74);
            this.cbCommunicationType.Name = "cbCommunicationType";
            this.cbCommunicationType.Size = new System.Drawing.Size(304, 26);
            this.cbCommunicationType.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(450, 337);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(79, 56);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // NetworkSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbCommunicationType);
            this.Controls.Add(this.lblCommunicationType);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.lblIpAddress);
            this.Name = "NetworkSetting";
            this.Size = new System.Drawing.Size(571, 434);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblCommunicationType;
        private System.Windows.Forms.ComboBox cbCommunicationType;
        private System.Windows.Forms.Button btnApply;
    }
}
