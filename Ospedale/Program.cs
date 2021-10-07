using System;

namespace Ospedale
{
	class Program
	{
        static void Main(string[] args)
        {

            Ospedale o = new Ospedale(@"C:\Users\kkvale\source\repos\TerzaSettimana\Ospedale\elencopersone.txt");

            Persona p = o.persone[0];

            Console.WriteLine(o.ElencoPazienti()
                );
            Console.WriteLine($"Età media chirurghi:  {o.EtaMediaChirurghi()}"); //60,5
            Console.WriteLine($"Età media medici{o.EtaMediaMedici()}");    //50,25==>il chirurgo è medico e viene contato a sua volta
                                                                           //essendo loro anchessi medici;
                                                                           //si mette !(persone[i] is Chirurgo) -->vedi ospedale
            Console.WriteLine($"La somma degli stipendi è: {o.SommaStipendi()} euro");

            

        }                                             
	}
}
