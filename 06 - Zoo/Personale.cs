using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _06___Zoo
{
    class Personale : Entity
    {
        public Personale() { }

        public string Nominativo { get; set; }
        public DateTime Dob { get; set; }
        public string Residenza { get; set; }
        public List<Gabbia> Gabbie { get; set; }

        public Personale(int id, string nominativo, DateTime dob, string residenza, List<Gabbia> gabbie) 
                       : base(id)
        {
            Nominativo = nominativo;
            Dob = dob;
            Residenza = residenza;
            Gabbie = gabbie;
        }




    }//fine classe
}
