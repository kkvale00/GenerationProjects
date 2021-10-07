using System;
using System.IO;

namespace _14._Libreria
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE\\
			string titolo;
			string autore;
			string genere;
			int npagine;
			StreamReader file;
			string riga;
			string scheda = "";

			double prezzo;

			//INPUT\\
			try
			{
				file = new StreamReader(@"C:\Users\kkvale\source\repos\PrimaSettimana\14. Libreria\Libri.txt");
				
				while((riga = file.ReadLine()) != null)
                {
					titolo = riga;
					autore = file.ReadLine();
					genere = file.ReadLine();
					npagine = int.Parse(file.ReadLine());

					prezzo = 5;

					switch(autore.ToLower())
                    {
						case "king": 
							prezzo += prezzo * 50 / 100;
							break;
						case "tolkien": 
							prezzo += prezzo * 10 / 100;
							break;
						case "carrisi":
							prezzo += prezzo * 5 / 100;
							break;
						default:
							prezzo += 5;
							break;
                    }


					if (npagine > 700)
						prezzo += prezzo * 20 / 100;
					else
						prezzo -= prezzo * 10 / 100;



					scheda +=	"> Titolo: "   + titolo	    +
								"\n> Autore: " + autore     +
								"\n> Genere: " + genere     +
								"\n> Pagine: " + npagine    +
								"\n> Prezzo: " + prezzo     +
								"\n======================\n";
                }//fine ciclo while
			}
			catch(FileNotFoundException)
			{
				Console.WriteLine("Percorso sbagliato.");
			}
			catch(Exception)
            {
				Console.WriteLine("Il percorso era giusto, ma qualcosa è andato storto");
            }
			Console.WriteLine(scheda + "\n\nGrazie e Arrivederci!");
		}//FINE MAIN\\
	}
}
