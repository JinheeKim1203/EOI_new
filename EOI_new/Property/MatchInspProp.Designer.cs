namespace EOI_new.Property
{
    partial class MatchInspProp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMatch = new System.Windows.Forms.GroupBox();
            this.btnTeach = new System.Windows.Forms.Button();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.txtExtendY = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtExtendX = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbExtend = new System.Windows.Forms.Label();
            this.txtMatchCount = new System.Windows.Forms.TextBox();
            this.grpMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMatch
            // 
            this.grpMatch.Controls.Add(this.txtMatchCount);
            this.grpMatch.Controls.Add(this.btnTeach);
            this.grpMatch.Controls.Add(this.lblMatchCount);
            this.grpMatch.Controls.Add(this.btnSearch);
            this.grpMatch.Controls.Add(this.lbScore);
            this.grpMatch.Controls.Add(this.txtExtendY);
            this.grpMatch.Controls.Add(this.txtScore);
            this.grpMatch.Controls.Add(this.txtExtendX);
            this.grpMatch.Controls.Add(this.lbX);
            this.grpMatch.Controls.Add(this.lbExtend);
            this.grpMatch.Location = new System.Drawing.Point(4, 4);
            this.grpMatch.Margin = new System.Windows.Forms.Padding(4);
            this.grpMatch.Name = "grpMatch";
            this.grpMatch.Padding = new System.Windows.Forms.Padding(4);
            this.grpMatch.Size = new System.Drawing.Size(400, 378);
            this.grpMatch.TabIndex = 0;
            this.grpMatch.TabStop = false;
            this.grpMatch.Text = "패턴매칭";
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(7, 137);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(85, 35);
            this.btnTeach.TabIndex = 6;
            this.btnTeach.Text = "티칭";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.AutoSize = true;
            this.lblMatchCount.Location = new System.Drawing.Point(10, 104);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Size = new System.Drawing.Size(86, 18);
            this.lblMatchCount.TabIndex = 5;
            this.lblMatchCount.Text = "매칭 갯수";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(124, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(10, 68);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(98, 18);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "매칭스코어";
            // 
            // txtExtendY
            // 
            this.txtExtendY.Location = new System.Drawing.Point(230, 18);
            this.txtExtendY.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtendY.Name = "txtExtendY";
            this.txtExtendY.Size = new System.Drawing.Size(70, 28);
            this.txtExtendY.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(124, 63);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(176, 28);
            this.txtScore.TabIndex = 1;
            // 
            // txtExtendX
            // 
            this.txtExtendX.Location = new System.Drawing.Point(124, 18);
            this.txtExtendX.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtendX.Name = "txtExtendX";
            this.txtExtendX.Size = new System.Drawing.Size(70, 28);
            this.txtExtendX.TabIndex = 1;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(204, 27);
            this.lbX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(18, 18);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "x";
            // 
            // lbExtend
            // 
            this.lbExtend.AutoSize = true;
            this.lbExtend.Location = new System.Drawing.Point(10, 32);
            this.lbExtend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExtend.Name = "lbExtend";
            this.lbExtend.Size = new System.Drawing.Size(80, 18);
            this.lbExtend.TabIndex = 0;
            this.lbExtend.Text = "확장영역";
            // 
            // txtMatchCount
            // 
            this.txtMatchCount.Location = new System.Drawing.Point(124, 101);
            this.txtMatchCount.Name = "txtMatchCount";
            this.txtMatchCount.Size = new System.Drawing.Size(176, 28);
            this.txtMatchCount.TabIndex = 1;
            // 
            // MatchInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMatch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchInspProp";
            this.Size = new System.Drawing.Size(427, 404);
            this.grpMatch.ResumeLayout(false);
            this.grpMatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMatch;
        private System.Windows.Forms.TextBox txtExtendY;
        private System.Windows.Forms.TextBox txtExtendX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbExtend;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.TextBox txtMatchCount;
    }
}
