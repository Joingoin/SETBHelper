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
    public partial class SimulationModuleDiag : Form
    {

        public SimulationModule module = null;
        bool doNotFireEvent = false;

        public SimulationModuleDiag()
        {
            InitializeComponent();
        }

        private void SimulationModuleDiag_Load(object sender, EventArgs e)
        {
            UpdateAttendees();
        }

        public void UpdateAttendees()
        {
            AttendeeCmbx.SelectedIndex = -1;
            AttendeeCmbx.Items.Clear();
            foreach (Attandee at in module.Attandees)
            {
                AttendeeCmbx.Items.Add(at.Name);
            }
        }

        private void passedChbx_CheckedChanged(object sender, EventArgs e)
        {
            if(!doNotFireEvent)
            module.TogglePassed(AttendeeCmbx.SelectedIndex);
        }

        private void AttendeeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (module.PassedAttendees.Contains(AttendeeCmbx.SelectedIndex))
            {
                doNotFireEvent = true;
                passedChbx.Checked = true;
                doNotFireEvent = false;
            }
            else
            {
                doNotFireEvent = true;
                passedChbx.Checked = false;
                doNotFireEvent = false;
            }
        }
    }
}
