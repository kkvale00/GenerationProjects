using System;

namespace _08._Vecio3
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE
			double prezzoBiglietto = 6;
			int eta;
			string professione;
			string residenza;
			string nome;

			//INPUT
			Console.WriteLine("Qual è il tuo nome?");
			nome = Console.ReadLine();

			Console.WriteLine("\nQual è la tua professione?");
			professione = Console.ReadLine().ToLower();

			Console.WriteLine("\nQual è la tua residenza?");
			residenza = Console.ReadLine().ToLower();

			Console.WriteLine("\nQual è la tua età?");
			eta = int.Parse(Console.ReadLine());

			//CALCOLO TERNARIO: ossia un if su una sola riga
			// condizione ? valoreSEvero : valoreSEfalso
			
			//SCONTO FORZE DELL'ORDINE Se l'utente come professione fa il polizziotto o il militare paga 2€
			//Se l'utente come professione fa il medico paga 3€
			prezzoBiglietto = (professione == "poliziotto" || professione == "militare") && eta < 68 ? 2 : prezzoBiglietto;
			prezzoBiglietto = (professione == "medico") && eta < 68 ? 3 : prezzoBiglietto;

			//SCONTO STUDENTI Se l'utente ha tra i 6 e i 18 anni e come professione è uno studente,
			//paga il 50% in meno Se l'utente ha tra i 19 e i 29 anni e come professione è uno studente, paga il 30% in meno
			prezzoBiglietto -= (eta >= 6 && eta <= 18 && professione == "studente") ? prezzoBiglietto * 50 / 100 : 0;
			prezzoBiglietto -= (eta >= 19 && eta <= 29 && professione == "studente") ? prezzoBiglietto * 30 / 100 : 0;

			//SCONTO PENSIONATI Se l'utente ha più di 68 anni ha uno sconto dell'80%
			prezzoBiglietto -= (eta > 68) ? prezzoBiglietto * 80 / 100 : 0;

			//SCONTO BIMBI Se l'utente ha meno di 6 anni o risiede a "Vecio" entra gratis
			prezzoBiglietto = (eta < 6 || residenza == "vecio") ? 0 : prezzoBiglietto;




			//Per capire lo sconto applicato
			string scontoApplicato;

			if (prezzoBiglietto == 0)
			{
				if (eta < 6)
					scontoApplicato = "SCONTO BIMBI";
				else
					scontoApplicato = "SCONTO RESIDENZA";
			}
			else if (prezzoBiglietto == 6 * 20 / 100)
				scontoApplicato = "SCONTO PENSIONATO";

			else if (prezzoBiglietto == 3)
				scontoApplicato = "SCONTO MEDICI";

			else if (prezzoBiglietto == 2)
				scontoApplicato = "SCONTO MILITARI O POLIZIOTTI";

			else if ((prezzoBiglietto == 6 * 70 / 100 || prezzoBiglietto == 6 * 50 / 100) && professione == "studente")
				scontoApplicato = "SCONTO STUDENTI";

			else
				scontoApplicato = "...scherzavo a te no";


			Console.WriteLine("\nCarissimo cliente sgancia " + prezzoBiglietto + " euro" +
							  "\n\nPer lei è stato eccezionalmente usato lo " + scontoApplicato + 
							  ".\n\nBuona Visione!"
							  );
			Console.ReadKey();




		}


	}
}
