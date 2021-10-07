using System;

namespace _06___Ristorante
{
    class Program
    {
        static void Main(string[] args)
        {
            Ristorante r = new Ristorante(@"C:\Users\kkvale\source\repos\QuartaSettimana\06 - Ristorante\mockaroo fottiti.txt");
            Console.WriteLine(r.ListaCompleta());
            Console.WriteLine(r.Menubevande());
            Console.WriteLine(r.Menucibi());
            Console.WriteLine(r.Menubevandealcoliche());
            Console.WriteLine(r.Menunoallallergeni());
            Console.WriteLine(r.Menusenza(Console.ReadLine()));
            Console.WriteLine(r.Bevandapiucostosa());
            Console.WriteLine(r.CostoMedioPrimi());
            
           
        }
    }
}
