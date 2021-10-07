using System;
using System.Collections.Generic;
using System.Text;

namespace fattoriadicuihoappenascopertolesistenza
{
    class Bracciante : Entita
    {
        private int anniLavoro;
        private double costoOrario;
        private int oregiornaliere;
        private bool vittoalloggio;

        public Bracciante(int id, string nominativo, string dob, int anniLavoro, double costoOrario, int oregiornaliere, bool vittoalloggio)
                        : base(id, nominativo, dob)
        {
            AnniLavoro = anniLavoro;
            CostoOrario = costoOrario;
            Oregiornaliere = oregiornaliere;
            Vittoalloggio = vittoalloggio;
        }

        public int AnniLavoro { get => anniLavoro; set => anniLavoro = value; }
        public double CostoOrario { get => costoOrario; set => costoOrario = value; }
        public int Oregiornaliere { get => oregiornaliere; set => oregiornaliere = value; }
        public bool Vittoalloggio { get => vittoalloggio; set => vittoalloggio = value; }


        public override string ToString()
        {
            return base.ToString() +
                   $"annilavoro: {AnniLavoro}" +
                   $"costo orario: {CostoOrario}" +
                   $"ore giornaliere: {Oregiornaliere}" +
                   $"Vitto e alloggio: {Vittoalloggio}";

        }

        public override double CostoMensile()
        {
            int x = 0;
            int y = 0;

            if (vittoalloggio)
                y = 10;
            else y = 20;

            x = y + (anniLavoro / 10);

            return CostoOrario * oregiornaliere * x;
        }


    }//fine classe
}
