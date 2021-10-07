using System;
using System.Collections.Generic;
using System.Text;

namespace _03___CinemaReflection
{
    class DAOSerieTV 
    {
        private Database db;

        public DAOSerieTV()
        {
            db = new Database("movie");
        }
        
        public List<SerieTV> ElencoSerieTV()
        {
            List<SerieTV> ris = new List<SerieTV>();

            string query = "select * from serietv";

            List<Dictionary<string, string>> righe = db.Read(query);

        
            foreach (Dictionary<string, string> riga in righe)
            {
                SerieTV tv = new SerieTV();
                tv.FromDictionary(riga);
                ris.Add(tv);
            }

            return ris;
        }
        public bool InsertSerieTV(SerieTV tv)
        {
            //nella query escludiamo l'id in quanto autoincrement
            string query = "insert into serietv (titolo,genere,stagioni,puntatemedie,puntatamediapuntata)" +
                           $"values ('{tv.Titolo}','{tv.Genere}','{tv.Stagioni}',{tv.Puntatemedie},{tv.Puntatamediapuntata})";

            return db.Update(query);
        }

        public bool UpdateSerieTV(SerieTV tv)
        {
            string query = $"update serietv set titolo = '{tv.Titolo}', genere = '{tv.Genere}'," +
                           $" stagioni = {tv.Stagioni}, puntate medie = {tv.Puntatemedie}, duratamedia = {tv.Puntatamediapuntata}, " +
                           $" where id = {tv.Id}";

            return db.Update(query);
        }

        public bool DeleteSerieTV(int id)
        {
            string query = $"delete from serietv where id = {id}";

            return db.Update(query);
        }

    }
}
