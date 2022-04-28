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
    public partial class CombatModuleDiag : Form
    {

        public CombatModule module = null;

        public CombatModuleDiag()
        {
            InitializeComponent();
        }

        private void CombatModuleDiag_Load(object sender, EventArgs e)
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

        private void SetScoreBtn_Click(object sender, EventArgs e)
        {
            module.CmbtResults.Add(new CombatResult(AttendeeCmbx.SelectedIndex,Convert.ToInt32(KillsTbx.Text), Convert.ToInt32(DeathsTbx.Text)));
        }

        private void AttendeeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            KillsTbx.Text = "";
            DeathsTbx.Text = "";

            try
            {
                KillsTbx.Text = module.CmbtResults[AttendeeCmbx.SelectedIndex].Kills.ToString();
                DeathsTbx.Text = module.CmbtResults[AttendeeCmbx.SelectedIndex].Deaths.ToString();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
