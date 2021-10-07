using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace _06___Zoo
{
    class DAOAnimali : IDAO
    {
        //una classe puo avere solo 1 classe padre
        //una classe puo implementare quante interfacce vuole
        //se la mia classe e figlia di un'altra e implewmenta anche delle interfacce e 
        //sufficiente separare con una virgola la classe da cui ereditiamo e le varie interfacce
        //N.B. se abbiamo una classe padre dovra essere la prima as essere indicata
        //dopo i due punti, a seguire le varie interfacce
        //ES: animali : idao, mammt, patt ecc
        private Database db;

        private static DAOAnimali instance = null;

        private DAOAnimali()
        {
            db = new Database("zoo");

        }

        public static DAOAnimali GetInstance()
        {
            if (instance == null)
                instance = new DAOAnimali();

            return instance;
        }

        public List<Animale> CercaNellaGabbia(int idGabbia)
        {
            List<Animale> ris = new List<Animale>();

            string query = $"select * from animali where idgabbia = {idGabbia};";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Animale a = new Animale();
                //dictionary valorizza tutte le stringhe nell'oggetto
                a.FromDictionary(riga);

                ris.Add(a);
            }
            return ris;
        }
        public Entity Cerca(int id)
        {
            string query = "select * from animali where id = " + id;

            Dictionary<string, string> riga = db.ReadOne(query);

            Animale a = new Animale();
            a.FromDictionary(riga);

            return a;
        }

        public bool Delete(int id)
        {
            return db.Update($"delete from animali where id = {id}");
        }

        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();

            string query = "select * from animali;";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Animale a = new Animale();
                //dictionary valorizza tutte le stringhe nell'oggetto
                a.FromDictionary(riga);

                ris.Add(a);
            }
            return ris;

        }

        public bool Insert(Entity e)
        {
            Animale a = (Animale) e;

            string query = "insert into animali(specie,dob, sesso, pesoanimale " +
                "tipoalimentazione) values " +
                $"('{a.Specie}', '{a.Dob.ToString("yyyy-MM-dd")}' , " +
                $"'{a.Sesso}', {a.PesoAnimale}, {a.TipoAlimentazione}";

            return db.Update(query);
        }

        public bool Update(Entity e)
        {
            Animale a = (Animale) e;


            string query = "update animali set" +
                            $"specie = '{a.Specie}', dob = '{a.Dob.ToString("yyyy-MM-dd")}' , " +
                            $"sesso = '{a.Sesso}', pesoanimale = {a.PesoAnimale}," +
                            $"tipoalimentazione = {a.TipoAlimentazione}";

            return db.Update(query);
        }
    }//fine classe
}
