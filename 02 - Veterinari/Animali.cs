using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Veterinari
{
    class Animali
    {
        private int id;
        private string specie;
        private string problema;
        private double costoCure;
        private int idveterinario;

        public Animali(int id, string specie, string problema, double costoCure, int idveterinario)
        {
            Id = id;
            Specie = specie;
            Problema = problema;
            CostoCure = costoCure;
            Idveterinario = idveterinario;
        }

        public int Id { get => id; set => id = value; }
        public string Specie { get => specie; set => specie = value; }
        public string Problema { get => problema; set => problema = value; }
        public double CostoCure { get => costoCure; set => costoCure = value; }
        public int Idveterinario { get => idveterinario; set => idveterinario = value; }


        public override string ToString()
        {
            return $"id: {Id}" +
                   $"specie: {Specie}" +
                   $"problema: {Problema}" +
                   $"costo cure: {CostoCure}" +
                   $"idvet: {Idveterinario}";
        }
    }
}
