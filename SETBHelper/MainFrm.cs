using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETBHelper
{
    public partial class mainFrm : Form
    {

        Training training = new Training("PLACEHOLDER");

        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            UpdateActiveModules();

            //Give all Modules as Selection

            //Combat
            TypeOfModuleCmbx.Items.Add("Combat");
            //Simulation
            TypeOfModuleCmbx.Items.Add("Simulation");
            //Recontainment
            TypeOfModuleCmbx.Items.Add("Recontainment");
            //Question
            TypeOfModuleCmbx.Items.Add("Question");

        }


        public void UpdateActiveModules()
        {
            ModuleCmbx.SelectedIndex = -1;
            ModuleCmbx.Items.Clear();

            foreach(TrainingModule tm in training.TModules)
            {
                ModuleCmbx.Items.Add(tm.Name);
            }
        }

        public void UpdateAttendees()
        {
            AttendeeCmbx.SelectedIndex = -1;
            AttendeeCmbx.Items.Clear();
            foreach (Attandee at in training.Attandees)
            {
                AttendeeCmbx.Items.Add(at.Name);
            }
        }


        private void AddModuleBtn_Click(object sender, EventArgs e)
        {
            if(ModuleNameTbx.Text != null && ModuleNameTbx.Text.Trim() != "" && TypeOfModuleCmbx.SelectedIndex > -1)
            switch(TypeOfModuleCmbx.SelectedItem.ToString())
            {

                case "Combat":
                    CombatModule Cmodule = new CombatModule(ModuleNameTbx.Text,training.Attandees);
                    training.AddModule(Cmodule);
                    break;
                case "Simulation":
                    SimulationModule Smodule = new SimulationModule(ModuleNameTbx.Text, training.Attandees);
                    training.AddModule(Smodule);
                    break;
                case "Recontainment":
                    RecontainmentModule Rmodule = new RecontainmentModule(ModuleNameTbx.Text, training.Attandees);
                    training.AddModule(Rmodule);
                    break;
                case "Question":
                    QuestionModule Qmodule = new QuestionModule(ModuleNameTbx.Text, training.Attandees);
                    training.AddModule(Qmodule);
                    break;
                default:
                    CombatModule Dmodule = new CombatModule(ModuleNameTbx.Text, training.Attandees);
                    training.AddModule(Dmodule);
                    break;
            }

            UpdateActiveModules();


        }

        private void RemoveModuleBtn_Click(object sender, EventArgs e)
        {
            if (ModuleCmbx.SelectedIndex >= 0)
            {
                training.RemoveModule(training.TModules[ModuleCmbx.SelectedIndex]);
                UpdateActiveModules();
            }
        }

        private void AddAttendeeBtn_Click(object sender, EventArgs e)
        {
            training.AddAttendee(AttendeeNameTbx.Text);
            UpdateAttendees();
        }

        private void RemoveAttendeeBtn_Click(object sender, EventArgs e)
        {
            if(AttendeeCmbx.SelectedIndex >= 0)
            training.RemoveAttendee(training.Attandees[AttendeeCmbx.SelectedIndex]);
            UpdateAttendees();
        }

        private void setResBtn_Click(object sender, EventArgs e)
        {
            TrainingModule tm = training.TModules[ModuleCmbx.SelectedIndex];

                if(tm is CombatModule)
                {
                    CombatModuleDiag CmbtDiag = new CombatModuleDiag();
                    CmbtDiag.module = (CombatModule)tm;
                    CmbtDiag.ShowDialog();
                    ((CombatModule)tm).CalculateResults();
                    UpdateResults();
                }
                if (tm is SimulationModule)
                {
                    //No Automation possible
                    SimulationModuleDiag SimDiag = new SimulationModuleDiag();
                    SimDiag.module = (SimulationModule)tm;
                    SimDiag.ShowDialog();
                    UpdateResults();
                }
                if (tm is RecontainmentModule)
                {
                    //For now also a SimDiag as literally Hosts decides if they passed //No Automation possible
                    SimulationModuleDiag SimDiag = new SimulationModuleDiag();
                    SimDiag.module = (SimulationModule)tm;
                    SimDiag.ShowDialog();
                    UpdateResults();
                }
                if (tm is QuestionModule)
                {
                    QuestionDiag QueDiag = new QuestionDiag();
                    QueDiag.module = (QuestionModule)tm;
                    QueDiag.ShowDialog();
                    ((QuestionModule)tm).CalculateResults();
                    UpdateResults();

                }
            
        }

        public void UpdateResults()
        {
            ResultsRTbx.Text = "";
            ResultsRTbx.Text = training.GiveResults();
        }
    }
}
