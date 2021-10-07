using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _09___LibreriaCarol
{
    class DAOLibro 
    {

        private Database db;

        private static DAOLibro instance = null;

        private DAOLibro()
        {
            db = new Database("libreriacarol");

        }

        public static DAOLibro GetInstance()
        {
            if (instance == null)
                instance = new DAOLibro();

            return instance;
        }

        public List<Entity> CercaT(string m)
        {
            string query = $"select * from libri where titolo like '%{m}%' or autore like '%{m}%'";
            List<Entity> ris = new List<Entity>();

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Libro l = new Libro();

                l.FromDictionary(riga);

                ris.Add(l);
            }

            return ris;
        }


        public List<Entity> ElencoLibri()
        {
            List<Entity> ris = new List<Entity>();

            List<Dictionary<string, string>> righe = db.Read("select * from libri");

            foreach (Dictionary<string, string> riga in righe)
            {
                Libro l = new Libro();

                l.FromDictionary(riga);

                ris.Add(l);
            }

            return ris;
        } 
        public List<string> ElencoAutori()
        {
            List<string> ris = new List<string>();

            List<Dictionary<string, string>> righe = db.Read("select autore,titolo from libri order by autore");

            foreach (Dictionary<string, string> riga in righe)
            {
                Libro l = new Libro();

                l.FromDictionary(riga);

                ris.Add(l.Autore + " " + l.Titolo);
            }

            return ris;
        }

        public bool Insert(Entity e)
        {
            Libro l = (Libro)e;

            string query = "insert into libri (titolo,autore,genere,annopubblicazione,lingua)values " +
                            $"('{l.Titolo}', '{l.Autore}','{l.Genere}',{l.Annopubblicazione},'{l.Lingua}'";

            return db.Update(query);
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entity e)
        {
            throw new NotImplementedException();
        }
    }
}
