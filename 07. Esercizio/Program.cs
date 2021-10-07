using System;

namespace _07._Esercizio
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

			//CALCOLO
			if (professione == "medico" && eta <= 68)
				prezzoBiglietto = 3;

			if ((professione == "poliziotto" || professione == "militare") && eta <= 68)
				prezzoBiglietto = 2;

			if (eta > 68)
				prezzoBiglietto = prezzoBiglietto - (prezzoBiglietto * 80 / 100);

			if (professione == "studente" && eta >= 6 && eta <= 18)
				prezzoBiglietto = prezzoBiglietto - (prezzoBiglietto * 50 / 100);

			if (professione == "studente" && eta >= 19 && eta <= 29)
				prezzoBiglietto -= prezzoBiglietto * 30 / 100; //puoi anche mettere il "-" prima dell'uguale per non ripeterlo dopo.

			if (residenza == "vezio" || (eta < 6))
				prezzoBiglietto = 0;

			//Output 
			Console.WriteLine(
							   "====================\n" +
							   "Nome: " + nome + "\n" +
							   "Età: " + eta + "\n" +
							   "Residenza: " + residenza + "\n" +
							   "Professione: " + professione + "\n" +
							   "====================\n"
							   );
			Console.WriteLine("Caro cliente il prezzo del suo biglietto è " + prezzoBiglietto + " euro");
			Console.ReadKey();








		}
 }   }
