    using System;
using System.Collections.Generic;
using System.Text;

namespace _05___Azienda
{
    abstract class Persona
    {
        private string nome;
        private string cognome;
        private string dob;
        private string residenza;

        public Persona(string nome, string cognome, string dob, string residenza)
        {
            Nome = nome;
            Cognome = cognome;
            Dob = dob;
            Residenza = residenza;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Residenza { get => residenza; set => residenza = value; }


        public override string ToString()
        {

            return $">Nome:      {nome}\n"    +
                   $">cognome:   {cognome}\n" +
                   $">data:      {dob}\n"     +
                   $">residenza: {nome}\n"    ;
                   
        }

        public abstract double Stipendio();
    }
}
