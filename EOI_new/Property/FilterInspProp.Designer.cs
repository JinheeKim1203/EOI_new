namespace EOI_new.Property
{
    partial class FilterInspProp
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
            this.grpImgFilter = new System.Windows.Forms.GroupBox();
            this.btnapply = new System.Windows.Forms.Button();
            this.cmbSelectFilter2 = new System.Windows.Forms.ComboBox();
            this.cmbSelectFilter1 = new System.Windows.Forms.ComboBox();
            this.grpImgFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpImgFilter
            // 
            this.grpImgFilter.Controls.Add(this.btnapply);
            this.grpImgFilter.Controls.Add(this.cmbSelectFilter2);
            this.grpImgFilter.Controls.Add(this.cmbSelectFilter1);
            this.grpImgFilter.Location = new System.Drawing.Point(37, 47);
            this.grpImgFilter.Name = "grpImgFilter";
            this.grpImgFilter.Size = new System.Drawing.Size(374, 242);
            this.grpImgFilter.TabIndex = 0;
            this.grpImgFilter.TabStop = false;
            this.grpImgFilter.Text = "이미지필터";
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(60, 159);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(84, 34);
            this.btnapply.TabIndex = 2;
            this.btnapply.Text = "적용";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // cmbSelectFilter2
            // 
            this.cmbSelectFilter2.FormattingEnabled = true;
            this.cmbSelectFilter2.Location = new System.Drawing.Point(60, 103);
            this.cmbSelectFilter2.Name = "cmbSelectFilter2";
            this.cmbSelectFilter2.Size = new System.Drawing.Size(232, 26);
            this.cmbSelectFilter2.TabIndex = 1;
            this.cmbSelectFilter2.SelectedIndexChanged += new System.EventHandler(this.cmbSelectFilter2_SelectedIndexChanged);
            // 
            // cmbSelectFilter1
            // 
            this.cmbSelectFilter1.FormattingEnabled = true;
            this.cmbSelectFilter1.Items.AddRange(new object[] {
            "연산",
            "비트연산",
            "블러링",
            "엣지"});
            this.cmbSelectFilter1.Location = new System.Drawing.Point(60, 55);
            this.cmbSelectFilter1.Name = "cmbSelectFilter1";
            this.cmbSelectFilter1.Size = new System.Drawing.Size(232, 26);
            this.cmbSelectFilter1.TabIndex = 0;
            this.cmbSelectFilter1.Text = "적용할 필터를 선택하세요";
            this.cmbSelectFilter1.SelectedIndexChanged += new System.EventHandler(this.cmbSelectFilter1_SelectedIndexChanged_1);
            this.cmbSelectFilter1.Enter += new System.EventHandler(this.cmbSelectFilter2_SelectedIndexChanged);
            // 
            // FilterInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpImgFilter);
            this.Name = "FilterInspProp";
            this.Size = new System.Drawing.Size(470, 347);
            this.grpImgFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpImgFilter;
        private System.Windows.Forms.ComboBox cmbSelectFilter2;
        private System.Windows.Forms.ComboBox cmbSelectFilter1;
        private System.Windows.Forms.Button btnapply;
    }
}
