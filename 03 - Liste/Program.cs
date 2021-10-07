using System;
using System.Collections.Generic;

namespace _03___Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una list consiste in un contenitore di elementi dello stesso di tipo, ordinati
            //secondo un indice e la sua dimensione VARIABILE

            //definisco una variabile, di tipo Lista di stringhe, di nome parole
            //richiamo il costruttore, creeando cosi l'oggetto
            List<string> parole = new List<string>();


            //aggiungo lista
            parole.Add("Pane" );
            parole.Add("Uova" );
            parole.Add("Pollo");

            for (int i = 0; i < parole.Count; i++)
            {
                Console.WriteLine($"in posizione {i} ho scritto {parole[i]}");
            }

            //Console.WriteLine(parole.Contains("Uova"));

            //non devo comprare piu uova
            //con il remove lo tolgo dalla lista. Il metodo risponde true o false
            //in base a se riesce a rimuoverle
            //non possono esserci buchi, togliendo le uova, il pollo scala alla posizione 1


            //parole.Remove("Uova");
            //parole.RemoveAt(2);

            //new List<string>(paroleArray);

            Console.WriteLine(parole.IndexOf("pollo"));

            string[] paroleArray = parole.ToArray();















        }//fine main
    }
}
