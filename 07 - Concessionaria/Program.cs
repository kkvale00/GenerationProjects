using System;
using System.Collections.Generic;

namespace _07___Concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            DAOProdotto pr = DAOProdotto.GetInstance();
            DAOAuto da = DAOAuto.GetInstance();
            DAOMoto m = DAOMoto.GetInstance();

            Console.WriteLine("Benvenuto in sto programma del cazzo");
            string comando = "";
            string legenda = "Legenda del programma" +
                "\n1. Insert" +
                "\n2. Elenco" +
                "\n3. Update" +
                "\n4. Delete" +
                "\n5. ListProdottiVecchi" +
                "\n6.  Mezzipiukm" +
                "\n7. Autosuper" +
                "\n8. Motosportive" +
                "\n9. Lista Auto o Moto?" +
                "\n10.  quante auto e moto" +
                "\n11. cerca per marca" +
                "\n12. Stampa liste" +
                "\n13. Trova soluzione" +
                "\n14. broom broom + fast" +
                "\n15. metti in ordine" +
                "\nhelp";
            
            do
            {

                Console.WriteLine(legenda);
                Console.WriteLine("\nInserisci sto cazzo di comando");
                comando = Console.ReadLine();
                    
                switch (comando)
                {

                    case "1":
                        {
                            Console.WriteLine("\nPremi 1 per inserire auto e 2 per inserire moto ");
                            string comando2 = "";
                            comando2 = Console.ReadLine();
                            if (comando2 == "1")
                            {
                                Console.WriteLine("\nInserisci i dati del prodotto");
                                Console.WriteLine("Inserisci l'id");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci la marca");
                                string marca = Console.ReadLine();
                                Console.WriteLine("Inserisci il modello");
                                string modello = Console.ReadLine();
                                Console.WriteLine("Affittabile? (true o false)");
                                bool affittabile = bool.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci anno immatricolazione");
                                int annoimmatricolazione = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci consumo medio");
                                int consumomedio = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci la capienza del serbatoio");
                                int capienzaserbatoio = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nInserisci i dati dell'auto ");
                                Console.WriteLine("Inserisci la cilindrata");
                                int cilindrata = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci la velocità max");
                                int velocitamax = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci il numero posti");
                                int nposti = int.Parse(Console.ReadLine());
                                Prodotto p = new Prodotto(id, marca, modello, affittabile, annoimmatricolazione, consumomedio, capienzaserbatoio);
                                DAOProdotto.GetInstance().Insert(p);
                                Automobile a = new Automobile(id, marca, modello, affittabile, annoimmatricolazione, consumomedio, capienzaserbatoio, cilindrata, velocitamax, nposti);
                                DAOProdotto.GetInstance().Insert(a);
                            }

                            if (comando2 == "2")
                            {
                                Console.WriteLine("\nInserisci i dati del prodotto");
                                Console.WriteLine("Inserisci l'id");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci la marca");
                                string marca = Console.ReadLine();
                                Console.WriteLine("Inserisci il modello");
                                string modello = Console.ReadLine();
                                Console.WriteLine("Affittabile?");
                                bool affittabile = bool.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci anno immatricolazione");
                                int annoimmatricolazione = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci consumo medio");
                                int consumomedio = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserisci la capienza del serbatoio");
                                int capienzaserbatoio = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nInserisci i dati della moto \n");
                                Console.WriteLine("passeggero?(true o false)");
                                bool passeggerii = bool.Parse(Console.ReadLine());
                                Prodotto p = new Prodotto(id, marca, modello, affittabile, annoimmatricolazione, consumomedio, capienzaserbatoio);
                                DAOProdotto.GetInstance().Insert(p);
                                Moto a = new Moto(id, marca, modello, affittabile, annoimmatricolazione, consumomedio, capienzaserbatoio, passeggerii);
                                DAOProdotto.GetInstance().Insert(a);

                            }
                        }

                        break;
                    case "2":
                        Console.WriteLine(DAOProdotto.GetInstance().Elenco());
                        break;
                    case "3":
                        Console.WriteLine(DAOProdotto.GetInstance().Delete(int.Parse(Console.ReadLine())));
                        break;
                    case "4":
                        break;
                    case "5":
                        foreach (Prodotto p in DAOProdotto.GetInstance().ProdottiVecchi())
                                Console.WriteLine(p.ToString());
                        break;
                    case "6":
                        Console.WriteLine(DAOProdotto.GetInstance().MezzipiuKm());
                        break;
                    case "7":
                        foreach(Automobile a in DAOAuto.GetInstance().AutoSuper())
                        Console.WriteLine(a.ToString());
                        break;
                    case "8":
                        foreach(Moto moto in DAOMoto.GetInstance().Sportive())
                            Console.WriteLine(moto.ToString());
                        break;
                    case "9":
                        foreach(Prodotto p in DAOProdotto.GetInstance().CercaMezzo(Console.ReadLine()))
                            Console.WriteLine(p.ToString());
                        break;
                    case "10":
                            Console.WriteLine(DAOProdotto.GetInstance().Frequenza());
                        break;
                    case "11":
                            Console.WriteLine(DAOProdotto.GetInstance().CercaPerMarca(Console.ReadLine()));
                        break;
                    case "12":
                        List<Prodotto> array = new List<Prodotto>();
                        foreach (Prodotto p in DAOProdotto.GetInstance().Elenco())
                            array.Add(p);
                        Console.WriteLine(DAOProdotto.GetInstance().StampaListe(array));
                        break;
                    case "13":
                        Console.WriteLine("Inserire il budget massimo");
                            double budget = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inserire il numero dei passeggeri");
                            int passeggeri = int.Parse(Console.ReadLine());
                        foreach (Prodotto p in DAOProdotto.GetInstance().TrovaSoluzione(budget, passeggeri))
                            Console.WriteLine(p.ToString());
                            break;
                    case "14":
                        foreach(Automobile a in DAOAuto.GetInstance().Veloci())
                            Console.WriteLine(a);
                        break;
                    case "15":
                        foreach (Prodotto p in DAOProdotto.GetInstance().InOrdine())
                            Console.WriteLine(p.ToString());
                        break;
                    case "help":
                        Console.Clear();
                        string ris = "n" + legenda;
                        break;
                    default:
                        Console.WriteLine("comando errato");
                        break;

                }


            } while (comando != "exit");



            Console.WriteLine("Arrivederci");
        }
    }
}
