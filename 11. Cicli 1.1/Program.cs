using System;

namespace _11._Cicli_1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE

			string nome;
			string professione;
			string riepilogo = "";

			int eta;
			int sommaPrezzi = 0;
			int numeroPersone = 0;


			do
			{   //Il prezzo lo inizializzo nel ciclo in questa maniera ad ogni persona
				//il prezzo di base ritorna ad essere 10 e non rimane salvato quello del nuovo biglietto
				int prezzo = 10;

				//INPUT
				Console.WriteLine("Come ti chiami?");
				nome = Console.ReadLine();

				Console.WriteLine("Quanti anni hai?");
				eta = int.Parse(Console.ReadLine());

				Console.WriteLine("Qual è la tua professione?");
				professione = Console.ReadLine().ToLower();

				//CALCOLO
				if (eta < 12 || eta > 60)
					prezzo = 6;
				if (professione == "medico")
					prezzo = 2;

				//Aggiungo al totale il prezzo di questo biglietto
				sommaPrezzi += prezzo;
				riepilogo += nome + " spende" + prezzo + "\n";
				numeroPersone++; //il ++ indica un aumento di 1 unità
				//OUTPUT
				Console.WriteLine("Caro " + nome + " il tuo biglietto costa " + prezzo);
				Console.WriteLine("Deve entrare ancora qualcuno? s/n");

			} while (Console.ReadLine() == "s");

			Console.WriteLine(riepilogo);
			Console.WriteLine("\nIl totale speso è " + sommaPrezzi);
			Console.WriteLine("Un biglietto è costato in media " + 
								(sommaPrezzi / numeroPersone));

			Console.ReadKey();
		}
	}
}
