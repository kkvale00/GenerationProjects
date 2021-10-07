using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class Database
    {
        private MySqlConnection con;

        public Database(string nomedb, string server = "localhost",
                        string user = "root", string pass = "root")
        {
            string connection = $"SERVER={server}; DATABASE ={nomedb};" +
                                $"UID={user}; password ={pass};";

            this.con = new MySqlConnection(connection);
        }

        public List<Dictionary<string, string>> Read(string query)
        {
            List<Dictionary<string, string>> ris = new List<Dictionary<string, string>>();
            
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                Dictionary<string, string> riga = new Dictionary<string, string>();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    riga.Add(dr.GetName(i), dr.GetValue(i).ToString());
                }
                ris.Add(riga);

                
            }

            dr.Close();
            con.Close();

            return ris;
        }
        public Dictionary<string,string> ReadOne(string query)
        {
            try
            {
                return Read(query)[0];
            }
            catch
            {

                return null;
            }

        }
        public bool Update(string query)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n" +
                                  $"La seguente query ha prodotto un porcodio: \n " +
                                  $"{query} \n" +
                                  $"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
