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
            skilltree f3 = new skilltree();
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
            }
        }
    }
}
