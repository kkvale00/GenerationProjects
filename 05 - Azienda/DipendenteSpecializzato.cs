using System;
using System.Collections.Generic;
using System.Text;

namespace _05___Azienda
{
    class DipendenteSpecializzato : Dipendente
    {   
        public DipendenteSpecializzato(string nome, string cognome, string dob, string residenza, string reparto,
                                         int annoAssunzione)
                                       : base(nome, cognome, dob, residenza, reparto, false, annoAssunzione)
        {
            if (2021 - AnnoAssunzione < 5)
                       AnnoAssunzione = 5;
        }

        public override double Stipendio()
        {
            return base.Stipendio() + Stipendio() * 0.15;
        }

        public override string ToString()
        {   
            
            return base.ToString() + "\nil dipendente è yarizzato";
        }

        










    }//cfine classe
}
