using System;

namespace _09___Ospedale
{
    class Program
    {
        static void Main(string[] args)
        {
            Ospedale o = new Ospedale(@"C:\Users\kkvale\source\repos\SecondaSettimana\09 - Ospedale\RIPPERONI.txt");

            string legenda;
            string comando;
            string risposta;

            legenda = "=== LE(G)GENDA ===" +
                "\n1 -> Lista completa dei pazienti" +
                "\n2 -> Pazienti con degenza più lunga" +
                "\n3 -> Degenza media dei pazienti" +
                "\n4 -> Paziente più anziano" +
                "\nHELP -> Legenda" +
                "\nEXIT -> Esci\n";
            Console.WriteLine($"Benvenuto!!\n\n{legenda}");

            do
            {
                Console.WriteLine("INSERISCI IL COMANDO:");
                comando = Console.ReadLine();

                switch(comando)
                {
                    case "1":
                        risposta = o.ListaCompleta() + "\n";
                        break;
                    case "2":
                        risposta = o.DegenzaLunga() + "\n";
                        break;
                    case "3":
                        risposta = $"Durata media degenza: {o.DurataMediaDegenza()} giorni\n";
                        break;
                    case "4":
                        risposta = o.PazienteAnziano()+ "\n";
                        break;
                    case "HELP":
                        risposta = legenda;
                        break;
                    case "EXIT":
                        risposta = "Fine dei giochi brutto stronzo";
                        break;
                    default:
                        risposta = "C'è tempo e luogo per ogni cosa, ma non ora.DIOCANE";
                        break;
                }

                Console.WriteLine(risposta);
            } while (comando != "EXIT");

            Console.WriteLine("END");
            
        }
    }
}
