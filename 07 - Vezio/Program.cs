using System;

namespace _07___Vezio
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitatore v = new Visitatore();

            Console.WriteLine("Benvenuto, inserire le informazione:");
            Console.WriteLine("Nome:");
            v.nome = Console.ReadLine();
            Console.WriteLine("Professione");
            v.professione = Console.ReadLine();
            Console.WriteLine("Età?");
            v.eta = int.Parse(Console.ReadLine());
            Console.WriteLine("Residenza");
            v.residenza = Console.ReadLine();
            Console.WriteLine("Sei donaore= (S/N)");
            v.donatore = Console.ReadLine().ToLower() == "s";

            Console.WriteLine($"Grazie della visita {v.nome}, il prezzo del biglietto è {v.PrezzoBiglietto()}");

            
        } 
    }
}


