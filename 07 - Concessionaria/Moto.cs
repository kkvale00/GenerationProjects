using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Concessionaria
{
    class Moto : Prodotto
    {
        public Moto() { }

        public Moto(int id, string marca, string modello, bool affittabile, int annoImmatricolazione, int consumoMedio, int capienzaSerbatoio, bool passeggeri) : base(id, marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaSerbatoio)
        {
            Passeggeri = passeggeri;
        }

        public bool Passeggeri { get; set; }

        public bool InCompagnia() => Passeggeri && KMPercorribili() >= 100;

        public override double Prezzo()
        {
            return base.Prezzo();
        }





    }//fine classe
}
