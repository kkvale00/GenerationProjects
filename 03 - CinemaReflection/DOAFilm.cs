using System;
using System.Collections.Generic;
using System.Text;

namespace _03___CinemaReflection
{
    class DOAFilm
    {
        //questa classe attraverso della query chiedera a database di fronirgli
        //dei dati e li tramutera in Film



        private Database db;

        public DOAFilm()
        {
            db = new Database("movie");
        }

        //Tutti i metodi che si troveranno qui in questa classe li definiamo:
        //METODI CRUD (Create Read Update Delete)
        //Tutti i metodi che ci sono in questa classe servono ad interagire con il DB
        //e a svolgere funzioni CRUD

        //I metodi Read, che devono fare delle ricerche tra i dati del database si dividono in:
        //- ORM: prelevano dal database TUTTI i dati per poi trasferlri in oggetti
        //       ed effettuare la ricerca a livello di C#
        //- NON-ORM: eseguono direttasmente la query che ci permettera di leggere solo 
        //           cio di cui abbiamo bisogno
        public List<Film> ElencoFilm()
        {
            List<Film> ris = new List<Film>();

            string query = "select * from films";

            List<Dictionary<string, string>> righe = db.Read(query);

            //prendere i dictionary e convertirli in file
            foreach (Dictionary<string,string> riga in righe)
            {
                Film f = new Film();
                f.FromDictionary(riga);
                ris.Add(f); 
            }

            return ris;
        }

        public bool InsertFilm(Film f)
        {
            //nella query escludiamo l'id in quanto autoincrement
            string query = "insert into films (titolo,durata,genere,annouscita)" +
                           $"values ('{f.Titolo}',{f.Durata},'{f.Genere}',{f.Annouscita})";

            return db.Update(query);
        }

        public bool UpdateFilm(Film f)
        {
            string query = $"update films set titolo = '{f.Titolo}', durata = {f.Durata}," +
                           $" genere = '{f.Genere}', annouscita = {f.Annouscita}" +
                           $" where id = {f.Id}";

            return db.Update(query);
        }

        public bool DeleteFilm(int id)
        {
            string query = $"delete from films where id = {id}";

            return db.Update(query);
        }

        public int SommaDurateORM()
        {
            List<Film> elenco = ElencoFilm();

            int ris = 0;

            foreach (Film f in elenco)
                ris += f.Durata;

            return ris;
        }

        public int SommaDurateNONORM()
        {
            int ris = 0;

            string query = "select sum(durata) as somma from films";

            Dictionary<string, string> riga = db.ReadOne(query);

            ris = int.Parse(riga["somma"]);
            return ris;
        }


    }
}
