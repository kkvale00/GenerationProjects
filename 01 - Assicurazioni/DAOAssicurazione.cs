using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace _01___Assicurazioni
{
    class DAOAssicurazione
    {
        public MySqlConnection CreaConnessione()
        {
            string server = "localhost";
            string nomeDB = "polizza";
            string user = "root";
            string pass = "root";

            string connection = $"SERVER={server}; DATABASE ={nomeDB};" +
                                $"UID={user}; password ={pass};";

            return new MySqlConnection(connection);
        }

        public List<Assicurazione> ListaCompleta()
        {
            List<Assicurazione> ris = new List<Assicurazione>();

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select * from assicurazioni";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Assicurazione p = new Assicurazione(
                                        dr.GetInt32("id"),
                                        dr.GetString("tipo"),
                                        dr.GetDouble("costoannuo")
                                         );



                ris.Add(p);
            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Assicurazione CostoMax()
        {
            Assicurazione ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select * from assicurazioni where costoannuo = (select max(costoannuo) from assicurazioni)";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();


            while(dr.Read())
            {
                ris = new Assicurazione(dr.GetInt32("id"),
                                        dr.GetString("tipo"),
                                        dr.GetDouble("costoannuo")
                                        );
            }

            dr.Close();
            c.Close();



            return ris;
        }








    }//fine classe
}
