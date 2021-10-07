using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _06___Zoo
{
    class Animale : Entity
    {
        public Animale() { }

        public string Specie { get; set; }
        public DateTime Dob { get; set; }
        public string Sesso { get; set; }
        public double PesoAnimale { get; set; }
        public string TipoAlimentazione { get; set; }

        public Animale(int id, string specie, DateTime dob, string sesso, double peso, string tipoAlimentazione) 
                     : base(id)
        {
            Specie = specie;
            Dob = dob;
            Sesso = sesso;
            PesoAnimale = peso;
            TipoAlimentazione = tipoAlimentazione;
        }













    }//fine classe
}