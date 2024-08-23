using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using BHL_COURIER_SERVICE.CustomControl;


namespace BHL_COURIER_SERVICE.Helpers
{
    class DbHelper
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        public DbHelper()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
            cmd = new OleDbCommand();
        }
        public bool connect()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool disconnect()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public string getButtons(string query, FlowLayoutPanel panel)
        {
            string ret = "";

            try
            {
                cmd.Connection = con;
                cmd.CommandText = query.ToLower();
                connect();

                OleDbDataReader reader = cmd.ExecuteReader();

                string id,username, type;
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    username = reader[1].ToString();
                    type = reader[2].ToString();
                   

                    btnUser btn = new btnUser();

                    btn.UserName = username;
                    btn.UserType = type;
                  
                    

                    if (username != string.Empty)
                    {
                        panel.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully..:)";
                }


            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                disconnect();
            }

            return ret;
        }

       

    }

}
