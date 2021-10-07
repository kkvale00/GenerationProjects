using System;

namespace _01___Negozio
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop s = new Shop(@"C:\Users\kkvale\source\repos\QuartaSettimana\01 - Negozio\TextFile1.txt");

            //Console.WriteLine(s.ElencoVideogiochi());
            //Console.WriteLine(s.ElencoVideogiochi());
            //Console.WriteLine(s.ElencoVideogiochi(2007));
            //Console.WriteLine(s.ValoreNegozio());
            //Console.WriteLine(s.ValoreNegozioScontato());
            //Console.WriteLine(s.Elenco(19));

            /* string[] p = {"Wii", "Switch", "Playstation 4"};

             Console.WriteLine($"Il numero dei giochi e{s.ConteggioGiochi(p)}");*/

           
             Console.WriteLine(s.ElencoNonGiocabili());
        }//fine main
    } 
}

