using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class Cliente : Entity
    {
        public Cliente() { }

        public Cliente(int id, string nome, string cognome, string cosacompra) 
                    : base(id)
        {
            Nome = nome;
            Cognome = cognome;
            Cosacompra = cosacompra;
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Cosacompra { get; set; }

        public void FromDictionary(Dictionary<string, string> riga)
        {
            Id = int.Parse(riga["id"]);
            Nome = riga["nome"];
            Cognome = riga["cognome"];
            Cosacompra = riga["cosacompra"];
        }
    }
}
