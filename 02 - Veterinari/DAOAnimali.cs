using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace _02___Veterinari
{
    class DAOAnimali
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

        public List<Animali> ListaCompletaAnimali()
        {
            List<Animali> ris = new List<Animali>();

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select * from animali";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Animali a = new Animali(
                                        dr.GetInt32("id"),
                                        dr.GetString("specie"),
                                        dr.GetString("problema"),
                                        dr.GetInt32("costoCure"),
                                        dr.GetInt32("idveterinario")
                                         );

                ris.Add(a);
            }

            dr.Close();
            c.Close();

            return ris;
        }

        public List<Animali> ListaCompletaProblemi()
        {
            List<Animali> ris = new List<Animali>();

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select distinct problema from animali; ";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Animali v = new Animali(
                                        dr.GetInt32("id"),
                                        dr.GetString("specie"),
                                        dr.GetString("problema"),
                                        dr.GetInt32("costoCure"),
                                        dr.GetInt32("idveterinario")
                                         );

                ris.Add(v);
            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Animali CostoMAX()
        {
            Animali ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select max(costoCure) as costomax, problema from animali";
           
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Animali(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetInt32("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Animali AVGCost()
        {
            Animali ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select avg(costoCure), speciefrom animali group by specie; ";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Animali(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetInt32("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }

        public Animali HowMany()
        {
            Animali ris = null;

            MySqlConnection c = CreaConnessione();
            c.Open();

            string query = "select count(*) as howmany,speciefrom animali group by specie; ";

            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ris = new Animali(
                                                 dr.GetInt32("id"),
                                                 dr.GetString("nome"),
                                                 dr.GetString("cognome"),
                                                 dr.GetInt32("anniLavorati"),
                                                 dr.GetInt32("stipendiomensile")
                                               );


            }

            dr.Close();
            c.Close();

            return ris;
        }

    }//fine classe



}
