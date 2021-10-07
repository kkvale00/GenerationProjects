using System;

namespace _05___Azienda
{
    class Program //Classe di avvio
    {
        static void Main(string[] args)
        {
            //Dichiarazione
            Persona p;

            //Inizializzo 
            p = new Persona();

            //Valorizzo i campi
            p.nome = "Alice";
            p.cognome = "Bensanelli";
            p.dob = "23-04-1997";
            p.residenza = "Zelo";
            
            /*Stampo i campi
            //Finchè metto un numero che come tipo risulta essere
            // "Più piccolo" del contenitore
            // Verrà convertito implicitamente
            // Al contrario no, ci avvertirà che non va bene, e che lo fa in auto
            int n = 10;
            double numerocondecimale = n;
            decimal dec1 = 33;
            */
            Console.WriteLine(p.scheda());
        }
    }
}
