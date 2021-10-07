using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _06___Ristorante
{
    class Ristorante
    {
        public List<Entity> entity;

        public Ristorante(string path)
        {
            entity = new List<Entity>();

            if(File.Exists(path))
            {
                string[] righe = File.ReadAllLines(path);

                for (int i = 0; i < righe.Length; i++)
                {
                    string[] riga = righe[i].Split(",");

                    switch (riga[0].ToLower())
                    {
                        case "piatto":
                            entity.Add(new Piatto
                                (
                                    int.Parse(riga[1]),
                                    riga[2],
                                    riga[3].Split("-"),
                                    riga[4].Split("-"),
                                    riga[5]
                                )
                                );
                            break;
                        case "bevanda":
                            entity.Add(new Bevanda
                                (
                                    int.Parse(riga[1]),
                                    riga[2],
                                    riga[3].Split("-"),
                                    bool.Parse(riga[4]),
                                    int.Parse(riga[5])
                                )
                                );
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public string ListaCompleta()
        {
            string ris = "";

            foreach (Entity e in entity)
                ris += "," + e.ToString();

            return ris;
        }

        public string Menubevande()
        {
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Bevanda b)
                    ris += "," + b.ToString();
            }

            return ris;
        }

        public string Menucibi()
        {
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Piatto p)
                    ris += "," + p.ToString();
            }

            return ris;
        }

        public string Menubevandealcoliche()
        {
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Bevanda b && b.Alcolico)
                    ris += "," + b.ToString();
            }

            return ris;
        }

        public string Menunoallallergeni()
        {
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Piatto p && p.Allergeni.Length == 0)
                    ris += "," + p.ToString();
            }

            return ris;
        }


        public string Menusenza(string allergene)
        {
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Piatto p) //&& !p.Allergenico(allergene) 
                {
                    for (int i = 0; i < p.Allergeni.Length; i++)
                    {
                        if (p.Allergeni[i] == allergene)
                            ris += "," + p.ToString();

                    }
                }
            }

            return ris;
        }


        public string Bevandapiucostosa()
        {
            string ris = "";
            double max = 0;
            double somma = 0;

            foreach (Entity e in entity)
            {
                if(e is Bevanda b)
                {
                    somma = b.Prezzo();

                    if (somma > max)
                    {
                        somma = max;
                        ris = b.ToString();
                    }
                    

                    else if (somma == max)
                        ris = b.ToString();

                }
            }

            return ris;
        }

        public double CostoMedioPrimi()
        {
            double ris = 0;
            double n = 0;

            foreach (Entity e in entity)
            {
                if (e is Piatto p && p.Portata == "primo")
                {
                    ris += p.Prezzo();
                    n++;
                }
            }

            if (ris > 0)
                return ris / n;

            else
                return 0;
        }

        public string Contapiattiperportata()
        {
            int n = 0;
            string ris = "";

            foreach (Entity e in entity)
            {
                if (e is Piatto p)
                {
                    n = 0;

                    foreach (Entity f in entity)
                    {
                        if (f is Piatto pi)
                            if (pi.Portata == p.Portata)
                                n++;
                    }
                    if(!ris.Contains(p.Portata))
                    ris += p.Portata + n;
                        


                }
            }

            return ris;
        }








    }//fine classe
}
