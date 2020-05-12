using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{

    

    public partial class login : Form
    {
      Databasecontroller databasecontrol = new Databasecontroller();




        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string table = "users";
            string value1 = "user_level";
            mainform f2 = new mainform();
            try
            {
              int userid = databasecontrol.GetUserID(txt_username.Text);
                //if the userid already exists in the database, check and update the users level
                if (userid != 0)
                {
                    databasecontrol.UpdateLevel(table, value1, txt_level.Text, userid);
                    //advance to next form
                    this.Hide();
                    f2.Show();
                    
                }
                //If the user is not in the database, add them to the database.
                else if (userid == 0)
                {
                    //Add user to database
                    databasecontrol.AddUser(txt_username.Text, txt_level.Text);
                    //advance to the next form
                    this.Hide();
                    f2.Show();
                }

            }
            catch
            {

            }
            
        }
    }
}
