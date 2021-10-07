using System;
using System.Collections.Generic;
using System.Text;

namespace _01___Assicurazioni
{
    class Persona
    {
        private int id;
        private string nome;
        private string cognome;
        private DateTime dob;
        private string residenza;
        private int idAssicuratore;

        public Persona(int id, string nome, string cognome, DateTime dob, string residenza, int idAssicuratore)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.dob = dob;
            this.residenza = residenza;
            this.idAssicuratore = idAssicuratore;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Residenza { get => residenza; set => residenza = value; }
        public int IdAssicuratore { get => idAssicuratore; set => idAssicuratore = value; }
    }//fine classe
}
