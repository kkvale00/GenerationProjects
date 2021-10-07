using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Ristorante
{
    class Piatto : Entity
    {
        private string[] ingredienti;
        private string[] allergeni;
        private string portata;

        public Piatto(int id, string nome, string[] ingredienti, string[] allergeni, string portata)
                    : base(id, nome)
        {
            Ingredienti = ingredienti;
            Allergeni = allergeni;
            Portata = portata;
        }

        public string[] Ingredienti { get => ingredienti; set => ingredienti = value; }
        public string[] Allergeni { get => allergeni; set => allergeni = value; }
        public string Portata { get => portata; set => portata = value; }

        public override string ToString()
        {
            return base.ToString() +
                   $"ingredienti: {Ingredienti}" +
                   $"allergeni: {Allergeni}" +
                   $"portata: {Portata}";
        }

        public override double Prezzo()
        {
            double prezzo = 5;

            for (int i = 0; i < ingredienti.Length; i++)
            {
                if (ingredienti[i] == "carne")
                    prezzo += 15;
                if (ingredienti[i] == "pesce")
                    prezzo += 23;
                if (ingredienti[i] == "soia")
                    prezzo += 27;
                else
                    prezzo += 45;
            }

            return prezzo;
        }

        public bool Allergenico(string allergene)
        {
            bool ris = false;

            for (int i = 0; i < Allergeni.Length; i++)
            {
                if (Allergeni[i] == allergene)
                    ris = true;
            }

            return ris;
        }

        public bool Allergenii(string[] allergeni)
        {
            bool ris = false;

            for (int i = 0; i < Allergeni.Length; i++)
            {
                if (Allergenico(allergeni[i]))
                    ris = true;
            }


            return ris;
        }


    }//fine classe
}
