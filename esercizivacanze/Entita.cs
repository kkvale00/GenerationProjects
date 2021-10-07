    using System;
using System.Collections.Generic;
using System.Text;

namespace ItaliaTeam
{
    abstract class Entita
    {
        private int matricola;
        private string specialita;
        private int piazzamento;

        protected Entita(int matricola, string specialita, int piazzamento)
        {
            Matricola = matricola;
            Specialita = specialita;
            Piazzamento = piazzamento;
        }

        public int Matricola { get => matricola; set => matricola = value; }
        public string Specialita { get => specialita; set => specialita = value; }
        public int Piazzamento { get => piazzamento; set => piazzamento = value; }


        public override string ToString()
        {
            return $"matricola: {matricola}\n" +
                   $"specialita: {specialita}\n" +
                   $"piazzamento: {piazzamento}\n";
                   
        }

    }//fine classe
}
