using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Concessionaria
{
    class Automobile : Prodotto
    {
        public Automobile() { }

        public Automobile(int id, string marca, string modello, bool affittabile, int annoImmatricolazione, int consumoMedio, int capienzaSerbatoio, int cilindrata, int velocitaMax, int posti) 
                        : base(id, marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaSerbatoio)
        {
            Cilindrata = cilindrata;
            VelocitaMax = velocitaMax;
            Posti = posti;
        }

        public int Cilindrata  { get; set; }
        public int VelocitaMax { get; set; }
        public int Posti { get; set; }

        public bool Potente() => Cilindrata > 2000 && Famoso();

        public override double Prezzo()
        {
            double prezzo = base.Prezzo();

            if(Potente())
                prezzo += prezzo * 0.2;

            return prezzo;
        }







    }//fine classe
}
