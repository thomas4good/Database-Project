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
    public partial class mainform : Form
    {
        Databasecontroller databasecontrol = new Databasecontroller();
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            databasecontrol.SelectTrader();
            cbx_trader.DataSource = databasecontrol.dt;
            cbx_trader.DisplayMember = "quest_giver_name";
            lbl_dip.Visible = false;
        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            if (cbx_trader.Text == "")
            {
                databasecontrol.SelectItems("*");
            }
            else
            {
                databasecontrol.SelectItems(cbx_trader.Text);
            }
            LoadGrid();
            lbl_info.Text = "This is a list of all the required Items for: " + cbx_trader.Text;
        }

        private void LoadGrid()
        {
            dgv_main.DataSource = databasecontrol.dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbx_trader.Text == "")
            {
                databasecontrol.SelectQuests("*");
            }
            else
            {
              databasecontrol.SelectQuests(cbx_trader.Text);
            }
            LoadGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            questtree f3 = new questtree();
            f3.Show();
        }

        private void btn_kills_Click(object sender, EventArgs e)
        {
            if (cbx_trader.Text == "")
            {
                databasecontrol.ViewSpecQuest("*","kill_quests");
            }
            else
            {
                databasecontrol.ViewSpecQuest(cbx_trader.Text, "kill_quests");
            }
            LoadGrid();
            lbl_info.Text = "This is a list of quests that require kills for: " + cbx_trader.Text;
        }

        private void btn_skills_Click(object sender, EventArgs e)
        {
            {
                if (cbx_trader.Text == "")
                {
                    databasecontrol.ViewSpecQuest("*", "skill_quests");
                }
                else
                {
                    databasecontrol.ViewSpecQuest(cbx_trader.Text, "skill_quests");
                }
                LoadGrid();
                lbl_info.Text = "This is a list of quests that require skills for: " + cbx_trader.Text;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            login f2 = new login();
            this.Hide();
            f2.Show();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            
            lbl_dip.Visible = true;
            LoadGrid();
        }
    }
}
