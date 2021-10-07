using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _06___Zoo
{
    class Gabbia : Entity
    {
        public Gabbia() { }

        public Gabbia(int id, string tipoGabbia, int capienzaMax, List<Animale> animali)
                    : base(id)
        {
            TipoGabbia = tipoGabbia;
            CapienzaMax = capienzaMax;
            Animali = animali;
        }

        public string TipoGabbia { get; set; }
        public int CapienzaMax { get; set; }

        public List<Animale> Animali { get; set; }



    }//fine classe
}
