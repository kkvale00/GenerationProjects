using System;

namespace esericzio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Scrivere un programma che chiede all’utente di inserire 5 numeri in una lista di interi

            int[] num = new int[5];

            Console.WriteLine("Inserisci 5 numeri INTERI: ");

            //comunica quanti numeri sono maggiori della media di tutti i numeri della lista

            int sommaNumeri = 0;
            int mediaNumeri = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sommaNumeri += num[i];
            }
            mediaNumeri = sommaNumeri / 5;
            int maxNumeri = 0;

            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] > mediaNumeri)
                    maxNumeri++;
            }
            Console.WriteLine("questi sono i numeri maggiori della media di tutti i numeri da te inseriti: " + maxNumeri);
        }
    }
}
