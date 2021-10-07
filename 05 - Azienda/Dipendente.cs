using System;
using System.Collections.Generic;
using System.Text;

namespace _05___Azienda
{
    class Dipendente : Persona
    {
        private string reparto;
        private bool stage;
        private int annoAssunzione;

        public Dipendente(string nome, string cognome, string dob, string residenza, string reparto, bool stage, int annoAssunzione) 
                        : base(nome, cognome, dob, residenza)
        {
            Reparto = reparto;
            Stage = stage;
            AnnoAssunzione = annoAssunzione;
        }

        public string Reparto { get => reparto; set => reparto = value; }
        public bool Stage { get => stage; set => stage = value; }
        public int AnnoAssunzione { get => annoAssunzione; set => annoAssunzione = value; }
                                                                    

        public override string ToString()
        {
            return base.ToString() +
                   $">reparto:      {Reparto}\n" +
                   $">stage:   {Stage}\n" +
                   $">annoassunzione:      {AnnoAssunzione}\n";
                 
        }

        public override double Stipendio()
        {
            double stipendio = 1300;

            if (Reparto.ToLower() == "vendite" || Reparto.ToLower() == "acquisti")
                stipendio += 400;

            else if (reparto == "amministrazione")
                stipendio += 800;

            else stipendio += 200;

            stipendio += 35.3 * (2021 - AnnoAssunzione);

            if (Stage == true)
                stipendio = 600;

            return stipendio;
        }

    
        



















    }//fine classe
}
