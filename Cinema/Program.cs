using System;

namespace Cinema
{
	class Program
	{
		static void Main(string[] args)
		{

			//Il prezzo intero è di 10€
			//Ci sono degli sconti, applicare il più vantaggioso
			//Se la tua professione è "militare" o "insegnante" paghi 7€
			//Se hai meno di 12 anni o almeno 65 anni paghi 5€
			//Se sei un "medico" residente a "milano paghi 8€
			//Se sei un carabiniere paghi 112€

			//Dichiarazione
			int prezzoBiglietto = 10;
			int eta;
			string professione;
			string residenza;

			//Input
			Console.WriteLine("Qual è la tua professione?");
			professione = (Console.ReadLine().ToLower());
			
			Console.WriteLine("Qual è la tua residenza?");
			residenza = (Console.ReadLine().ToLower());

			Console.WriteLine("Qual è la tua età?");
			eta = int.Parse(Console.ReadLine());

			//CALCOLO //essendoci solo un comando, non c'è bisogno delle graffe SOLO IN QUESTO CASO//
			if (professione == "carabiniere")
			{
				prezzoBiglietto = 112;
			}
			if (professione == "medico" && residenza == "milano")
				prezzoBiglietto = 8;
			if (professione == "insegnante" || professione == "militare")
				prezzoBiglietto = 7;
			if (eta < 12 || eta >= 65)
				prezzoBiglietto = 5; 

			//Output 
			Console.WriteLine("Caro cliente il prezzo del tuo biglietto è " + prezzoBiglietto + " euro");
			Console.ReadKey();
 		}
	}
}
