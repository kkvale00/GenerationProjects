using System;
using System.Collections.Generic;

namespace esercizio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che chiede all’utente di inserire una parola
            Console.WriteLine("Inserisci una parola: ");

            string parola = Console.ReadLine().ToLower();

            //comunica quante vocali sono presenti in essa
            int tot = 0;
            var vocali = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < parola.Length; i++)
            {
                if (vocali.Contains(parola[i]))
                {
                    tot++;
                }
            }
            Console.WriteLine("Le vocali presenti totali sono : {0}", tot);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
