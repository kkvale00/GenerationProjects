using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace _05___TattooShop
{
    class DAOTatuaggio
    {
        private Database db;

        private static DAOTatuaggio instance = null;

        private DAOTatuaggio()
        {
            db = new Database("tattoostudio");

        }

        public static DAOTatuaggio GetInstance()
        {
            if (instance == null)
                instance = new DAOTatuaggio();

            return instance;
        }

        public List<Tatuaggio> ElencoTatuaggi()
        {
            List<Tatuaggio> ris = new List<Tatuaggio>();

            string query = "select * from tatuaggi;";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string,string> riga in righe)
            {
                Tatuaggio ta = new Tatuaggio();
                //dictionary valorizza tutte le stringhe nell'oggetto
                ta.FromDictionary(riga);
                //gli oggetti in (tatuatore) li valorizzo io chissa perch
                int idtatuatore = int.Parse(riga["idtatuatore"]);
                ta.Tat = DAOTatuatore.GetInstance().Cerca(idtatuatore);

                ris.Add(ta);
            }



            return ris;

        }

        public bool InsertTatuaggio(Tatuaggio t)
        {
            string query = "insert into tatuaggi (descrizione,data, colori, prezzo " +
                           "altezzacm, larghezzacm, idautore) values " +
                           $"('{t.Descrizione}', '{t.Data.ToString("yyyy-MM-dd")}' , " +
                           $"{t.Colori}, {t.Prezzo}, {t.Altezzacm}, {t.Larghezzacm}," +
                           $"{t.Tat.Id})";


            return db.Update(query);
        }






        public bool Delete(int id)
        {
            return db.Update($"delete from tatuaggio where id = {id}");
        }


    }
}
