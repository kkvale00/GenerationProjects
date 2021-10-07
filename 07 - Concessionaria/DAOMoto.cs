using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace _07___Concessionaria
{
    class DAOMoto
    {
        private Database db;
        private DAOMoto()
        {
            db = new Database("concessionaria");
        }

        private static DAOMoto instance = null;
        public static DAOMoto GetInstance()
        {
            if (instance == null)
                instance = new DAOMoto();

            return instance;
        }

        public Entity Cerca(int id)
        {
            Moto m = new Moto();

            string query = $"select * from moto inner join prodotti on moto.id = prodotti.id where id = {id}";

            Dictionary<string, string> riga = db.ReadOne(query);

            m.FromDictionary(riga);

            return m;
        }
        public bool Delete(int id)
        {
            return db.Update($"delete from moto where {id}");
        }
        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();
            string query = "select prodotti.*, passeggeri from moto inner join prodotti on moto.id = prodotti.id";
            List<Dictionary<string, string>> righe = db.Read(query);
            Entity e;
            foreach (Dictionary<string, string> riga in righe)
            {
                e = new Moto();
                e.FromDictionary(riga);
                ris.Add(e);
            }
            return ris;
        }
        public bool Insert(Entity e)
        {
            Moto a = (Moto)e;

            string query = "insert into prodotti (id, passeggeri )" +
               $"values ('{a.Id}','{a.Passeggeri}')";

            return db.Update(query);
        }
        public bool Update(Entity e)
        {
            Moto a = (Moto)e;

            string query = $"update moto set(id = {e.Id}, passeggeri = {a.Passeggeri}  where id = {e.Id})";

            return db.Update(query);
        }

        //→ Ritorna tutte le moto che non hanno passeggeri
        public List<Moto> Sportive()
        {
            List<Moto> ris = new List<Moto>();

            foreach (Moto m in DAOMoto.GetInstance().Elenco())
                if (!(m.InCompagnia()))
                    ris.Add(m);

                return ris;
        }

    }//fine classe
}
