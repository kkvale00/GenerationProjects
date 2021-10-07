using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _06___Zoo
{
    class DAOPersonale : IDAO
    {
        private Database db;

        private static DAOPersonale instance = null;

        private DAOPersonale()
        {
            db = new Database("zoo");

        }

        public static DAOPersonale GetInstance()
        {
            if (instance == null)
                instance = new DAOPersonale();

            return instance;
        }

        public Entity Cerca(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();

            List<Dictionary<string, string>> righe = db.Read("select * from personale");

            foreach (Dictionary<string, string> riga in righe)
            {
                Personale p = new Personale();

                //Questo metodo si occuperà di valorizzare SOLO le proprietà semplici (stringhe, int, date..)
                p.FromDictionary(riga);

                //Quest'altra istruzione si occuperà di valorizzare la lista di animali
                //contenuti nella gabbia
                int idgabbie= int.Parse(riga["idgabbie"]);

                p.Gabbie = DAOGabbie.GetInstance().CercaGabbieGestite(int.Parse(riga["id"]));
                ris.Add(p);
            }

            return ris;

        }

        public bool Insert(Entity e)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entity e)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //public bool Update(Entity e)
        //{
        //    Personale g = (Personale)e;
        //
        //    string query = "update personale set" +
        //                    $"tipogabbia = '{g.TipoGabbia}', capienza max = {g.CapienzaMax}";
        //
        //    return db.Update(query);
        //}
        //
        //public bool Delete(int id)
        //{
        //    return db.Update($"delete from personale where id = {id}");
        //}
    }
}
