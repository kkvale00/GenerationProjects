using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fattoriadicuihoappenascopertolesistenza
{
    class Fattoria
    {
        public List<Entita> entita;

        public Fattoria(string path)
        {
            entita = new List<Entita>();

            if (File.Exists(path))
            {
                string[] righe = File.ReadAllLines(path);

                for (int i = 0; i < righe.Length; i++)
                {
                    string[] riga = righe[i].Split(",");

                    switch (riga[0].ToLower())
                    {
                        case "bracciante":
                            entita.Add(new Bracciante
                                        (
                                          int.Parse(riga[1]),
                                          riga[2],
                                          riga[3],
                                          int.Parse(riga[4]),
                                          int.Parse(riga[5]),
                                          int.Parse(riga[6]),
                                          bool.Parse(riga[7]) == true
                                        )
                                );
                            break;
                        case "animale":
                            entita.Add(new Animale
                                            (
                                              int.Parse(riga[1]),
                                              riga[2],
                                              riga[3],
                                              riga[4],
                                              int.Parse(riga[5]),
                                              riga[6]
                                            )
                                );
                            break;


                        default:
                            break;
                    }

                }
            }
        }//fine costruttore

         //String ElencoAnimali
         public string ElencoAnimali()
        {
            string ris = "";

            foreach (Entita e in entita)
            {
                if (e is Animale a)
                    ris += $"{a.ToString()} + \n" ;
            }
            return ris;
        }

        // String ElencoBraccianti
        public string ElencoBraccianti()
        {
            string ris = "";

            foreach (Entita e in entita)
            {
                if (e is Bracciante b)
                    ris += $"{b.ToString()} + \n";
            }
            return ris;
        }

        // double CostoMensileBraccianti
        public double CostoMensileBraccianti()
        {
            double ris = 0;

            foreach (Entita e in entita)
            {
                if (e is Bracciante b)
                    ris += b.CostoMensile();
            }


            return ris;
        }

        // double CostoMensileMucche
        public double CostoMensileMucche()
        {
            double ris = 0;

            foreach (Entita e in entita)
            {
                if (e is Animale a && a.Razza == "mucca")
                    ris += a.CostoMensile();

            }


            return ris;
        }

        // double CostoMensileAnimali
        public double CostoMensileAnimali()
        {
            double ris = 0;

            foreach (Entita e in entita)
            {
                if (e is Animale b)
                    ris += b.CostoMensile();
            }

            return ris;
        }

        // double CostoMensileAnimali(string razza)
        public double CostoMensileAnimali(string razza)
        {
            double ris = 0;

            foreach (Entita e in entita)
            {
                if (e is Animale a && a.Razza == razza)
                    ris += a.CostoMensile();
            }

            return ris;
        }

        // double CostoMensileTotale
        public double CostoMensileTotale()
        {
            double ris = 0;

            foreach (Entita e in entita)
                ris += e.CostoMensile();

            return ris;
        }

        // String ElencoBraccianti(int COM) -> braccianti che hanno un costo orario < COM
        public string ElencoBraccianti(int COM)
        {
            string ris = "";

            foreach (Entita e in entita)
            {
                if (e is Bracciante b && b.CostoOrario == COM)
                    ris += b.ToString();

            }

            return ris;
        }

        // String BracciantePiuCostoso
        public string BracciantePiuCostoso()
        {
            string ris = "";
            double somma = 0;
            double max = 0;

            foreach (Entita e in entita)
            {
                if (e is Bracciante b)
                {
                    somma = CostoMensileBraccianti();

                    if (somma > max)
                    {
                        max = somma;
                        ris = b.ToString();
                    }
                
                    else if (somma == max)
                    {
                        ris += b.ToString();


                    }
                }
            }
            return ris;
        }

        public string RazzaPiuCostoso()
        {
            string ris = "";
            double somma = 0;
            double max = 0;

            foreach (Entita e in entita)
            {
                if (e is Animale a)
                {
                    somma = CostoMensileAnimali(a.Razza);

                    if (somma > max)
                    {
                        max = somma;
                        ris = a.Razza;
                    }

                    else if (somma == max)
                    {
                        ris += a.Razza;


                    }
                }
            }
            return ris;
        }

    }//fine classe
}
