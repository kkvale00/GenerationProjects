using System;
using System.IO;

namespace _04___Negozio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeArticolo;
            int[] quantita;
            double[] prezzo;
            string[] datescadenza;
            bool[] esauriti;

            StreamReader file = null;

            try
            {
                file = new StreamReader(@"C:\Users\kkvale\source\repos\SecondaSettimana\04 - Negozio\articoli.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Percorso errato.");
            }

            int dim = int.Parse(file.ReadLine());

            nomeArticolo = new string[dim];
            quantita = new int[dim];
            prezzo = new double[dim];
            datescadenza = new string[dim];
            esauriti = new bool[dim];

            string riga;
            int indice = 0;

            while ((riga = file.ReadLine()) != null)
            {
                //crema solare;2;5,4;21-09-2021;n
                string[] info = riga.Split(";"); //si usa split per far capire cosa divide le parole
                                                 //     0       1  2       3     4
                                                 //crema solare 2 5,4 21-09-2021 n

                nomeArticolo[indice] = info[0];
                quantita[indice] = int.Parse(info[1]);
                prezzo[indice] = double.Parse(info[2]);
                datescadenza[indice] = info[3];
                esauriti[indice] = (info[4]) == "s"; //al posto di bool.Parse, si può usare il fottuto ternario

                indice++;
            }

            //calcolo
            //Lista dei nomi di tutti gli articoli
            string listaScheda = "";

            for (int i = 0; i < nomeArticolo.Length; i++)
            {
                listaScheda += "\n-> " + nomeArticolo[i];
            }
            Console.WriteLine("\nLista Nomi Articoli: " + listaScheda);

            //Lista dei prodotti scaduti
            string listaScaduti = "";
            bool[] scaduto = new bool[dim];

            for (int i = 0; i < nomeArticolo.Length; i++)
            {
                string[] data = datescadenza[i].Split("-");
                int[] dataParsata = { int.Parse(data[0]),
                                      int.Parse(data[1]),
                                      int.Parse(data[2]),
                                    };
                if (dataParsata[2] == 2021)
                {
                    if (dataParsata[1] <= 7)
                    {
                        if (dataParsata[0] <= 13)
                        {
                            listaScaduti += "\n- " + nomeArticolo[i];
                            scaduto[i] = true;
                        }
                    }
                }
                else if (dataParsata[1] < 7)
                {
                    listaScaduti += "\n- " + nomeArticolo[i];
                    scaduto[i] = false;
                }
                else if (dataParsata[2] < 2021)
                {
                    listaScaduti += "\n- " + nomeArticolo[i];
                    scaduto[i] = true;
                }

            }

            Console.WriteLine("\nLista Scaduti:" + listaScaduti);

            //Lista dei prodotti esauriti
            string listaEsauriti = "";

            for (int i = 0; i < nomeArticolo.Length; i++)
            {
                if (esauriti[i] == true)
                {
                    listaEsauriti += "\n-> " + nomeArticolo[i];
                }
            }

            Console.WriteLine("\nLista esauriti:" + listaEsauriti);

            //Il prezzo medio dei prodotti esauriti
            double sommaEsauriti = 0;
            int contaEsauriti = 0;

            for (int i = 0; i < nomeArticolo.Length; i++)
            {
                if (esauriti[i])
                {
                    sommaEsauriti += prezzo[i];
                    contaEsauriti++;
                }
            }
            Console.WriteLine("\nPrezzo Medio prodotti esauriti: " + sommaEsauriti / contaEsauriti);

            //- l'articolo non scaduto più costoso
            double max = 0;
            string prodottoMax = "";

            for (int i = 0; i < nomeArticolo.Length; i++)
            {
                if (scaduto[i] == false)
                {
                    if (prezzo[i] > max)
                    {
                        max = prezzo[i];
                        prodottoMax = nomeArticolo[i];
                    }
                    else if (prezzo[i] == max)
                        prodottoMax += ", " + nomeArticolo[i];
                }
            }
            Console.WriteLine("\nArticolo non scaduto più costoso: " + prodottoMax + " a " + max + " euro");

            //-l'articolo meno costosto
            double min = double.MaxValue; //per confronto in discesa partiamo dal valore max.
            string prodottoMin = "";

            for (int i = 0; i < prezzo.Length; i++)
            {
                if (prezzo[i] < min)
                {
                    min = prezzo[i];
                    prodottoMin = nomeArticolo[i];
                }
                else if (prezzo[i] == min)
                    prodottoMin += ", " + nomeArticolo[i];
            }
            Console.WriteLine("\nArticolo meno cosoto: " + prodottoMin + " a " + min + " euro");

            //- per ogni articolo, voglio vedere quanti giorni di vita rimangono
            string lista = "";

            for (int i = 0; i < prezzo.Length; i++)
            {
                string[] data = datescadenza[i].Split("-");
                int[] dataParsata =
                {
                    int.Parse(data[0]),
                    int.Parse(data[1]),
                    int.Parse(data[2]),
                };
                int giorni = (dataParsata[0] - 14) +
                             (dataParsata[1] - 7) * 30 + 
                             (dataParsata[2] - 2021) * 365;
                lista += "- " + nomeArticolo[i] + ": " + giorni;
            }
            Console.WriteLine("\nGiorni rimaneneti " + lista);

            string cmd;
            string risposta;

            string legenda = " === LEGENDA ===" +
                            "\n1-> Lista nomi articoli"+
                            "\n2-> Lista Scaduti" +
                            "\n3-> Prodotti Esauriti" +
                            "\n4-> Prezzo Medio Prodotti Esauriti" +
                            "\n5-> Articolo non scaduto più Costoso" +
                            "\n6-> Articolo meno Costoso" +
                            "\n7-> Giorni rimanenti" +
                            "\nHELP-> Legenda Comandi" +
                            "\nEXIT-> Termina Programma\n";

            do
            {
                Console.WriteLine("inserisci il comando");
                cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "1":
                        risposta = "Lista nomi articoli" + nomeArticolo;
                        break;
                    case "2":
                        risposta = "Lista scaduti" + listaScaduti;
                        break;
                    case "3":
                        risposta = "Lista prodotti esauriti" + listaEsauriti;
                        break;
                    case "4":
                        risposta = "Prezzo medio prodotti esauriti" + sommaEsauriti / contaEsauriti;
                        break;
                    case "5":
                        risposta = "Articolo non scaduto più costoso: " + prodottoMax + " a " + max + " euro";
                        break;
                    case "6":
                        risposta = "Articolo meno costoto: " + prodottoMin + " a " + min + " euro";
                        break;
                    case "help":
                        risposta = legenda;
                        break;
                    case "exit":
                        risposta = "Arrivederci";
                        break;
                    default:
                        risposta = "C'è momento e luogo per ogni cosa ma non ora.";
                        break;


                }



            } while (cmd.ToLower() != "exit");
        } //fine main
    }
}
