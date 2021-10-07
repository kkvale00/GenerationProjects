using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03___CinemaReflection
{
    //questa classe si occupera di connetere qualcuno al database e le query
    //i parametri opzionali entrano in azione solo se chi crea l'oggetto nno li da
    //altrimernti quelli inseriti dasl chiamante

    class Database
    {
        private MySqlConnection con;

        //per costruire una connessiione serve: server, nomedb, user, pass

        public Database(string nomedb, string server = "localhost",
                        string user = "root", string pass = "root")
        {
            string connection = $"SERVER={server}; DATABASE ={nomedb};" +
                                $"UID={user}; password ={pass};";

            this.con = new MySqlConnection(connection);
        }

        //Cos'è una Lista?
        //Un contenitore di oggetti dello stesso tipo ordinati con dimensione variabile

        //Cos'è un Dictionary?
        //Un Dictionary è una Lista ma al posto degli indici che partono da 0 ci metto
        //io degli indici che voglio (sia per tipo che per valore).
        //DOMANDA CHE METTO NEL TEST SE NON MI SCRIVETE QUESTA DEFINIZIONE BENE
        //VI MANDO LA GUARDA DI FINANZA A CASA MALEDETTI
        //Un Dictionary è un insieme di coppie chiave-valore in cui il tipo,
        //sia delle chiavi che dei valori, lo scegliamo noi e le cui chiavi non si 
        //ripetono mai.

        public List<Dictionary<string, string>> Read(string query)
        {
            //inizializzo ris
            List<Dictionary<string, string>> ris = new List<Dictionary<string, string>>();
            //Aprire la connessione grazie all'oggetto MySqlConnection con
            con.Open();
            //Creerà poi il Command per l'esecuzione della query arrivata come parametro
            MySqlCommand cmd = new MySqlCommand(query, con);
            //Creerà il DataReader che conterrà il risultato del Command eseguito
            MySqlDataReader dr = cmd.ExecuteReader();
            //Cicleremo il nostro DR e ciascuna riga la trasformeremo in un Dictionary
            //Inseriremo il Dictionary in un Lista
            while (dr.Read())
            {
                Dictionary<string, string> riga = new Dictionary<string, string>();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    riga.Add(dr.GetName(i), dr.GetValue(i).ToString());
                }
                ris.Add(riga);

                //Quando il ciclo sarà terminato restituiremo la Lista
            }
            con.Close();
            return ris;
        }
        //questo metodo ci rispondera con soltalto la prima riga della query passata
        public Dictionary<string, string> ReadOne(string query)
        {
            try
            {
                //provo a restiuire la prima riga che trovo eseguendo la query
                return Read(query)[0];
               
            }
            catch 
            {
                //se finisco nel catch significa che la query non ha risultati
                return null;
            }
        }

        //questo metodo esegue un'operazione di INSERT,UPDATE,DELETE
        //come parametro

        public bool Update(string query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);
                Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n" +
                                  $"La seguente query ha prodotto un porcodio: \n " +
                                  $"{query} \n" +
                                  $"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                return false;
            }
            finally //in ogni caso, try o catch chiudi la connesione
            {
                con.Close();
            }



        }

    }//fine classe
}
