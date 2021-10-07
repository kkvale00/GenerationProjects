using System;

namespace Rettangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un istruzione è un comando che diamo al pc
            //Ogni istruzione potrebbe essere dalle altre per mille motivi, 
            //ma ogni istruzione si chiude con ; SEMPRE

            //Con queste due istruzioni abbiamo definito una variabile e le abbiamo assegnato un valore.

            //Una variabile è una scatola che contiene un valore di un determinato tipo.
            //Int=intero, quindi nella scatola "baseRettangolo" possono andare solo numeri interi

            int baseRettangolo = 5;
            int altezzaRettangolo = 8;

            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            int area = baseRettangolo * altezzaRettangolo;

            baseRettangolo = 2;

            //Grazie alla concatenazione rendo "IL perimetro è 26" un'unica stringa, aggiungendo la note con le apici " xxx "
            Console.WriteLine("Il perimetro è " + perimetro + " cm");
            Console.WriteLine("L'area è " + area + " cm2");

            Console.ReadKey();
 
        }
    }
}
