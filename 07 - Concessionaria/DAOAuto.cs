using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Utility;

namespace _07___Concessionaria
{
    class DAOAuto : IDAO
    {
        private Database db;

        private static DAOAuto instance = null;

        private DAOAuto()
        {
            db = new Database("concessionaria");

        }

        public static DAOAuto GetInstance()
        {
            if (instance == null)
                instance = new DAOAuto();

            return instance;
        }

        public Entity Cerca(int id)
        {
            string query = "select prodotti.*, cilindrata,velocitaMax, posti from prodotti inner join automobili on automobili.id = prodotti.id;" + id;
            
            Dictionary<string, string> riga = db.ReadOne(query);
            
            Automobile a = new Automobile();
            a.FromDictionary(riga);
            
            return a;

            //try
            //{
            //    return Elenco()[id - 1];
            //}
            //catch 
            //{
            //    return null;
            //}
        }   

        public bool Delete(int id)
        {
            return db.Update($"delete from automobili where id = {id}");
        }

        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();

            string query = "select prodotti.*, cilindrata,velocitaMax, posti from prodotti inner join automobili on automobili.id = prodotti.id;";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Automobile a = new Automobile();
                //dictionary valorizza tutte le stringhe nell'oggetto
                a.FromDictionary(riga);

                ris.Add(a);
            }
            return ris;
        }

        public bool Insert(Entity e)
        {
            Automobile a = (Automobile)e;

            string query = "insert into Automobili (id, cilindrata, velocitaMax, posti) " +
                             $"values('{a.Id}', {a.Cilindrata}, {a.VelocitaMax}, {a.Posti});";


            return db.Update(query);
        }

        public bool Update(Entity e)
        {
            Automobile a = (Automobile)e;

            
            string query1 = $"update prodotti set marca = '{a.Marca}', modello = '{a.Modello}', affittabile = '{a.Affittabile}', annoImmatricolazione = {a.AnnoImmatricolazione}, " +
                            $"consumoMedio = {a.ConsumoMedio}, capienzaSerbatoio = {a.CapienzaSerbatoio} where id = {a.Id}";
            string query2 = $"update automobili set id = {e.Id}, cilindrata = {a.Cilindrata}, velocitamax = {a.VelocitaMax}," +
                           $"posti = {a.Posti} where id = {a.Id}";
            return db.Update(query1) && db.Update(query2);
        }

        //→ Ritorna tutte le auto con potente() uguale a true
        public List<Automobile> AutoSuper()
        {
            List<Automobile> ris = new List<Automobile>();

            foreach (Automobile a in DAOAuto.GetInstance().Elenco())
                if (a.Potente())
                    ris.Add(a);

            return ris;
        }

        //→ Ritorna tutte le auto con la velocità più alta
        public List<Automobile> Veloci()
        {
            List<Automobile> ris = new List<Automobile>();
            
            int max = 0;
            foreach (Automobile a in DAOAuto.GetInstance().Elenco())
            {
                if (a.VelocitaMax > max)
                {
                    max = a.VelocitaMax;
                }
                else if (a.VelocitaMax == max)
                {
                    ris.Add(a);
                }
            }
           
            
            return ris;
        }


    }//fine classe
}