using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace _01___Assicurazioni
{
    class DAOPersona
    {
        //DAO -> Data Access Object -> Indica semplicemente quella classe che si occupa
        //andare a pescare da una fonte esterna i dati che ci servono per lac reazione di oggetti
        //come le classi aggregratrici, MA solo degli oggetti persona
        
        public MySqlConnection CreaConnessione()
        {   
            //creiamo un metodo che connette sql e vsl
            string server = "127.0.0.1";
            string nomeDB = "polizza";
            string username = "root";
            string password = "root";

            string connectionString = $"SERVER={server}; DATABASE ={nomeDB};" +
                                      $"UID={username}; password ={password};";

            return new MySqlConnection(connectionString);
        }

        //quewsto metodo leggera nome e cognome nel database e li mette in ris
        public string NomiECognomi()
        {
            string ris = "";

            //1 - apri la connessione
            //2 - prepara la query
            //3 - eseguire la query
            //4 - scorrere una ad una tutte le righe del risultato della query
            //5 - concatenare a ris il nome e cognome
            //6 - fatto e chiudiamo la connessione

            //1
            MySqlConnection con = CreaConnessione();
            con.Open();

            //2
            string query = "select nome, cognome from persone";


            //3
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            //in dr avremo il risultato della query per eseguirla

            //4
            //questo ciclo si ripete finche all'interno del dr legge cose
            //ad ogni giro di ciclo passerà alla riga successiva
            
            while(dr.Read())
            {
                //5
                ris += dr["nome"] + " " + dr["cognome"] + "\n";
            }

            //6
            con.Close();

            return ris;
        }

        public List<Persona> ElencoPersone()
        {
            List<Persona> ris = new List<Persona>();

            MySqlConnection con = CreaConnessione();
            con.Open();

            string query = "select * from persone";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Persona p = new Persona(
                                        dr.GetInt32("id"),
                                        dr.GetString("nome"),
                                        dr.GetString("cognome"),
                                        dr.GetDateTime("dob"),
                                        dr.GetString("residenza"),
                                        dr.GetInt32("idassicuratore")
                                         );



                ris.Add(p);
            }

            dr.Close();
            con.Close();


            return ris;
        }









    }//fine classe
}
