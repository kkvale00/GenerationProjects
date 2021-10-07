using System;

namespace _10___Fumetteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Fumetteria f = new Fumetteria(@"C:\Users\kkvale\source\repos\SecondaSettimana\10 - Fumetteria\TextFile1.txt");

            string legenda = "==LEGENDA==" +
                             "\n1 -> stampa le schede di tutti i fumetti" +
                             "\n2 -> stampa tutte le schede della testata" +
                             "\n3 -> stampa prezzo medio testata cercata" +
                             "\n4 -> stampa schede fumetti che costano meno" +
                             "\n5 -> stampa frequenza casa editrice" +
                             "\n6 -> Legenda" +
                             "\n7 -> Exit";
            
            
            string cmd;
            string risposta;

            Console.WriteLine("Benevenuto");
            do
            {
                Console.WriteLine("\nInserisci un comando");
                cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        risposta = f.ListaCompleta();
                        break;
                    case "2":
                        Console.WriteLine("QUale testata?");
                        string testata = Console.ReadLine();
                        risposta = f.Cerca(testata);
                        break;
                    case "3":
                        Console.WriteLine("quale testata cerchi");
                        testata = Console.ReadLine();
                        risposta = $"prezzo medio per {testata.ToUpper()}: {f.CostoMedio(testata)}";
                        break;
                    case "4":
                        Console.WriteLine("qual è prezzo medio?");
                        risposta = f.Economico();
                        break;
                    case "5":
                        Console.WriteLine("QUale casa editrice");
                        string casaEditrice = Console.ReadLine();
                        risposta = "f.PerCasaEditrice()";
                        break;
                    case "6":
                        risposta = legenda;
                        break;
                    case "7":
                        risposta = "exit";
                        break;
                    default:
                        risposta = "appeso";
                        break;
                        

                }
            } while (cmd != "7");
        }







    }
}
