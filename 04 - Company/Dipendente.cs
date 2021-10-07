using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class Dipendente : Entity
    {
        public Dipendente() { }
        public Dipendente(int id, string nome, string cognome, string dob, double stipendio, string reparto) 
                        : base(id)
        {
            Nome = nome;
            Cognome = cognome;
            Dob = dob;
            Stipendio = stipendio;
            Reparto = reparto;
        }

        public string Nome {get; set;}
        public string Cognome     {get; set;}
        public string Dob     {get; set;}
        public double Stipendio      {get; set;}
        public string Reparto     {get; set;}

        public void FromDictionary(Dictionary<string,string> riga)
        {
            Id = int.Parse(riga["id"]);
            Nome =  riga["nome"];
            Cognome = riga["cognome"];
            Dob = riga["dob"];
            Stipendio = int.Parse(riga["stipendio"]);
            Reparto = riga["reparto"];
        }




                                      
    }//fine classe
}
