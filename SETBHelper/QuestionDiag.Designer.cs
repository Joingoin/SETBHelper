namespace SETBHelper
{
    partial class QuestionDiag
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
            this.AttendeeLbl = new System.Windows.Forms.Label();
            this.AttendeeCmbx = new System.Windows.Forms.ComboBox();
            this.questionsDgv = new System.Windows.Forms.DataGridView();
            this.SetScoreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendeeLbl
            // 
            this.AttendeeLbl.AutoSize = true;
            this.AttendeeLbl.Location = new System.Drawing.Point(9, 8);
            this.AttendeeLbl.Name = "AttendeeLbl";
            this.AttendeeLbl.Size = new System.Drawing.Size(53, 13);
            this.AttendeeLbl.TabIndex = 27;
            this.AttendeeLbl.Text = "Attendee:";
            // 
            // AttendeeCmbx
            // 
            this.AttendeeCmbx.FormattingEnabled = true;
            this.AttendeeCmbx.Location = new System.Drawing.Point(12, 24);
            this.AttendeeCmbx.Name = "AttendeeCmbx";
            this.AttendeeCmbx.Size = new System.Drawing.Size(190, 21);
            this.AttendeeCmbx.TabIndex = 26;
            this.AttendeeCmbx.SelectedIndexChanged += new System.EventHandler(this.AttendeeCmbx_SelectedIndexChanged);
            // 
            // questionsDgv
            // 
            this.questionsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDgv.Location = new System.Drawing.Point(12, 51);
            this.questionsDgv.Name = "questionsDgv";
            this.questionsDgv.Size = new System.Drawing.Size(776, 387);
            this.questionsDgv.TabIndex = 28;
            // 
            // SetScoreBtn
            // 
            this.SetScoreBtn.Location = new System.Drawing.Point(208, 22);
            this.SetScoreBtn.Name = "SetScoreBtn";
            this.SetScoreBtn.Size = new System.Drawing.Size(190, 23);
            this.SetScoreBtn.TabIndex = 29;
            this.SetScoreBtn.Text = "Set Score";
            this.SetScoreBtn.UseVisualStyleBackColor = true;
            this.SetScoreBtn.Click += new System.EventHandler(this.SetScoreBtn_Click);
            // 
            // QuestionDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetScoreBtn);
            this.Controls.Add(this.questionsDgv);
            this.Controls.Add(this.AttendeeLbl);
            this.Controls.Add(this.AttendeeCmbx);
            this.Name = "QuestionDiag";
            this.Text = "QuestionDiag";
            this.Load += new System.EventHandler(this.QuestionDiag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttendeeLbl;
        private System.Windows.Forms.ComboBox AttendeeCmbx;
        private System.Windows.Forms.DataGridView questionsDgv;
        private System.Windows.Forms.Button SetScoreBtn;
    }
}