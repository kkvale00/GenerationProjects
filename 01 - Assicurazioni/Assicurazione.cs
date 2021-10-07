using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Assicurazioni
{
    class Assicurazione
    {
        private int id;
        private string tipo;
        private double costoAnnuo;

        public Assicurazione(int id, string tipo, double costoAnnuo)
        {
            Id = id;
            Tipo = tipo;
            CostoAnnuo = costoAnnuo;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double CostoAnnuo { get => costoAnnuo; set => costoAnnuo = value; }

        public override string ToString()
        {
            return $"ID{Id}\n " +
                   $"Tipo: {Tipo}\n " +
                   $"CostoAnnuo: {CostoAnnuo} euro" +
                   $"\n----\n";
        }





    }//fine classe
}
