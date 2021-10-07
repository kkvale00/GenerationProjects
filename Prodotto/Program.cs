using System;

namespace Prodotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una classe definisce sempre un TIPO
            // Prodotto prof;
            //   New  instanzia un nuovo oggetto


            Prodotto prod = new Prodotto();

            prod.nome = "Mouse da Gaming";
            prod.categoria = "Accessori PC";
            prod.prezzo = 19.9;


            //   OGNI prodotto ha un suo stato

            Prodotto prod2 = new Prodotto();

            prod2.nome = "Cuffie";
            prod2.categoria = "Audio";
            prod2.prezzo = 49.99;

            //scheda mi dà una stringa, posso farci cio che volgio
            string s1 = prod.Scheda();

            Console.WriteLine(prod.Scheda());
            Console.WriteLine(prod2.Scheda());

            //un oggetto ha come campo un campo di nome string
            //avra' il Campo nome, quello definito nella classe

            //Classe e oggetti sono collegati ma totalmente diversi

            //Finche' metto un numero che come tipo risulta essere
            //Piu' piccolo del contenitore
            //verra'convertito implicitamente
            //al contrario no, C# ci avvertira' che non e' operazione
            //che e' in grado di fare implicitamente
            /*
            int n = 10;
            float numeroDecimale1 = 12.0F;
            decimal dec1 = 33;
            double numeroConDecimale = n;
            Console.WriteLine(numeroConDecimale);
            */

            //Input
            Rettangolo rettangolo = new Rettangolo();
            Console.WriteLine("Inserire la base del rettangolo");
            rettangolo.baseRettangolo = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire l'altezza:");
            rettangolo.altezzaRettangolo = double.Parse(Console.ReadLine());

            //Output
            //C?? ce l'ha direttamente l'oggetto rettangolo
            //Mi basta invocare il metodo area
            Console.WriteLine($"L'area del rettangolo: {rettangolo.Area()}");
            Console.WriteLine($"Il perimetro: {rettangolo.Perimetro()}");
            


        } 
    }
}
