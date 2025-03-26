namespace EOI_new
{
    partial class NewModel
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
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelInfo = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtModelInfo = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(41, 36);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(62, 18);
            this.lblModelName.TabIndex = 0;
            this.lblModelName.Text = "모델명";
            // 
            // lblModelInfo
            // 
            this.lblModelInfo.AutoSize = true;
            this.lblModelInfo.Location = new System.Drawing.Point(41, 108);
            this.lblModelInfo.Name = "lblModelInfo";
            this.lblModelInfo.Size = new System.Drawing.Size(86, 18);
            this.lblModelInfo.TabIndex = 1;
            this.lblModelInfo.Text = "모델 정보";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(133, 33);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(287, 28);
            this.txtModelName.TabIndex = 2;
            // 
            // txtModelInfo
            // 
            this.txtModelInfo.Location = new System.Drawing.Point(133, 105);
            this.txtModelInfo.Name = "txtModelInfo";
            this.txtModelInfo.Size = new System.Drawing.Size(287, 205);
            this.txtModelInfo.TabIndex = 3;
            this.txtModelInfo.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(474, 33);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 56);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "만들기";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtModelInfo);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblModelInfo);
            this.Controls.Add(this.lblModelName);
            this.Name = "NewModel";
            this.Text = "NewModel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblModelInfo;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.RichTextBox txtModelInfo;
        private System.Windows.Forms.Button btnCreate;
    }
}