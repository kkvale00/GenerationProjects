using System;

namespace Vecio2
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE
			int prezzoBiglietto = 6;
			int eta;
			string professione;
			string residenza;
			string nome;

			//INPUT
			Console.WriteLine("Qual è il tuo nome?");
			nome = Console.ReadLine();

			Console.WriteLine("Qual è la tua professione?");
			professione = Console.ReadLine().ToLower();

			Console.WriteLine("Qual è la tua residenza?");
			residenza = Console.ReadLine().ToLower();

			Console.WriteLine("Qual è la tua età?");
			eta = int.Parse(Console.ReadLine());

			//Calcolo
			if (eta < 6 || residenza == "vecio")
				prezzoBiglietto = 0;
			else if (eta > 68)
				prezzoBiglietto -= prezzoBiglietto * 80 / 100;
			else if (professione == "studente" && eta >= 6 && eta <= 18)
				prezzoBiglietto -= prezzoBiglietto * 50 / 100;
			else if (professione == "studente" && eta >= 19 && eta <= 29)
				prezzoBiglietto -= prezzoBiglietto * 30 / 100;
			else if (professione == "poliziotto" || professione == "militare")
				prezzoBiglietto = 2;
			else if (professione == "medico")
				prezzoBiglietto = 3;
			else
				prezzoBiglietto = 6;


			//Output
			Console.WriteLine("Caro cliente, caccia " + prezzoBiglietto + " euro");
			Console.ReadKey();



		}
	}
}
