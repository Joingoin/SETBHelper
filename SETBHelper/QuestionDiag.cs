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
    public partial class QuestionDiag : Form
    {

        public QuestionModule module = null;
        public List<string> dataFriendlyQuestions = null;

        DataTable dt = new DataTable();

        public QuestionDiag()
        {
            InitializeComponent();
        }

        private void QuestionDiag_Load(object sender, EventArgs e)
        {
            UpdateAttendees();
            string questions = module.GiveQuestions();
            dataFriendlyQuestions = questions.Replace("\n\n","").Split(new char[]{'?','.'}).ToList<string>();
            PopulateDataGridview();
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

        public void PopulateDataGridview()
        {
            
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Correct?", typeof(bool));

            foreach(string s in dataFriendlyQuestions)
            {
                dt.Rows.Add(s, false);
            }

            dt.Columns[0].ReadOnly = true;
            questionsDgv.DataSource = dt;

        }

        private void SetScoreBtn_Click(object sender, EventArgs e)
        {

            foreach(DataGridViewRow r in questionsDgv.Rows)
            {
                bool alrAdded = false;
                int indxOfFound = -1;

                foreach (QuestionResult res in module.correctQuestions)
                {
                    if (res.ATIndex == AttendeeCmbx.SelectedIndex && res.QuestionIndex == r.Index)
                    {
                        alrAdded = true;
                        indxOfFound = module.correctQuestions.IndexOf(res);
                    }
                }


                if (Convert.ToBoolean(r.Cells[1].Value) == true)
                {
                    if(!alrAdded)
                    {
                        module.correctQuestions.Add(new QuestionResult(AttendeeCmbx.SelectedIndex,r.Index));
                    }
                }
                else
                {
                    if(indxOfFound > -1)
                    module.correctQuestions.RemoveAt(indxOfFound);
                }
            }
        }

        private void AttendeeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in questionsDgv.Rows)
            {
                bool alrAdded = false;
                int indxOfFound = -1;


                foreach (QuestionResult res in module.correctQuestions)
                {
                    if (res.ATIndex == AttendeeCmbx.SelectedIndex && res.QuestionIndex == r.Index)
                    {
                        alrAdded = true;
                        indxOfFound = module.correctQuestions.IndexOf(res);
                        r.Cells[1].Value = true;
                    }
                }

                if (!alrAdded)
                {
                    r.Cells[1].Value = false;
                }

        }
        }
    }
}
