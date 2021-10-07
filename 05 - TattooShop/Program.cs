using System;

namespace _05___TattooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //DAOTatuatore dt1 = DAOTatuatore.GetInstance();
            //Tatuatore instance = new Tatuatore();
            //Tatuatore t = new Tatuatore(4, "davide", "testa", DateTime.Parse("1978/10/08"), "giugliaen", 14);

            //Console.WriteLine(DAOTatuatore.GetInstance().Insert(t));

            //foreach (Tatuaggio t in DAOTatuaggio.GetInstance().ElencoTatuaggi())
            //    Console.WriteLine(t + "\n=============================\n");

            Console.WriteLine("salve umano, che vuoi?\n");

            int comando;

            do
            {
                Console.WriteLine("cosa vuoi fare?\n" +
                                  "1 - Elenco Tatuaggi\n" +
                                  "2 - Cerca tatuatore per id\n" +
                                  "3 - esci");

                comando = int.Parse(Console.ReadLine());

                switch (comando)
                {
                    case 1:
                        foreach (Tatuaggio t in DAOTatuaggio.GetInstance().ElencoTatuaggi())
                            Console.WriteLine(t + "\n=============================\n");
                        break;

                    case 2:
                        Console.WriteLine("inserisci l'id del tatuatore da cercare");
                        int idDacercare = int.Parse(Console.ReadLine());
                        Console.WriteLine(DAOTatuatore.GetInstance().Cerca(idDacercare));
                        break;

                    case 3:
                        Console.WriteLine("ucciditi");
                        break;
                    default:
                        Console.WriteLine("comando non riconosciuto");
                        break;
                }

            } while (comando != 3);












        }
    }
}