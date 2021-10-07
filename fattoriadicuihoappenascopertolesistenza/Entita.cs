using System;
using System.Collections.Generic;
using System.Text;

namespace fattoriadicuihoappenascopertolesistenza
{
    abstract class Entita
    {
        private int id;
        private string nominativo;
        private string dob;

        protected Entita(int id, string nominativo, string dob)
        {
            Id = id;
            Nominativo = nominativo;
            Dob = dob;
        }

        public int Id { get => id; set => id = value; }
        public string Nominativo { get => nominativo; set => nominativo = value; }
        public string Dob { get => dob; set => dob = value; }

        public override string ToString()
        {
            return $"id: {id}" +
                   $"nominativo: {nominativo}" +
                   $"data di nascita: {dob}";
        }

        public abstract double CostoMensile();






    }//fine classe
}