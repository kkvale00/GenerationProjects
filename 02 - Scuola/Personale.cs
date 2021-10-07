using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Scuola
{
    class Personale : Persona
    {
        private string ruolo;
        private string dataAssunzione;

        public Personale(string cognome, string dob, string sesso, string residenza, 
                         string ruolo, string dataAssunzione)
                        :base(cognome, dob, sesso, residenza)
        {
            Ruolo = ruolo;
            DataAssunzione = dataAssunzione;
        }

        public string Ruolo { get => ruolo; set => ruolo = value; }
        public string DataAssunzione { get => dataAssunzione; set => dataAssunzione = value; }

        public override string Scheda()
        {
            return base.Scheda() +
                   $"Ruolo: {ruolo}" +
                   $"dataAssunzione: {dataAssunzione}";

        }

        public virtual double Stipendio()
        {
            double ris = 800;

            //DataAssunzione sarà qualcosa di simile a "2020-09-22"
            ris += 20 * (2021 - int.Parse(DataAssunzione.Split("-")[0]));

            switch (Ruolo.ToLower())
            {
                case "segreteria":
                    ris += 300;
                    break;
                case "bidella":
                    ris += 120;
                    break;
                case "insegnante":
                    ris += 330;
                    break;
                default:
                    break;
            }

            return ris;

        }





    }
}
