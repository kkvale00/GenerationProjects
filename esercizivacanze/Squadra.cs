using System;
using System.Collections.Generic;
using System.Text;

namespace ItaliaTeam
{
    class Squadra : Entita
    {
        string[] nominativi;
        string sesso;

        public Squadra(int matricola, string specialita, int piazzamento, string[] nominativi, string sesso)
                      : base(matricola, specialita, piazzamento)
        {
            Nominativi = nominativi;
            Sesso = sesso;
        }

        public string[] Nominativi { get => nominativi; set => nominativi = value; }
        public string Sesso { get => sesso; set => sesso = value; }




        public override string ToString()
        {
            return base.ToString() +
                   $"nominativi: {Nominativi}\n" +
                   $"sesso: {Sesso}\n";
        }


        public int AtletiInSquadra()
        {
            int ris = 0;

            for (int i = 0; i < nominativi.Length; i++)
            {
                ris++;
            }            

            return ris;
        }

        public bool Partecipante(string n)
        {
            bool ris = false;

            for (int i = 0; i < nominativi.Length; i++)
            {
                if (n == nominativi[i])
                    ris = true;
            }

            return ris;
        }




    }
}
