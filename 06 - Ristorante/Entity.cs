using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Ristorante
{
    abstract class Entity
    {
        private int id;
        private string nome;

        protected Entity(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return $"id: {id}" +
                   $"nome: {nome}";
        }

        public abstract double Prezzo();

    }//fine classe
}
