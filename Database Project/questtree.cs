using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class questtree : Form
    {
        Databasecontroller databasecontrol = new Databasecontroller();

        public questtree()
        {
            InitializeComponent();
            AllQuestsPanel.Visible = true;
            TherapistPanel.Visible = true;
            unavailablepanel.Visible = false;

            databasecontrol.SelectTrader();
            tradercb.DataSource = databasecontrol.dt;
            tradercb.DisplayMember = "quest_giver_name";

            DataRowView oDataRowView = tradercb.SelectedItem as DataRowView;
            string sValue = "";
            sValue = oDataRowView.Row[tradercb.DisplayMember] as string;
            questgiverdb.Text = sValue;
            questdescdb.Text = "";



            currentquestcb.Enabled = true;
            currentquestcb.DataSource = null;
            currentquestcb.Items.Clear();

            databasecontrol.SelectQuestTree(sValue);
            currentquestcb.DataSource = databasecontrol.dt;
            currentquestcb.DisplayMember = "quest_name";

            DataRowView oDataRowView2 = currentquestcb.SelectedItem as DataRowView;
            string sValue2 = "";
            sValue2 = oDataRowView2.Row[currentquestcb.DisplayMember] as string;
            questnamedb.Text = sValue2;

            databasecontrol.QuestDescription(sValue2);
            DataRow row = databasecontrol.dt.Rows[0];
            questdescdb.Text = row["quest_descriptions"].ToString();

            TherapistPanel.Visible = true;

            Shortagelbl.Tag = 1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView oDataRowView = currentquestcb.SelectedItem as DataRowView;
                string sValue = " ";
                sValue = oDataRowView.Row[currentquestcb.DisplayMember] as string;
                questnamedb.Text = sValue;

                databasecontrol.QuestDescription(sValue);
                DataRow row = databasecontrol.dt.Rows[0];
                questdescdb.Text = row["quest_descriptions"].ToString();

                databasecontrol.QuestNum(sValue);
                DataRow row2 = databasecontrol.dt.Rows[0];
                var quest_num = Int32.Parse(row2["quest_num"].ToString());

                var labels = TherapistPanel.Controls.OfType<Label>().Where(label => Convert.ToInt32(label.Tag) < quest_num);

                foreach (var label in labels)
                {
                    label.BackColor = Color.Gold;
                }

                var labels2 = TherapistPanel.Controls.OfType<Label>().Where(label => Convert.ToInt32(label.Tag) >= quest_num);

                foreach (var label2 in labels2)
                {
                    label2.BackColor = Color.PaleVioletRed;
                }

            }
            catch
            {

            }

        }

        private void skilltree_Load(object sender, EventArgs e)
        {

        }

        private void selecttraderbtn_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = tradercb.SelectedItem as DataRowView;
            string sValue = "";
            sValue = oDataRowView.Row[tradercb.DisplayMember] as string;
            
            currentquestcb.Enabled = true;
            currentquestcb.DataSource = null;
            currentquestcb.Items.Clear();


            if (sValue == "Therapist")
            {
                TherapistPanel.Visible = true;
            }
            databasecontrol.SelectQuestTree(sValue);
            currentquestcb.DataSource = databasecontrol.dt;
            currentquestcb.DisplayMember = "quest_name";
        }

        private void submuittreebtn_Click(object sender, EventArgs e)
        {
            AllQuestsPanel.Visible = true;
            TherapistPanel.Visible = false;
            unavailablepanel.Visible = false;
        }

        private void tradercb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView oDataRowView = tradercb.SelectedItem as DataRowView;
            string sValue = "";
            try
            {
                AllQuestsPanel.Visible = false;
                currentquestcb.Enabled = true;
                currentquestcb.DataSource = null;
                currentquestcb.Items.Clear();

                sValue = oDataRowView.Row[tradercb.DisplayMember] as string;

                if (sValue == "Therapist")
                {
                    TherapistPanel.Visible = true;
                    unavailablepanel.Visible = false;
                }
                else if (sValue == "ttt")
                {

                }
                else
                {
                    unavailablepanel.Visible = true;
                }

                databasecontrol.SelectQuestTree(sValue);
                currentquestcb.DataSource = databasecontrol.dt;
                currentquestcb.DisplayMember = "quest_name";

                questgiverdb.Text = sValue;
                DataRowView oDataRowView2 = currentquestcb.SelectedItem as DataRowView;
                string sValue2 = " ";
                try
                {
                    sValue2 = oDataRowView2.Row[currentquestcb.DisplayMember] as string;
                    questnamedb.Text = sValue2;
                }
                catch
                {
                    questnamedb.Text = "  ";
                    questdescdb.Text = "  ";
                }

            }
            catch
            {

            }
        }

        private void TherapistPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void updatequestbtn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
