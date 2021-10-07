using System;

namespace _02___Scuola
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /*qui uso il setter
            p.Cognome = "Pippo";

            //qui uso il getter
            Console.WriteLine(p.Cognome);*/

            string path = @"C:\Users\kkvale\source\repos\TerzaSettimana\02 - Scuola\scuola.txt";
            
            Scuola s = new Scuola(path);
           
            Console.WriteLine(s.ContaBocciati());
        }
    }
}