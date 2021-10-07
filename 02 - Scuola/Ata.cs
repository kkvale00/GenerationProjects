using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Scuola
{
    class Ata : Personale
    {
        //1. dichiaro stringhe
        //2. incapsulo se sono private
        //3. apro il costruttore dalla classe
        //4. aggiungo proprietà dall'incapsulamento
        private bool partTime;

       

        public Ata(string cognome, string dob, string sesso, string residenza, string ruolo, string dataAssunzione,
                   bool partTime)
                : base(cognome, dob, sesso, residenza, ruolo, dataAssunzione)
        {
            PartTime = partTime;
        }

       

        public bool PartTime { get => partTime; set => partTime = value; }

        public override string Scheda()
        {
            return base.Scheda() +
                   $"Part Time: {partTime}";
        }

        public override double Stipendio()
        {
            return base.Stipendio() * (PartTime ? 0.55 : 1);
        }
    }
}
