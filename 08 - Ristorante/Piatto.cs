using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Ristorante
{
    class Piatto
    {
        public string nome;
        public double prezzo;
        public string portata;
        public string[] allergeni;
        public bool vegano;

        public string Scheda()
        {
            string ris = "";

            ris = $"Nome: {nome}," +
                  $"\nPortata: {portata}" +
                  $"\nPrezzo: {prezzo}" +
                  $"\nVegano: {(vegano ? "Si" : "No")}" +
                  $"\nAllergeni: {(stampaVettore() == "" ? "NESSUN ALLERGENE" : stampaVettore())}" +
                  $"\n=================================\n";
            return ris;
        }
        public string stampaVettore()
        {
            string ris = "";

            if (allergeni.Length != 0)
            {

                for (int i = 0; i < allergeni.Length; i++)
                {
                    ris += allergeni[i] + ", ";
                }
                    ris = ris.Substring(0, ris.Length - 2); //Tolgo la ", " finale
            
            }
                 return ris;
                

            

        }
    }
}
