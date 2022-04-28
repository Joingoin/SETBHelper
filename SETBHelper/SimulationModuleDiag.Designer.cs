namespace SETBHelper
{
    partial class SimulationModuleDiag
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
            this.passedChbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AttendeeLbl
            // 
            this.AttendeeLbl.AutoSize = true;
            this.AttendeeLbl.Location = new System.Drawing.Point(9, 8);
            this.AttendeeLbl.Name = "AttendeeLbl";
            this.AttendeeLbl.Size = new System.Drawing.Size(53, 13);
            this.AttendeeLbl.TabIndex = 25;
            this.AttendeeLbl.Text = "Attendee:";
            // 
            // AttendeeCmbx
            // 
            this.AttendeeCmbx.FormattingEnabled = true;
            this.AttendeeCmbx.Location = new System.Drawing.Point(12, 24);
            this.AttendeeCmbx.Name = "AttendeeCmbx";
            this.AttendeeCmbx.Size = new System.Drawing.Size(190, 21);
            this.AttendeeCmbx.TabIndex = 24;
            this.AttendeeCmbx.SelectedIndexChanged += new System.EventHandler(this.AttendeeCmbx_SelectedIndexChanged);
            // 
            // passedChbx
            // 
            this.passedChbx.AutoSize = true;
            this.passedChbx.Location = new System.Drawing.Point(12, 51);
            this.passedChbx.Name = "passedChbx";
            this.passedChbx.Size = new System.Drawing.Size(61, 17);
            this.passedChbx.TabIndex = 26;
            this.passedChbx.Text = "Passed";
            this.passedChbx.UseVisualStyleBackColor = true;
            this.passedChbx.CheckedChanged += new System.EventHandler(this.passedChbx_CheckedChanged);
            // 
            // SimulationModuleDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 90);
            this.Controls.Add(this.passedChbx);
            this.Controls.Add(this.AttendeeLbl);
            this.Controls.Add(this.AttendeeCmbx);
            this.Name = "SimulationModuleDiag";
            this.Text = "SimulationModuleDiag";
            this.Load += new System.EventHandler(this.SimulationModuleDiag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttendeeLbl;
        private System.Windows.Forms.ComboBox AttendeeCmbx;
        private System.Windows.Forms.CheckBox passedChbx;
    }
}