using System;

namespace _09___LibreriaCarol
{
    class Program
    {
        static void Main(string[] args)
        {
            DAOLibro lb = DAOLibro.GetInstance();

          //  foreach (Libro l in DAOLibro.GetInstance().CercaT(Console.ReadLine()))
          // Console.WriteLine(l.ToString());

            Console.WriteLine("Benvenuto nella BIBLIOTECA");
            string comando = "";
            string legenda = "Legenda del programma" +
                "\n1. Digita 1 per vedere l'Elenco Libri" +
                "\n2. Digita 2 per vedere l'ElencoAutori" +
                "\n3. Digita 3 per Cercare" +
                "\nhelp";

            do
            {

                Console.WriteLine(legenda);
                Console.WriteLine("\nInserisci il comando");
                comando = Console.ReadLine();

                switch (comando)
                {

                    case "1":
                            Console.WriteLine("\nEcco a te l'Elenco Libri");
                            foreach(Libro l in DAOLibro.GetInstance().ElencoLibri())
                                Console.WriteLine(l.ToString());
                        break;
                    case "2":
                        Console.WriteLine("\nEcco a te l'Elenco Autori");
                        foreach (string autore in DAOLibro.GetInstance().ElencoAutori())
                            Console.WriteLine(autore);
                        break;
                    case "3":
                        Console.WriteLine("\nCerca un Titolo o un Autore");
                        foreach (Libro l in DAOLibro.GetInstance().CercaT(Console.ReadLine()))
                            Console.WriteLine(l.ToString());
                        break;
                    case "help":
                        Console.Clear();
                        string ris = "n" + legenda;
                        Console.WriteLine(ris);
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
