using System;

namespace _04___Esercizio_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che chieda all'utente di inserire 5 numeri all'interno di un vettore, stampare:
            //quanti numeri sono pari,
            //quanti numeri sono maggiori della media dei numeri,
            //la parola "si" se almeno 2 numeri sono consecutivi tra di loro
            //(quindi ad esempio nel mio vettore ci sono 3-9-5-12-4 mi accorgo che 3 e 4 sono consecutivi quindi stamperò "si")


            Console.WriteLine("Inserisci 5 numeri");

            int n = int.Parse(Console.ReadLine());

            int[] vettore = new int[int.Parse(Console.ReadLine())];

           
            for (int i = 0; i < vettore.Length; i++)
            {

                vettore[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] % 2 == 0)
                    Console.WriteLine($"numeri pari {i + 1}: {vettore[i]} , ");
            }


            double media;
            double somma = 0;

            for (int i = 0; i < vettore.Length; i++)
            {
                somma += vettore[i];

            }
            media = somma / vettore.Length;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] > media)
                {
                    Console.WriteLine($"Numero n {i + i} > media: ");
                }
            }

            //stampare si se sono consecutive
            for (int i = 0; i < vettore.Length; i++)
            {
                for (int k = 0; k < vettore.Length; k++)
                {
                    if (vettore[k] == vettore[i] + 1 || vettore[k] == vettore[i] - 1)

                        Console.WriteLine("si");
                }

            }

            Console.WriteLine("inserisci un numero e vedro' se e' primo: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i < x; i++)
            {
                if (x / i == 0)
                    Console.WriteLine("il numero non e' primo");
            }
            //=============================================\\
            string parola = "";
            string ris = "";

            Console.WriteLine("inserisci parola");
            char[] caratteri = parola.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                if (char[] parola == caratteri)
            }
            

            Console.WriteLine(ris);









        }
    }
}