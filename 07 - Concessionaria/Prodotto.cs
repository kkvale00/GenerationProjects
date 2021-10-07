using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _07___Concessionaria
{
    class Prodotto : Entity
    {
        public Prodotto() { }

        public string Marca { get; set; }
        public string Modello { get; set; }
        public bool Affittabile { get; set; }
        public int AnnoImmatricolazione { get; set; }
        public int ConsumoMedio { get; set; }
        public int CapienzaSerbatoio { get; set; }
        
        public Prodotto(int id, string marca, string modello, bool affittabile, int annoImmatricolazione, int consumoMedio, int capienzaSerbatoio)
                     : base(id)
        {
            Marca = marca;
            Modello = modello;
            Affittabile = affittabile;
            AnnoImmatricolazione = annoImmatricolazione;
            ConsumoMedio = consumoMedio;
            CapienzaSerbatoio = capienzaSerbatoio;
        }


        // Calcolo a vostro piacimento in base alla categoria
        public virtual double Prezzo()
        {
            double prezzo = 5000;

            if (AnnoImmatricolazione > 2010)
                prezzo += 650;
            if (ConsumoMedio > 10)
                prezzo += 500;
            switch (Marca.ToLower())
            {
                case "ferrari":
                    prezzo += 40000;
                    break;
                case "ducati":
                    prezzo += 10000;
                    break;
                case "bmw":
                    prezzo += 20000;
                    break;
            }

            return prezzo;
        }

         //→ Ritorna true se la marca è: Rolls Royce, Ferrari, Ducati o Harley Davidson
        public bool Famoso()
        {
            bool ris = false;

            if (Marca.ToLower() == "rolls royce" || Marca.ToLower() == "ferrari" || 
                Marca.ToLower() == "ducati" || Marca.ToLower() == "harley davidson")
                return true;


            return ris;
        }

        // Calcola quanti km posso percorrere con il carburante a disposizione
       public double KMPercorribili()
        {
            double ris;

            ris = CapienzaSerbatoio / ConsumoMedio;

            return ris;
        }


        //→ Se "affittabile" è TRUE, partendo da un prezzo di affitto pari al 40% del prezzo di vendita originale(considerate questo prezzo come il totale annuo),
        //calcolare quanto costa al mese affittare la macchina
       public double AffittoMensile()
        {
            double ris = 0;

            if(Affittabile)
                ris = Prezzo() * 0.4;

            return Math.Round(ris / 12,2);
        }


        //→ Calcola gli anni trascorsi da quando è stata immatricolata la macchina
        public int Eta() => DateTime.Today.Year - AnnoImmatricolazione;
        
    }//fine classe
}
