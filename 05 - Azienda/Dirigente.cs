using System;
using System.Collections.Generic;
using System.Text;

namespace _05___Azienda
{
    class Dirigente : Persona
    {

        private int dipendentiGestiti;
        private string[] repartiGestiti;

        public Dirigente(string nome, string cognome, string dob, string residenza,
                         int dipendentiGestiti, string[] repartiGestiti)
                        : base(nome, cognome, dob, residenza)
        {
            DipendentiGestiti = dipendentiGestiti;
            RepartiGestiti = repartiGestiti;
        }

        public int DipendentiGestiti { get => dipendentiGestiti; set => dipendentiGestiti = value; }
        public string[] RepartiGestiti { get => repartiGestiti; set => repartiGestiti = value; }


        public override string ToString()
        {
            return base.ToString() +
                   $">dipendenti: {DipendentiGestiti}\n" +
                   $">reparti:   {RepartiGestiti}\n";
        }


        public bool AmministraAcquisti()
        {
            bool amm = false;
            bool acquisti = false;

            for (int i = 0; i < RepartiGestiti.Length; i++)
            {
                if (RepartiGestiti[i].ToLower() == "amministrazione")
                    amm = true;

                if (RepartiGestiti[i].ToLower() == "acquisti")
                    acquisti = true;
                

            }

            if (amm && acquisti)
                return true;
            else
                return false;
        }



        public bool nonVenditeAcquisti()
        {
            bool amm = false;
            bool acquisti = false;

            for (int i = 0; i < RepartiGestiti.Length; i++)
            {
                if (RepartiGestiti[i].ToLower() == "vendite")
                    amm = true;

                if (RepartiGestiti[i].ToLower() == "acquisti")
                    acquisti = true;


            }

            if (!amm && !acquisti)
                return true;
            else
                return false;
        }



        public override double Stipendio()
        {
            double stipendio = 3500;

            stipendio += DipendentiGestiti * 12.5;


            foreach (string rg in RepartiGestiti)
            {
                stipendio += rg.Length * 130;
            }

            for (int i = 0; i < repartiGestiti.Length; i++)
            {
                if (RepartiGestiti[i] == "vendite")
                    stipendio += stipendio * 0.05;
                if (AmministraAcquisti())
                    stipendio += stipendio * 0.12;
                if (nonVenditeAcquisti())
                    stipendio += stipendio * 0.06;
            }

            return stipendio;
        }





























    }//fine classe
}
