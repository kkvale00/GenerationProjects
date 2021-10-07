using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _05___TattooShop
{
    class Tatuatore : Entity
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime Dob { get; set; }
        public string Residenza { get; set; }
        public int AnniEsperienza { get; set; }

        public Tatuatore(int id, string nome, string cognome, DateTime dob, string residenza, int anniEsperienza)
                       : base(id)
        {
            Nome = nome;
            Cognome = cognome;
            Dob = dob;
            Residenza = residenza;
            AnniEsperienza = anniEsperienza;
        }

        public Tatuatore() { }

        public void FromDictionary(Dictionary<string, string> riga)
        {
            Id = int.Parse(riga["id"]);
            Nome = riga["nome"];
            Cognome = riga["cognome"];
            Dob = DateTime.Parse(riga["dob"]);
            Residenza = riga["residenza"];
            AnniEsperienza = int.Parse(riga["anniesperienza"]);
        }






    }//fine classe
}
