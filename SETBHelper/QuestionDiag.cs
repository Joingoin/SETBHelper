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
            DataTable dt = new DataTable();
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Correct?", typeof(bool));

            foreach(string s in dataFriendlyQuestions)
            {
                dt.Rows.Add(s, false);
            }

            dt.Columns[0].ReadOnly = true;
            questionsDgv.DataSource = dt;

        }
    }
}
