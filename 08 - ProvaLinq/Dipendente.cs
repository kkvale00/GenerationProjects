using System;
using System.Collections.Generic;
using System.Text;

namespace _08___ProvaLinq
{
    class Dipendente
    {
        public string nome;
        public int eta;
        public string residenza;
        public string reparto;
    }

    class Azienda
    {
        public List<Dipendente> dipendenti;

        public Azienda()
        {
            dipendenti = new List<Dipendente>();
            dipendenti.Add(new Dipendente
            {
                nome = "Yari",
                eta = 25,
                residenza = "milano",
                reparto = "Acquisti"
            });

            dipendenti.Add(new Dipendente
            {
                nome = "Pippo",
                eta = 35,
                residenza = "milano",
                reparto = "Acquisti"
            });

            dipendenti.Add(new Dipendente
            {
                nome = "Alice",
                eta = 38,
                residenza = "milano",
                reparto = "vendite"
            });
        }
    }


}
