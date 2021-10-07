using System;
using System.Collections.Generic;
using System.Text;

namespace Prodotto
{
    class Rettangolo
    {
        public double baseRettangolo;
        public double altezzaRettangolo;

        public double Perimetro()
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public double Area()
        {
            return baseRettangolo * altezzaRettangolo;
        }


    }
}
