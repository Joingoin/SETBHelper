namespace SETBHelper
{
    partial class CombatModuleDiag
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
            this.KillsTbx = new System.Windows.Forms.TextBox();
            this.KillsLbl = new System.Windows.Forms.Label();
            this.DeathsTbx = new System.Windows.Forms.TextBox();
            this.DeathsLbl = new System.Windows.Forms.Label();
            this.SetScoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttendeeLbl
            // 
            this.AttendeeLbl.AutoSize = true;
            this.AttendeeLbl.Location = new System.Drawing.Point(9, 6);
            this.AttendeeLbl.Name = "AttendeeLbl";
            this.AttendeeLbl.Size = new System.Drawing.Size(53, 13);
            this.AttendeeLbl.TabIndex = 23;
            this.AttendeeLbl.Text = "Attendee:";
            // 
            // AttendeeCmbx
            // 
            this.AttendeeCmbx.FormattingEnabled = true;
            this.AttendeeCmbx.Location = new System.Drawing.Point(12, 22);
            this.AttendeeCmbx.Name = "AttendeeCmbx";
            this.AttendeeCmbx.Size = new System.Drawing.Size(190, 21);
            this.AttendeeCmbx.TabIndex = 22;
            this.AttendeeCmbx.SelectedIndexChanged += new System.EventHandler(this.AttendeeCmbx_SelectedIndexChanged);
            // 
            // KillsTbx
            // 
            this.KillsTbx.Location = new System.Drawing.Point(12, 63);
            this.KillsTbx.Name = "KillsTbx";
            this.KillsTbx.Size = new System.Drawing.Size(190, 20);
            this.KillsTbx.TabIndex = 25;
            // 
            // KillsLbl
            // 
            this.KillsLbl.AutoSize = true;
            this.KillsLbl.Location = new System.Drawing.Point(9, 46);
            this.KillsLbl.Name = "KillsLbl";
            this.KillsLbl.Size = new System.Drawing.Size(28, 13);
            this.KillsLbl.TabIndex = 24;
            this.KillsLbl.Text = "Kills:";
            // 
            // DeathsTbx
            // 
            this.DeathsTbx.Location = new System.Drawing.Point(12, 103);
            this.DeathsTbx.Name = "DeathsTbx";
            this.DeathsTbx.Size = new System.Drawing.Size(190, 20);
            this.DeathsTbx.TabIndex = 27;
            // 
            // DeathsLbl
            // 
            this.DeathsLbl.AutoSize = true;
            this.DeathsLbl.Location = new System.Drawing.Point(9, 86);
            this.DeathsLbl.Name = "DeathsLbl";
            this.DeathsLbl.Size = new System.Drawing.Size(44, 13);
            this.DeathsLbl.TabIndex = 26;
            this.DeathsLbl.Text = "Deaths:";
            // 
            // SetScoreBtn
            // 
            this.SetScoreBtn.Location = new System.Drawing.Point(12, 129);
            this.SetScoreBtn.Name = "SetScoreBtn";
            this.SetScoreBtn.Size = new System.Drawing.Size(190, 23);
            this.SetScoreBtn.TabIndex = 28;
            this.SetScoreBtn.Text = "Set Score";
            this.SetScoreBtn.UseVisualStyleBackColor = true;
            this.SetScoreBtn.Click += new System.EventHandler(this.SetScoreBtn_Click);
            // 
            // CombatModuleDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 168);
            this.Controls.Add(this.SetScoreBtn);
            this.Controls.Add(this.DeathsTbx);
            this.Controls.Add(this.DeathsLbl);
            this.Controls.Add(this.KillsTbx);
            this.Controls.Add(this.KillsLbl);
            this.Controls.Add(this.AttendeeLbl);
            this.Controls.Add(this.AttendeeCmbx);
            this.Name = "CombatModuleDiag";
            this.Text = "CombatModuleDiag";
            this.Load += new System.EventHandler(this.CombatModuleDiag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttendeeLbl;
        private System.Windows.Forms.ComboBox AttendeeCmbx;
        private System.Windows.Forms.TextBox KillsTbx;
        private System.Windows.Forms.Label KillsLbl;
        private System.Windows.Forms.TextBox DeathsTbx;
        private System.Windows.Forms.Label DeathsLbl;
        private System.Windows.Forms.Button SetScoreBtn;
    }
}