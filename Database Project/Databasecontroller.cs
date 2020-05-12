using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    class Databasecontroller
    {
        static string constring = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        private string query = "";
        private DataTable dt;
        private NpgsqlCommand cmd;
        public NpgsqlConnection conn = new NpgsqlConnection(constring);
        private DataAdapter da;

        public int GetUserID(String username){
             int id = 0;
            int recordcount = 0;
            try
            {
                conn.Open();
                query = "SELECT id from users WHERE username = '"+ username + "';";
                cmd = new NpgsqlCommand(query, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                recordcount = dt.Rows.Count;
                if (recordcount > 0)
                {
                    id = (int)(dt.Rows[0][0]);
                    return id;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                
            }
            return 0;
        }
      public void UpdateLevel(string table,string value1, string newlevel,int id){
            try
            {
                conn.Open();
                query = "UPDATE " + table + " SET " + value1 + " = '" + newlevel + "' WHERE id = '" + id + "';";
                cmd = new NpgsqlCommand(query, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            conn.Close();
            }
        }
    public void AddUser(String username, string level){
            try
            {
                conn.Open();
                query ="INSERT INTO users (username,user_level) VALUES ('"+ username +"','"+level+"');";
                cmd = new NpgsqlCommand(query, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
