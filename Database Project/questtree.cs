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
            tradercb.SelectedIndex = 0;
        }

        private void selecttraderbtn_Click(object sender, EventArgs e)
        {
            currentquestcb.Enabled = true;
            currentquestcb.Items.Clear();
            if (tradercb.SelectedItem == "Therapist")
            {
                currentquestcb.Items.AddRange(new string[] { "Shortage","Sanitary Standards - Part 1", "Sanitary Standards - Part 2", "Operation Aquarius - Part 1",
                    "Operation Aquarius - Part 2", "Painkiller", "Pharmacist", "Supply plans", "General wares", "Car Repair", "Hippocratic Vow", "Health Care Privacy - Part 1",
                    "Health Care Privacy - Part 2", "Health Care Privacy - Part 3", "Health Care Privacy - Part 4", "Athlete", "Health Care Privacy - Part 5 ", "Private Clinic"});
            }
            else if (tradercb.SelectedItem == "All")
            {
                currentquestcb.Items.AddRange(new string[] { "Shortage","Sanitary Standards - Part 1", "Sanitary Standards - Part 2", "Operation Aquarius - Part 1",
                    "Operation Aquarius - Part 2", "Painkiller", "Pharmacist", "Supply plans", "General wares", "Car Repair", "Hippocratic Vow", "Health Care Privacy - Part 1",
                    "Health Care Privacy - Part 2", "Health Care Privacy - Part 3", "Health Care Privacy - Part 4", "Athlete", "Health Care Privacy - Part 5 ", "Private Clinic"});
            }
        }

        private void submuittreebtn_Click(object sender, EventArgs e)
        {

        }

        private void tradercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
