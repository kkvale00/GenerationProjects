using System;

namespace Concessionario
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE 1.1\\
			string marca;
			string modello;
			string colore;
			int nposti;
			int nporte;
			bool automatica;
			double prezzo;

			//DICHIARAZIONE 1.2\\

			double sommaPrezzi = 0;
			int nauto = 0;
			int nmanuali = 0;
			int nautoblu5porte = 0;
			int nFord = 0;
			double sommaFord = 0;
			int nrosse4porte = 0;


			//INPUT\\
			do
			{

				Console.WriteLine("Inserisci la marca");
				marca = Console.ReadLine().ToLower();
				Console.WriteLine("Inserisci il modello");
				modello = Console.ReadLine().ToLower();
				Console.WriteLine("Inserisci il colore");
				colore = Console.ReadLine().ToLower();
				Console.WriteLine("Inserisci il numero dei posti");
				nposti = int.Parse(Console.ReadLine());
				Console.WriteLine("Inserisci il numero delle porte");
				nporte = int.Parse(Console.ReadLine());
				Console.WriteLine("Vuoi davvero il cambio automatico? pussy..");
				automatica = Console.ReadLine().ToLower() == "s";

				prezzo = 4000;

				//CALCOLO\\

				switch (marca)
				{
					case "fiat":
						prezzo += 2000;
						break;
					case "dacia":
					case "ford":
					case "renault":
						prezzo += 4000;
						break;
					case "lamborghini":
						prezzo += 70000;
						break;
					default:
						prezzo += 7000;
						break;
				}

				prezzo += nposti * 1200;

				if (nposti == 5)
					prezzo += 4000 * 2.5 / 100;
				else nposti = 2;
				prezzo += 9000;
				if (automatica == true)
					prezzo += prezzo * 5 / 100;

				switch (colore)
				{
					case "blu":
					case "rosso":
						prezzo += prezzo * 1.4 / 100;
						break;
					case "bianco":
					case "nero":
						prezzo += prezzo * 3.5 / 100;
						break;
					case "verde":
					case "giallo":
						prezzo += prezzo * 6 / 100;
						break;
				}




				//OUTPUT\\
				Console.WriteLine("Gentile cliente, ecco il risultato della sua configurazione, il totale parziale è " + prezzo + " euro");


				Console.WriteLine("=== RIEPILOGO ===" +
								"\n> Marca: " + marca.ToUpper() +
								"\n> Modello: " + modello.ToUpper() +
								"\n> Posti: " + nposti +
								"\n> Porte: " + nporte +
								"\n> Automatica " + (automatica ? "Sì" : "No") +
								"\n> Colore:" + colore +
								"\n>  Prezzo: " + prezzo +
								"\n===========================\n");

				//nel nome del padre figlio e spirito santo\\
				sommaPrezzi += prezzo;
				nauto++;



				if (marca == "ford")
				{
					sommaFord += prezzo;
					nFord++;
				}

				if (automatica == false)
					nmanuali++;

				if (colore == "rosso" && nporte == 4)
					nrosse4porte++;

				if (colore == "blu" && nporte == 5)
					nautoblu5porte++;

				Console.WriteLine("Desidera provare altre config? s/n");

			} while (Console.ReadLine().ToLower() == "s");

			Console.WriteLine("\n>Un auto è costata in media " +
								(sommaPrezzi / nauto));
			Console.WriteLine("\n>Una ford è costata in media " +
								(sommaFord / nFord));
			Console.WriteLine("\n>Hai comprato in totale " + nautoblu5porte + " autoblu con 5 porte");
			Console.WriteLine("\n>Il totale delle manuali è " + nmanuali);
			Console.WriteLine("\n>Il totale delle rosse 4 porte è " + nrosse4porte);
			Console.WriteLine("\n\n>Il totale finale delle auto è " + sommaPrezzi);
		}

	}
}
	