namespace EOI_new.Setting
{
    partial class PathSetting
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
            this.lblModelDir = new System.Windows.Forms.Label();
            this.txtModelDir = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSelModelDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModelDir
            // 
            this.lblModelDir.AutoSize = true;
            this.lblModelDir.Location = new System.Drawing.Point(21, 67);
            this.lblModelDir.Name = "lblModelDir";
            this.lblModelDir.Size = new System.Drawing.Size(86, 18);
            this.lblModelDir.TabIndex = 0;
            this.lblModelDir.Text = "모델 경로";
            // 
            // txtModelDir
            // 
            this.txtModelDir.Location = new System.Drawing.Point(113, 64);
            this.txtModelDir.Name = "txtModelDir";
            this.txtModelDir.Size = new System.Drawing.Size(370, 28);
            this.txtModelDir.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(468, 345);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 51);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // btnSelModelDir
            // 
            this.btnSelModelDir.Location = new System.Drawing.Point(489, 64);
            this.btnSelModelDir.Name = "btnSelModelDir";
            this.btnSelModelDir.Size = new System.Drawing.Size(54, 28);
            this.btnSelModelDir.TabIndex = 3;
            this.btnSelModelDir.Text = "...";
            this.btnSelModelDir.UseVisualStyleBackColor = true;
            this.btnSelModelDir.Click += new System.EventHandler(this.btnSelModelDir_Click_1);
            // 
            // PathSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelModelDir);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtModelDir);
            this.Controls.Add(this.lblModelDir);
            this.Name = "PathSetting";
            this.Size = new System.Drawing.Size(576, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelDir;
        private System.Windows.Forms.TextBox txtModelDir;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSelModelDir;
    }
}
