using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Negozio
{
    class Videogioco : Prodotto
    {
        private string produttore;
        private string piattaforma;
        private int anno;
        private bool multiplayer;

        public Videogioco(int id, string nome, double prezzo, int quantita, string produttore, string piattaforma,
                          int anno, bool multiplayer)
                          : base(id, nome, prezzo, quantita)
        {
            this.Produttore = produttore;
            this.Piattaforma = piattaforma;
            this.Anno = anno;
            this.Multiplayer = multiplayer;
        }

        public string Produttore { get => produttore; set => produttore = value; }
        public string Piattaforma { get => piattaforma; set => piattaforma = value; }
        public int Anno { get => anno; set => anno = value; }
        public bool Multiplayer { get => multiplayer; set => multiplayer = value; }

        public override string ToString()
        {
            return base.ToString() +
                   $"produttore: {produttore} + \n" +
                   $"piattaforma: {piattaforma}\n" +
                   $"anno: {anno}\n" +
                   $"Multiplayer: {(multiplayer ? "si" : "no")}\n";
        }

        //=================================================\\
        //il prezzo scontato di un videogioco si calcola partendo dal prezzo originale a cui andiamo a:
        //togliere il 20% se è uscito più di 3 anni fa,
        //50% se è uscito più di 7 anni fa,
        //però se è uscito più di 25 anni fa aggiungere il 5%..
        //poi togliere il 30% se il titolo è multiplayer.
        //Il prezzo di un videogioco non può mai scendere sotto i 15€:
        //mettere un controllo per evitare che il prezzo scontato scenda sotto quella cifra

        public override double PrezzoScontato()
        {
            double prezzo = base.Prezzo;

            if (2021 - anno > 25)
                prezzo += prezzo * 0.05;
            else if (2021 - anno > 7)
                prezzo -= prezzo * 0.5;
            else if (2021 - anno > 3)
                prezzo -= prezzo * 0.2;

            if (multiplayer)
                prezzo -= prezzo * 0.3;

            if (prezzo < 15)
                prezzo = 15;

            return prezzo;
        }

















    }//fine classe
}
