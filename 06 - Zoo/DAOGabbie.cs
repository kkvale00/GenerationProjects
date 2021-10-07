using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace _06___Zoo
{
    class DAOGabbie : IDAO
    {
        private Database db;

        private static DAOGabbie instance = null;

        private DAOGabbie()
        {
            db = new Database("zoo");

        }

        public static DAOGabbie GetInstance()
        {
            if (instance == null)
                instance = new DAOGabbie();

            return instance;
        }
        public List<Gabbia> CercaGabbieGestite(int idPersonale)
        {
            List<Gabbia> ris = new List<Gabbia>();

            string query = "select gabbie.*" +
                "from gestisce inner join gabbie" +
                "on gestisce.idgabbia = gabbie.id" +
                "where gestisce.idpersonale = " + idPersonale;


            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Gabbia g = new Gabbia();

                //Questo metodo si occuperà di valorizzare SOLO le proprietà semplici (stringhe, int, date..)
                g.FromDictionary(riga);

                //Quest'altra istruzione si occuperà di valorizzare la lista di animali
                //contenuti nella gabbia
                

                g.Animali = DAOAnimali.GetInstance().CercaNellaGabbia(int.Parse(riga["id"]));
                ris.Add(g);
            }

            return ris;




        }
        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();

            List<Dictionary<string, string>> righe = db.Read("select * from gabbie");

            foreach (Dictionary<string, string> riga in righe)
            {
                Gabbia g = new Gabbia();

                //Questo metodo si occuperà di valorizzare SOLO le proprietà semplici (stringhe, int, date..)
                g.FromDictionary(riga);

                //Quest'altra istruzione si occuperà di valorizzare la lista di animali
                //contenuti nella gabbia
                int idanimale = int.Parse(riga["idanimale"]);

                g.Animali = DAOAnimali.GetInstance().CercaNellaGabbia(int.Parse(riga["id"]));
                ris.Add(g);
            }

            return ris;

        }

        public Entity Cerca(int id)
        {
            string query = "select * from gabbie where id = " + id;

            Dictionary<string, string> riga = db.ReadOne(query);

            Animale a = new Animale();
            a.FromDictionary(riga);

            return a;
        }

        public bool Insert(Entity e)
        {
            Gabbia g = (Gabbia)e;

            string query = "insert into gabbie values " +
                            $"('{g.TipoGabbia}', {g.CapienzaMax}";

               

            return db.Update(query);
        }

        public bool Update(Entity e)
        {
            Gabbia g = (Gabbia)e;

            string query = "update gabbie set" +
                            $"tipogabbia = '{g.TipoGabbia}', capienza max = {g.CapienzaMax}";

            return db.Update(query);
        }

        public bool Delete(int id)
        {
            return db.Update($"delete from gabbie where id = {id}");
        }
    }
}
