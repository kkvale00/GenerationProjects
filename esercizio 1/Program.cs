using System;

namespace esercizio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecco i numeri: ");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ,");

                if (i == 3 || i % 3 == 0)  //quando deve stampare un multiplo di 3 oltre al numero stamperà “hello”
                {
                    Console.Write(i + " hello, ");
                }
                if (i == 5 || i % 5 == 0)  //se il numero è multiplo di 5 stamperà “world”
                {
                    Console.Write(i + " world, ");
                }
                if (i % 3 == 0 && i % 5 == 0)  //fosse allo stesso tempo multiplo di 3 e 5 stamperà “ERRORE”.
                {
                    Console.Write(" ERRORE ,");
                }

            }
            Console.ReadKey();
        }
    }
}
