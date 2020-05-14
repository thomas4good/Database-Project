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
            TherapistPanel.Visible = false;

            databasecontrol.SelectTrader();
            tradercb.DataSource = databasecontrol.dt;
            tradercb.DisplayMember = "quest_giver_name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        private void tradercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TherapistPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
