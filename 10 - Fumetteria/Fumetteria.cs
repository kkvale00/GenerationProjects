using System;
using System.IO;

namespace _10___Fumetteria
{
    class Fumetteria
    {
        public Fumetto[] fumetti;

        public Fumetteria(string path)
        {
            StreamReader file = null;

            if (File.Exists(path))
            {
                file = new StreamReader(path);
            }
            else
            {
                Console.WriteLine("Errore");
            }

            fumetti = new Fumetto[int.Parse(file.ReadLine())];

            string riga;
            int indice = 0;

            while ((riga = file.ReadLine()) != null)
            {
                string[] info = riga.Split(";");

                Fumetto f = new Fumetto(
                                        info[0],
                                        int.Parse(info[1]),
                                        info[2],
                                        info[3]
                                        );
                fumetti[indice] = f;
                indice++;
            }
        }

        public string ListaCompleta()
        {
            string ris = "";

            for (int i = 0; i < fumetti.Length; i++)
            {
                //fumetti-> vewttore
                //fumetti[i] -> Fumetto
                //fumetti[i].Scheda() -> string
                //fumetti[i].numero -> int
                ris += fumetti[i].Scheda();
            }

            return ris;
        }

        public string Cerca(string testata)
        {
            string ris = "";

            for (int i = 0; i < fumetti.Length; i++)
            {
                if (fumetti[i].testata.ToLower() == testata.ToLower())
                {
                    ris += fumetti[i].Scheda();
                }
            }

            return ris;
        }

        public double CostoMedio(string testata)
        {
            double ris = 0;
            int conta = 0;

            for (int i = 0; i < fumetti.Length; i++)
            {
                if (fumetti[i].testata.ToLower() == testata.ToLower())
                {
                    ris += fumetti[i].Prezzo();
                    conta++;
                }

            }
            //controllo
            if (conta == 0)
                return 0;
            else
                return ris / conta;
        }

        public string Economico()
        {
            string ris = "";
            double min = double.MaxValue;

            for (int i = 0; i < fumetti.Length; i++)
            {
                if (fumetti[i].Prezzo() < min)
                {
                    min = fumetti[i].Prezzo();
                    ris = fumetti[i].Scheda();
                }
                else if (fumetti[i].Prezzo() == min)
                {
                    ris += fumetti[i].Scheda();
                }
            }
            return ris;
        }

        public string PerCasaEditrice(string casaEditrice)
        {
            int conta = 0;

            for (int i = 0; i < fumetti.Length; i++)
            {
                if(fumetti[i].casaEditrice.ToLower() == casaEditrice.ToLower())
                {
                    conta++;
                }
            }

            return $"{casaEditrice.ToUpper()} {conta}";
        }

    }
}
