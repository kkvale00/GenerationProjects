using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Vezio
{
    class Visitatore
    {
        public string nome;
        public string professione;
        public string residenza;
        public int eta;
        public bool donatore; // true o false

        public string Risultato()
        {
            int prezzo = PrezzoBiglietto();
            string ris = $"Grazie della visita {nome}, ";
           
            if (prezzo == 0)
            {
                ris += "Hai il diritto di entrare gratis!";
            }
            else
            {
                ris += $"Il prezzo del biglietto è {prezzo}";
            }
           return ris;
        }


        //Il prezzo del biglietto dipende da diverse condizioni
        //Di base costa 15, ci sono degli sconti
        // quando la professione è docente o studente: 10
        // quando la sua età è minore di 6 o maggiore di 65: 5
        // quando risulta essere donatore ha sconto: 2
        //se è residente a vezio, non paga: 0
        //Offrire sempre il prezzo più vantaggioso possibile

        public int PrezzoBiglietto()
        {
            int ris = 15;

            if (professione == "studente" || professione == "docente")
            {
                ris = 10;
            }

            if (eta < 6 || eta > 65)
            {
                ris = 5;
            }

            if (donatore)
            {
                ris -= 2;
            }
             
            if (residenza.ToLower() == "vezio")
            {
                ris = 0;
            }

            return ris;
        }
    }
}
