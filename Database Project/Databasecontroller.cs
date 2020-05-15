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
        public DataTable dt;
        private NpgsqlCommand cmd;
        public NpgsqlConnection conn = new NpgsqlConnection(constring);

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
        public void SelectQuests(string trader)
        {
            try
            {
                conn.Open();
                if (trader == "*")
                {
                    query = "SELECT * from Thicc_quest_info";
                }
                else
                {
                    query = "SELECT * from  Thicc_quest_info  WHERE quest_giver_name = '" + trader + "';";
                }
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
        public void SelectItems(string trader)
        {
            try
            {
                conn.Open();
                if (trader == "*")
                {
                    query = "SELECT item_name,item_quantity from item_quests;";
                }
                else
                {
                    query = "SELECT item_name,item_quantity from item_quests WHERE quest_giver_name = '" + trader + "';";
                }
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
        public void ViewSpecQuest(string trader,string table)
        {
            try
            {
                conn.Open();
                if (trader == "*")
                {
                    query = "SELECT * from " + table + ";";
                }
                else
                {
                    query = "SELECT * from " + table + " WHERE quest_giver_name = '" + trader + "';";
                }
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

        public void SelectTrader()
        {
            try
            {
                conn.Open();
                query = "SELECT quest_giver_name from quest_giver";            
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
        
        public void RemoveUser(string username)
        {
            try
            {
                conn.Open();
                query = "DELETE FROM users where username = '" + username + "';";
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
                
        public void SelectQuestTree(string selectedtrader)
        {
            
            try
            {
                conn.Open();

                query = "SELECT quest_name from thicc_quest_info WHERE thicc_quest_info.quest_giver_name = '" + selectedtrader + "';";
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

        public void QuestDescription(string questname)
        {

            try
            {
                conn.Open();

                query = "SELECT quest_descriptions from thicc_quest_info WHERE thicc_quest_info.quest_name = '" + questname + "';";
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

        public void QuestNum(string questname)
        {

            try
            {
                conn.Open();

                query = "SELECT quest_num from thicc_quest_info WHERE thicc_quest_info.quest_name = '" + questname + "';";
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
