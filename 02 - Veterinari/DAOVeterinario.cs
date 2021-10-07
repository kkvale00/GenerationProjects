using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace _02___Veterinari
{
    class DAOVeterinario
    {

        public MySqlConnection CreaConnessione()
        {
            string server = "localhost";
            string nomeDB = "veterinario";
            string user = "root";
            string pass = "root";

            string connection = $"SERVER={server}; DATABASE ={nomeDB};" +
                                $"UID={user}; password ={pass};";

            return new MySqlConnection(connection);
        }


        public List<Veterinario> ListaCompletaVeterinario()
        {
            List<Veterinario> ris = new List<Veterinario>();

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select * from veterinari";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Veterinario v = new Veterinario(
                                        dr.GetInt32("id"),
                                        dr.GetString("nome"),
                                        dr.GetString("cognome"),
                                        dr.GetInt32("anniLavorati"),
                                        dr.GetDouble("stipendiomensile")
                                         );

                ris.Add(v);
            }

            dr.Close();
            c.Close();

            return ris;
        }


        public Veterinario StipendioMensileMAX()
        {
            Veterinario ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select *, max(stipendioMensile) from veterinari;";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Veterinario(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetDouble("stipendiomensile")
                                               );

                
            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Veterinario StipendioMensileMIN()
        {
            Veterinario ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select *, min(stipendioMensile *12) from veterinari;";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Veterinario(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetDouble("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Veterinario AVGExp()
        {
            Veterinario ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select avg(anniLavorati) from veterinari; ";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Veterinario(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetDouble("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Veterinario MenoEXP()
        {
            Veterinario ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select *, min(anniLavorati) from veterinari; ";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Veterinario(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetDouble("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }





    }//fine classe

}
