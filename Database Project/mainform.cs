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
    }
}
