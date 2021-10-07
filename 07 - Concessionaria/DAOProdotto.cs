using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace _07___Concessionaria
{
    class DAOProdotto
    {
        private Database db;
        private static DAOProdotto instance = null;

        public static DAOProdotto GetInstance()
        {
            if (instance == null)
                instance = new DAOProdotto();

            return instance;
        }

        private DAOProdotto()
        {
            db = new Database("concessionaria");

        }
        public Entity Cerca(int id)
        {
            string query = "select * from prodotti where id = " + id;

            Dictionary<string, string> riga = db.ReadOne(query);

            Prodotto t = new Prodotto();
            Entity a = t;
            t.FromDictionary(riga);
            return a;
        }

        public bool Delete(int id)
        {
            return db.Update("delete from prodotti where id = " + id);
        }

        public List<Entity> Elenco()
        {
            List<Entity> ris = new List<Entity>();

            string query = "select * from prodotti";
            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
            {
                Prodotto f = new Prodotto();
                f.FromDictionary(riga);

                ris.Add(f);
            }
            return ris;
        }

        public bool Insert(Entity e)
        {
            Prodotto f = (Prodotto)e;

            string query = "insert into prodotti (marca, modello ,affittabile,annoImmatricolazione,consumoMedio,capienzaSerbatoio )" +
                $"values ('{f.Marca}','{f.Modello}', '{f.Affittabile}',{f.AnnoImmatricolazione},{f.ConsumoMedio}, {f.CapienzaSerbatoio})";


            return db.Update(query);
        }

        public bool Update(Entity e)
        {
            Prodotto a = (Prodotto)e;

            string query = $"update prodotti set marca = '{a.Marca}', modello = '{a.Modello}', affittabile = '{a.Affittabile}', annoImmatricolazione = {a.AnnoImmatricolazione}, " +
                $"consumoMedio = {a.ConsumoMedio}, capienzaSerbatoio = {a.CapienzaSerbatoio} where id = {a.Id}";
            return db.Update(query);
        }

        public List<Prodotto> ProdottiVecchi()
        {
            List<Prodotto> ris = new List<Prodotto>();

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
                if (p.Eta() > 8)
                    ris.Add(p);

            return ris;
        }

        //Ritorna le schede dei mezzi che possono fare più km(Sia macchine che moto)
        public string MezzipiuKm()
        {
            string ris = "";

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
            {
                double max = double.MinValue;

                if (p.KMPercorribili() > max)
                {
                    max = p.KMPercorribili();
                    ris = p.ToString();
                }
                else if (p.KMPercorribili() == max)
                    ris = p.ToString();
            }
            return ris;
        }

        //→ Ritorna tutti i mezzi che appartengono alla categoria cercata(ESEMPIO: cerca(“auto”) → Lista di tutte le auto a disposizione)
        public List<Prodotto> CercaMezzo(string categoria)
        {
            List<Prodotto> ris = new List<Prodotto>();

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
                if(categoria == "auto")
                {
                    foreach (Automobile a in DAOAuto.GetInstance().Elenco())
                        ris.Add(a);
                }
                else if(categoria == "moto")
                {
                    foreach (Moto moto in DAOMoto.GetInstance().Elenco())
                        ris.Add(moto);
                }

                return ris;
        }

        //→ Ritorna un dictionary con la frequenza per categoria(es: Moto:2, Automobile:4)
       public Dictionary<string, int> Frequenza()
        {
            Dictionary<string, int> ris = new Dictionary<string, int>();

            
            int moto = 0; 
            int auto = 0;

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
            {
                if (p is Automobile a)
                {
                    auto++;
                }

                else if (p is Moto m)
                {
                    moto++;
                   
                }
            }
             ris.Add("moto",moto);            
             ris.Add("auto",auto);            
             
            return ris; 
        }

        public string CercaPerMarca(string marca)
        {
            string ris = "";
            string query = $"select * from prodotti where marca = '{marca.ToLower()}'";
            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> line in righe)
            {
                Prodotto p = new Prodotto();
                p.FromDictionary(line);
                ris += p.ToString() + " ";
            }

            return ris;
        }

        //Stampa in maniera ordinata un array di elementi di tipo Prodotto
        public string StampaListe(List<Prodotto> array)
        {
            string ris = null;

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
            {

                ris += p.ToString() + "\n =========== \n";
            }
            return ris;
        }

        //→ Ritorna una lista di mezzi che si possono affittare con il budget mensile
        //e il numero di passeggeri passati come parametri
        public List<Prodotto> TrovaSoluzione(double budgetMensile, int passeggeri)
        {
            List<Prodotto> ris = new List<Prodotto>();

           
            foreach(Prodotto p in DAOProdotto.GetInstance().Elenco())
            {
                if (p is Automobile a && p.AffittoMensile() <= budgetMensile && a.Posti >= passeggeri) 
                    ris.Add(p);

                else if (p is Moto m && p.AffittoMensile() <= budgetMensile && m.Passeggeri) 
                     ris.Add(m);
            }

            return ris;
        }

        public List<Prodotto> InOrdine()
        {

            List<Prodotto> ris = new List<Prodotto>();

            foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
            {
                ris.Add(p);
            }

            List<Prodotto> risultato = ris.OrderBy(p => p.Prezzo()).ToList();

            return risultato;
        }
    }

}