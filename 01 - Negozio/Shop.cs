using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _01___Negozio
{
    class Shop 
    {
        Prodotto[] prodotti;

        public Shop(string path)
        {

            if(File.Exists(path))
            {
                string[] righe = File.ReadAllLines(path);

                prodotti = new Prodotto[righe.Length];

                for (int i = 0; i < prodotti.Length; i++)
                {
                    string[] riga = righe[i].Split(";");

                    switch(riga[0].ToLower())
                    {

                        case "videogioco":
                            prodotti[i] = new Videogioco(
                                                            int.Parse(riga[1]),
                                                            riga[2],
                                                            double.Parse(riga[3]),
                                                            int.Parse(riga[4]),
                                                            riga[5],
                                                            riga[6],
                                                            int.Parse(riga[7]),
                                                            riga[8] == "si" 
                                                          );
                            break;

                        case "piattaforma":
                            prodotti[i] = new Piattaforma(
                                                            int.Parse(riga[1]),
                                                            riga[2],
                                                            double.Parse(riga[3]),
                                                            int.Parse(riga[4]),
                                                            riga[5],
                                                            int.Parse(riga[6]),
                                                            riga[7] == "si"
                                                        );
                            break;
                        default:
                            Console.WriteLine("Ritenta, sarai piu fortunato..");
                            break;

                    }//fine switch

                }//fine for
            }
            else
            {
                Console.WriteLine("C'è momento e luogo per ogni cosa, ma non ora");
                Console.ReadKey();

                //Se non esiste, chiudo il progrmma
                Environment.Exit(0);
            }
        }//END

        //1: ritornare il ToString di tutti i videogiochi
        public string ElencoVideogiochi()
        {
            string ris = "";
            

            foreach (Prodotto p in prodotti)
                if (p is Videogioco vhs)
                {
                    ris += $">{ vhs.ToString()} \n";
                                //non c'e bisogno del ToString()
                }

            return ris;
        }

        public string ElencoVideogiochi(string piattaforma)
        {
            string ris = "";

            foreach (Prodotto p in prodotti)
            {
                if(p is Videogioco vhs && vhs.Piattaforma == piattaforma)
                    ris += $">{ vhs.ToString()} \n";
                                   //non c'e bisogno del ToString()
            }


            return ris;
        }

        //3 : ToString dei videogiochi usciti prima di "annoUscita"

        public string ElencoVideogiochi(int annoUscita)
        {
            string ris = "";

            foreach (Prodotto p in prodotti)
            {
                if(p is Videogioco vhs && vhs.Anno < annoUscita)
                    ris += $">{ vhs.ToString()} \n";
            }

            return ris; ;
        }

        //4+5: ritornare il prezzo totale dei prodotti del negozio considerando anche le quantità

        public double ValoreNegozio()
        {
            double ris = 0;

            foreach (Prodotto p in prodotti)
                ris += (p.Prezzo) * p.Quantita;

            return ris;
        }

        //come prima ma tenendo conto del Prezzo scontato
        public double ValoreNegozioScontato()
        {
            double ris = 0;

            foreach (Prodotto p in prodotti)
                ris += p.PrezzoScontato() * p.Quantita;


            return ris;
        }

        //6: ritorna true se almeno la metà delle piattaforme che abbiamo nel nostro magazzino sono uscite nel 2000 o prima

        public bool Antiquariato()
        {
            int nplat = 0;
            int nplatOLD = 0;

            foreach(Prodotto p in prodotti)
                if(p is Piattaforma plat)
                {
                    nplat++;

                    if (2021 - plat.Anno >= 21)
                        nplatOLD++;
                }


            return nplatOLD > nplat / 2; ;
        }

        //7: ToString dei prodotti il cui prezzo scontato non superi il parametro passato


        public string Elenco(double prezzoScontatoMax)
        {
            string ris = "";

            foreach (Prodotto p in prodotti)
            {
                if(p.PrezzoScontato() <= prezzoScontatoMax)
                    ris += $">{ p.ToString()} \n";
            }

            return ris;
        }


        //8: ritornare il numero di videogiochi la cui piattaforma è
        // compresa tra quelle indicate nel vettore passato come parametro

        public int ConteggioGiochi(string[] piattaforme)
        {
            int ris = 0;

            foreach (Prodotto p in prodotti) // aprociclo
            {
                if (p is Videogioco v)
                {
                    foreach(string plat in piattaforme) //ciclo il vettore
                    {
                        if (v.Piattaforma.ToLower() == plat.ToLower())
                        {
                            ris++;
                            break;
                        }
                    }
                }
            }

            return ris;
        }


        //9: ritorna i titoli dei videogiochi la cui piattaforma
        //non comprare tra le piattaforme che abbiamo in vendita
        public string ElencoNonGiocabili()
        {
            string ris = "";

            string[] platselled;
            
            foreach (Prodotto p in prodotti)
            {
                if (p is Piattaforma plat)
                {
                    ris += plat.Nome + "/";
                }

                // 'bn/nfos' ----> 'bn/nfos'
                ris = ris.Substring(0, ris.Length - 1);

                platselled = ris.Split("/");

                bool presente;

                foreach (Prodotto prodotto in prodotti)
                {
                    if (p is Videogioco vhs)
                    {
                        presente = false;

                        foreach (string pvn in platselled)
                        {
                            if (vhs.Piattaforma == pvn)
                            {
                                presente = true;
                            }
                        }


                        if (!presente)
                            ris += vhs.Nome + "\n";
                    }
                }

                return ris;
            }//fineforeach















            return ris;
        }


    }//fine classe
}
