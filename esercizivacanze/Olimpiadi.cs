using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ItaliaTeam
{
    class Olimpiadi
    {
        public List<Entita> entita;

        public Olimpiadi(string path)
        {
            entita = new List<Entita>();

            if(File.Exists(path))
            {
                string[] righe = File.ReadAllLines(path);

                for (int i = 0; i < righe.Length; i++)
                {
                    string[] riga = righe[i].Split(",");

                    switch (riga[0].ToLower())
                    {
                        case "Atleta":
                            entita.Add(new Atleta
                                                (
                                                int.Parse(riga[1]),
                                                riga[2],
                                                int.Parse(riga[3]),
                                                riga[4],
                                                int.Parse(riga[5]),
                                                riga[6]
                                                )
                                      );
                            break;
                        case "squadra":
                            entita.Add(new Squadra
                                                   (
                                                    int.Parse(riga[1]),
                                                    riga[2],
                                                    int.Parse(riga[3]),
                                                    riga[4].Split("-"),
                                                    riga[5]
                                                    )
                                );
                            break;
                        default:
                            break;
                    }

                }
            }//fine if
        }//fine metodo

        public string ListaAtleti()
        {
            string ris = "";


            foreach (Entita e in entita)
            {
                if (e is Atleta a)
                    ris += a.ToString();
            }

            return ris;
        }

        public string ListaSquadre()
        {
            string ris = "";


            foreach (Entita e in entita)
            {
                if (e is Squadra d)
                    ris += d.ToString();
            }

            return ris;
        }

        public double EtaMedia()
        {
            double ris = 0;
            int n = 0;

            foreach (Entita e in entita)
            {
                if (e is Atleta a)
                    ris += a.Eta();
                    n++;

            }

            return ris / n;
        }

        public bool CiSonoPiuMaschi()
        {
            bool ris = false;
            int m = 0;
            int f = 0;

            foreach (Entita e in entita)
            {
                if (e is Atleta a && a.Sesso == "m")
                    m++;
                else
                    f++;

                if (m > f)
                    ris = true;
                else
                    ris = false;
            }

            return ris;
        }

        public string SquadreNatleti(int n)
        {
            string ris = "";

            foreach (Entita e in entita)
            {
                if(e is Squadra s)
                    for (int i = 0; i < s.Nominativi.Length; i++)
                    {
                        if (s.AtletiInSquadra() > n)
                            ris = s.ToString();

                    }

            }

            return ris;
        }

        public int Chissa(int n)
        {
            int ris = 0;

            foreach (Entita e in entita)
            {
                if (e.Piazzamento == n)
                    ris++;
            }

            return ris;
        }




    }//fine classe
}//fine main
