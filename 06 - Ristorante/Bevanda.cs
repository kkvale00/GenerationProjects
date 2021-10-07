using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Ristorante
{
    class Bevanda : Entity
    {
        private string[] ingredienti;
        private bool alcolico;
        private double gradazione;

        public Bevanda(int id, string nome, string[] ingredienti, bool alcolico, double gradazione) 
                     : base(id, nome)
        {
            Ingredienti = ingredienti;
            Alcolico = alcolico;
            Gradazione = gradazione;
        }

        public string[] Ingredienti { get => ingredienti; set => ingredienti = value; }
        public bool Alcolico { get => alcolico; set => alcolico = value; }
        public double Gradazione { get => gradazione; set => gradazione = value; }

        public override string ToString()
        {
            return base.ToString() +
                  $"ingredienti: {ingredienti}" +
                  $"alcolico?: {alcolico}" +
                  $"gradazione: {gradazione}";
        }

        public override double Prezzo()
        {
            double prezzo = 3;

            for (int i = 0; i < Ingredienti.Length; i++)
            {
                if (Ingredienti[i] == "vino")
                    prezzo += 10;
                if (Ingredienti[i] == "analcolico")
                    prezzo += 3;
            }

            if (Alcolico)
                prezzo += 15;

            if (Gradazione > 19)
                prezzo += 23;
            else if (Gradazione > 25)
                prezzo += 3;
            
            return prezzo;
        }





    }//fine classe
}
