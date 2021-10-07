using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Negozio
{
    class Piattaforma : Prodotto
    {
        private string nazione;
        private int anno;
        private bool regionLocked;

        public Piattaforma(int id, string nome, double prezzo, int quantita, string nazione, int anno, bool regionLocked) : base(id, nome, prezzo, quantita)
        {
            Nazione = nazione;
            Anno = anno;
            RegionLocked = regionLocked;
        }

        public string Nazione { get => nazione; set => nazione = value; }
        public int Anno { get => anno; set => anno = value; }
        public bool RegionLocked { get => regionLocked; set => regionLocked = value; }



        public override string ToString()
        {
            return base.ToString() +
                   $"nazione: {nazione} + \n" +
                   $"anno: {anno}\n" +
                   $"Non disponibile a Napoli e: {(regionLocked ? "si" : "no")}\n";
        }
        //========================================\\
        //- il prezzo scontato di una console si calcola togliendo il 15% se la nazione è "giappone",
        //20% se è "cina", 30% se è altro.
        //Togliere altri 30€ se è region locked.
        //Il prezzo di una console non può mai scendere sotto i 120€ se è uscita dal 2010 in poi,
        //altrimenti non può mai scendere sotto i 40€



        public override double PrezzoScontato()
        {
            double prezzo = base.Prezzo;

            switch (nazione)
            {
                case "giappone":
                    prezzo -= prezzo * 0.15;
                        break;
                case "cina":
                    prezzo -= prezzo * 0.2;
                        break;
                default:
                    prezzo -= prezzo * 0.3;
                    break;
            }

            if (regionLocked)
                prezzo -= prezzo * 0.3;

            if (2021 - anno <= 11 && prezzo < 120)
                prezzo = 120;
            else if (2021 - anno > 11 && prezzo < 40)
                prezzo = 40;

            return prezzo;
        }


    }
}
