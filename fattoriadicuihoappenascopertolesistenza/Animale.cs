using System;
using System.Collections.Generic;
using System.Text;

namespace fattoriadicuihoappenascopertolesistenza
{
    class Animale : Entita
    {
        private string razza;
        private int nzampe;
        private string tipoalimentazione;

        public Animale(int id, string nominativo, string dob, string razza, int nzampe, string tipoalimentazione) :
                       base(id, nominativo, dob)
        {
            Razza = razza;
            Nzampe = nzampe;
            Tipoalimentazione = tipoalimentazione;
        }

        public string Razza { get => razza; set => razza = value; }
        public int Nzampe { get => nzampe; set => nzampe = value; }
        public string Tipoalimentazione { get => tipoalimentazione; set => tipoalimentazione = value; }

        public override string ToString()
        {
            return base.ToString() +
                   $"razza: {Razza}" +
                   $"numero zampe: {Nzampe}" +
                   $"tipo alimentazione: {Tipoalimentazione}";
        }

        public override double CostoMensile()
        {

            double ris = 3;

            if (razza == "gallina")
                ris += 0.5;
            else if (razza == "cavallo")
                ris += 7;
            else if (razza == "mucca")
                ris += 12;
            else
                ris += 8;
            if (Tipoalimentazione == "carnivoro")
                ris += 4;

            return ris;
        }

    }//fine classe
}
