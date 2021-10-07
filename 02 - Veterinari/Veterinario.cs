using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Veterinari
{
    class Veterinario
    {
        private int id;
        private string nome;
        private string cognome;
        private int anniLavorati;
        private double stipendioMensile;

        public Veterinario(int id, string nome, string cognome, int anniLavorati, double stipendioMensile)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            AnniLavorati = anniLavorati;
            StipendioMensile = stipendioMensile;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int AnniLavorati { get => anniLavorati; set => anniLavorati = value; }
        public double StipendioMensile { get => stipendioMensile; set => stipendioMensile = value; }

        public override string ToString()
        {
            return $"id: {Id}"+
                   $"nome: {Nome}"+
                   $"cognome: {Cognome}"+
                   $"anni lavoro: {AnniLavorati}"+
                   $"stipendio mensile: {StipendioMensile}";
        }
    }
}
