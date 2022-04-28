namespace SETBHelper
{
    partial class mainFrm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModuleCmbx = new System.Windows.Forms.ComboBox();
            this.ModuleBoxLbl = new System.Windows.Forms.Label();
            this.SelectionLbl = new System.Windows.Forms.Label();
            this.setResBtn = new System.Windows.Forms.Button();
            this.TrainingSetupLbl = new System.Windows.Forms.Label();
            this.ModuleNameLbl = new System.Windows.Forms.Label();
            this.ModuleNameTbx = new System.Windows.Forms.TextBox();
            this.AddModuleBtn = new System.Windows.Forms.Button();
            this.TypeOfModuleLbl = new System.Windows.Forms.Label();
            this.TypeOfModuleCmbx = new System.Windows.Forms.ComboBox();
            this.RemoveModuleBtn = new System.Windows.Forms.Button();
            this.ResultsLbl = new System.Windows.Forms.Label();
            this.ResultsRTbx = new System.Windows.Forms.RichTextBox();
            this.RemoveAttendeeBtn = new System.Windows.Forms.Button();
            this.AddAttendeeBtn = new System.Windows.Forms.Button();
            this.AttendeeNameTbx = new System.Windows.Forms.TextBox();
            this.AttendeeNameLbl = new System.Windows.Forms.Label();
            this.AttendeeLbl = new System.Windows.Forms.Label();
            this.AttendeeCmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModuleCmbx
            // 
            this.ModuleCmbx.FormattingEnabled = true;
            this.ModuleCmbx.Location = new System.Drawing.Point(15, 61);
            this.ModuleCmbx.Name = "ModuleCmbx";
            this.ModuleCmbx.Size = new System.Drawing.Size(121, 21);
            this.ModuleCmbx.TabIndex = 0;
            // 
            // ModuleBoxLbl
            // 
            this.ModuleBoxLbl.AutoSize = true;
            this.ModuleBoxLbl.Location = new System.Drawing.Point(12, 45);
            this.ModuleBoxLbl.Name = "ModuleBoxLbl";
            this.ModuleBoxLbl.Size = new System.Drawing.Size(45, 13);
            this.ModuleBoxLbl.TabIndex = 1;
            this.ModuleBoxLbl.Text = "Module:";
            // 
            // SelectionLbl
            // 
            this.SelectionLbl.AutoSize = true;
            this.SelectionLbl.Location = new System.Drawing.Point(12, 9);
            this.SelectionLbl.Name = "SelectionLbl";
            this.SelectionLbl.Size = new System.Drawing.Size(193, 39);
            this.SelectionLbl.TabIndex = 2;
            this.SelectionLbl.Text = "Results:\r\n_______________________________\r\n\r\n";
            // 
            // setResBtn
            // 
            this.setResBtn.Location = new System.Drawing.Point(15, 88);
            this.setResBtn.Name = "setResBtn";
            this.setResBtn.Size = new System.Drawing.Size(75, 23);
            this.setResBtn.TabIndex = 3;
            this.setResBtn.Text = "Set Results";
            this.setResBtn.UseVisualStyleBackColor = true;
            this.setResBtn.Click += new System.EventHandler(this.setResBtn_Click);
            // 
            // TrainingSetupLbl
            // 
            this.TrainingSetupLbl.AutoSize = true;
            this.TrainingSetupLbl.Location = new System.Drawing.Point(211, 9);
            this.TrainingSetupLbl.Name = "TrainingSetupLbl";
            this.TrainingSetupLbl.Size = new System.Drawing.Size(193, 39);
            this.TrainingSetupLbl.TabIndex = 4;
            this.TrainingSetupLbl.Text = "Training Setup:\r\n_______________________________\r\n\r\n";
            // 
            // ModuleNameLbl
            // 
            this.ModuleNameLbl.AutoSize = true;
            this.ModuleNameLbl.Location = new System.Drawing.Point(211, 45);
            this.ModuleNameLbl.Name = "ModuleNameLbl";
            this.ModuleNameLbl.Size = new System.Drawing.Size(38, 13);
            this.ModuleNameLbl.TabIndex = 5;
            this.ModuleNameLbl.Text = "Name:";
            // 
            // ModuleNameTbx
            // 
            this.ModuleNameTbx.Location = new System.Drawing.Point(214, 62);
            this.ModuleNameTbx.Name = "ModuleNameTbx";
            this.ModuleNameTbx.Size = new System.Drawing.Size(190, 20);
            this.ModuleNameTbx.TabIndex = 6;
            // 
            // AddModuleBtn
            // 
            this.AddModuleBtn.Location = new System.Drawing.Point(214, 131);
            this.AddModuleBtn.Name = "AddModuleBtn";
            this.AddModuleBtn.Size = new System.Drawing.Size(190, 23);
            this.AddModuleBtn.TabIndex = 7;
            this.AddModuleBtn.Text = "Add Module";
            this.AddModuleBtn.UseVisualStyleBackColor = true;
            this.AddModuleBtn.Click += new System.EventHandler(this.AddModuleBtn_Click);
            // 
            // TypeOfModuleLbl
            // 
            this.TypeOfModuleLbl.AutoSize = true;
            this.TypeOfModuleLbl.Location = new System.Drawing.Point(211, 88);
            this.TypeOfModuleLbl.Name = "TypeOfModuleLbl";
            this.TypeOfModuleLbl.Size = new System.Drawing.Size(84, 13);
            this.TypeOfModuleLbl.TabIndex = 8;
            this.TypeOfModuleLbl.Text = "Type of Module:";
            // 
            // TypeOfModuleCmbx
            // 
            this.TypeOfModuleCmbx.FormattingEnabled = true;
            this.TypeOfModuleCmbx.Location = new System.Drawing.Point(214, 104);
            this.TypeOfModuleCmbx.Name = "TypeOfModuleCmbx";
            this.TypeOfModuleCmbx.Size = new System.Drawing.Size(190, 21);
            this.TypeOfModuleCmbx.TabIndex = 9;
            // 
            // RemoveModuleBtn
            // 
            this.RemoveModuleBtn.Location = new System.Drawing.Point(214, 160);
            this.RemoveModuleBtn.Name = "RemoveModuleBtn";
            this.RemoveModuleBtn.Size = new System.Drawing.Size(190, 23);
            this.RemoveModuleBtn.TabIndex = 10;
            this.RemoveModuleBtn.Text = "Remove Module (Select at left)";
            this.RemoveModuleBtn.UseVisualStyleBackColor = true;
            this.RemoveModuleBtn.Click += new System.EventHandler(this.RemoveModuleBtn_Click);
            // 
            // ResultsLbl
            // 
            this.ResultsLbl.AutoSize = true;
            this.ResultsLbl.Location = new System.Drawing.Point(410, 9);
            this.ResultsLbl.Name = "ResultsLbl";
            this.ResultsLbl.Size = new System.Drawing.Size(193, 39);
            this.ResultsLbl.TabIndex = 11;
            this.ResultsLbl.Text = "Results:\r\n_______________________________\r\n\r\n";
            // 
            // ResultsRTbx
            // 
            this.ResultsRTbx.Location = new System.Drawing.Point(413, 42);
            this.ResultsRTbx.Name = "ResultsRTbx";
            this.ResultsRTbx.ReadOnly = true;
            this.ResultsRTbx.Size = new System.Drawing.Size(190, 267);
            this.ResultsRTbx.TabIndex = 12;
            this.ResultsRTbx.Text = "";
            // 
            // RemoveAttendeeBtn
            // 
            this.RemoveAttendeeBtn.Location = new System.Drawing.Point(214, 259);
            this.RemoveAttendeeBtn.Name = "RemoveAttendeeBtn";
            this.RemoveAttendeeBtn.Size = new System.Drawing.Size(190, 23);
            this.RemoveAttendeeBtn.TabIndex = 18;
            this.RemoveAttendeeBtn.Text = "Remove Attendee (Select at left)";
            this.RemoveAttendeeBtn.UseVisualStyleBackColor = true;
            this.RemoveAttendeeBtn.Click += new System.EventHandler(this.RemoveAttendeeBtn_Click);
            // 
            // AddAttendeeBtn
            // 
            this.AddAttendeeBtn.Location = new System.Drawing.Point(214, 230);
            this.AddAttendeeBtn.Name = "AddAttendeeBtn";
            this.AddAttendeeBtn.Size = new System.Drawing.Size(190, 23);
            this.AddAttendeeBtn.TabIndex = 15;
            this.AddAttendeeBtn.Text = "Add Attendee";
            this.AddAttendeeBtn.UseVisualStyleBackColor = true;
            this.AddAttendeeBtn.Click += new System.EventHandler(this.AddAttendeeBtn_Click);
            // 
            // AttendeeNameTbx
            // 
            this.AttendeeNameTbx.Location = new System.Drawing.Point(214, 204);
            this.AttendeeNameTbx.Name = "AttendeeNameTbx";
            this.AttendeeNameTbx.Size = new System.Drawing.Size(190, 20);
            this.AttendeeNameTbx.TabIndex = 14;
            // 
            // AttendeeNameLbl
            // 
            this.AttendeeNameLbl.AutoSize = true;
            this.AttendeeNameLbl.Location = new System.Drawing.Point(211, 187);
            this.AttendeeNameLbl.Name = "AttendeeNameLbl";
            this.AttendeeNameLbl.Size = new System.Drawing.Size(38, 13);
            this.AttendeeNameLbl.TabIndex = 13;
            this.AttendeeNameLbl.Text = "Name:";
            // 
            // AttendeeLbl
            // 
            this.AttendeeLbl.AutoSize = true;
            this.AttendeeLbl.Location = new System.Drawing.Point(12, 144);
            this.AttendeeLbl.Name = "AttendeeLbl";
            this.AttendeeLbl.Size = new System.Drawing.Size(53, 13);
            this.AttendeeLbl.TabIndex = 21;
            this.AttendeeLbl.Text = "Attendee:";
            // 
            // AttendeeCmbx
            // 
            this.AttendeeCmbx.FormattingEnabled = true;
            this.AttendeeCmbx.Location = new System.Drawing.Point(15, 160);
            this.AttendeeCmbx.Name = "AttendeeCmbx";
            this.AttendeeCmbx.Size = new System.Drawing.Size(121, 21);
            this.AttendeeCmbx.TabIndex = 20;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 317);
            this.Controls.Add(this.AttendeeLbl);
            this.Controls.Add(this.AttendeeCmbx);
            this.Controls.Add(this.RemoveAttendeeBtn);
            this.Controls.Add(this.AddAttendeeBtn);
            this.Controls.Add(this.AttendeeNameTbx);
            this.Controls.Add(this.AttendeeNameLbl);
            this.Controls.Add(this.ResultsRTbx);
            this.Controls.Add(this.ResultsLbl);
            this.Controls.Add(this.RemoveModuleBtn);
            this.Controls.Add(this.TypeOfModuleCmbx);
            this.Controls.Add(this.TypeOfModuleLbl);
            this.Controls.Add(this.AddModuleBtn);
            this.Controls.Add(this.ModuleNameTbx);
            this.Controls.Add(this.ModuleNameLbl);
            this.Controls.Add(this.TrainingSetupLbl);
            this.Controls.Add(this.setResBtn);
            this.Controls.Add(this.SelectionLbl);
            this.Controls.Add(this.ModuleBoxLbl);
            this.Controls.Add(this.ModuleCmbx);
            this.Name = "mainFrm";
            this.Text = "SETB-Helper";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModuleCmbx;
        private System.Windows.Forms.Label ModuleBoxLbl;
        private System.Windows.Forms.Label SelectionLbl;
        private System.Windows.Forms.Button setResBtn;
        private System.Windows.Forms.Label TrainingSetupLbl;
        private System.Windows.Forms.Label ModuleNameLbl;
        private System.Windows.Forms.TextBox ModuleNameTbx;
        private System.Windows.Forms.Button AddModuleBtn;
        private System.Windows.Forms.Label TypeOfModuleLbl;
        private System.Windows.Forms.ComboBox TypeOfModuleCmbx;
        private System.Windows.Forms.Button RemoveModuleBtn;
        private System.Windows.Forms.Label ResultsLbl;
        private System.Windows.Forms.RichTextBox ResultsRTbx;
        private System.Windows.Forms.Button RemoveAttendeeBtn;
        private System.Windows.Forms.Button AddAttendeeBtn;
        private System.Windows.Forms.TextBox AttendeeNameTbx;
        private System.Windows.Forms.Label AttendeeNameLbl;
        private System.Windows.Forms.Label AttendeeLbl;
        private System.Windows.Forms.ComboBox AttendeeCmbx;
    }
}

