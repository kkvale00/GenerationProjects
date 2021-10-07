using System;

namespace DimensioniCasa
{
    class Program //funzione che prende degli input e li trasforma in 
    {
        //stringa=parola
        static void Main(string[] args)
        {
            //Il programma verrà eseguito in ordine dall'inizio alla fine
            //La sequenza è il primo di 3 prinicipi fondamentali della programmazione.


            //Utilizziamo il metodo DICO: Dichiarazione, Input, Calcolo, Output

            //Dichiarazione -- si ma non ancora inizializzate --
            int lato1;
            int lato2;
            int perimetro;
            int piani;
            int area;

            //Input 
            //Nel momento in cui il programma arriva a questa istruzione, si ferma e aspetta
            //che l'utente scriva qualcosa (Console.Readline()) 
            //Quando l'utente preme invio, quel qualcosa viene preso e trasformato in un numero intero (int.Parse())
            //Una volta trasformato viene inserito nella variabile di nome lato1

            Console.WriteLine("Inserisci lato1 della casa in metri: ");
            lato1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci adesso il lato2 della casa in metri: ");
            lato2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci i piani della casa: ");
            piani = int.Parse(Console.ReadLine());


            //Calcolo
            perimetro = (lato1 + lato2) * 2;

            area = lato1 * lato2 * piani;

            //Output
            Console.WriteLine("Il perimetro della tua casa è di " + perimetro + " m " +
                "             \n" + "Invece l'area della tua cosa è di " + area + "m2");
            Console.ReadKey();




        }
    }
}
