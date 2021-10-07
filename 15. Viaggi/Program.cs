using System;
using System.IO;

namespace _15._Viaggi
{
	class Program
	{
		/*Creare un programma che gestisca un agenzia viaggi.
	Formattare un file con le seguenti informazioni: destinazione, mezzo di trasporto, giorni di vacanza, costo giornaliero,
	numero persone.
	Creare un programma che acquisite le informazioni dal file sia in grado di calcolare i prezzi dei singoli viaggi.
	Calcolo del prezzo:
	> Prezzo base 100;
	> se la destinazione è Dubai o Tokyo aggiungo 200, se è Dublino o Londra aggiungo 150, 
		se è New York o Miami aggiungo 300. In tutti gli altri casi aggiungo 50
	> se il mezzo di trasporto è aereo o traghetto aggiungo 500, se è treno aggiungo 200, 
		se è automobile o autobus aggiungo 100. In tutti gli altri casi aggiungo 1000
	> se le persone sono più di 5 scontare il viaggio del 5%, se invece sono più di 10 scontare il viaggio del 10%.*/
		static void Main(string[] args)
		{
			string destinazione = "";
			string mezzotrasporto = "";
			int giornivacanza;
			int numpersone;
			double costogiorno;
			double prezzo = 0;
			StreamReader file = null;
			string riga;
			string listaDestinazione = "";
			string listaMezzitrasporto = "";
			
			string riepilogo = "";
			double numviaggiaereo = 0;
			double sommaPrezziAereo = 0;
			double numviaggiDubai = 0;
			double sommacostoDubai = 0;

			double minprezzo = double.MaxValue;
			double maxPrezzo = 0;
			string listaviaggieconomici = "";
			string listaviaggicostosti = "";
			string riepilogoviaggio = "";


			//INPUT
			try
			{
				file = new StreamReader(@"C:\Users\kkvale\source\repos\PrimaSettimana\15. Viaggi\Destinazioni.txt");
				

				while ((riga = file.ReadLine()) != null)
				{
					destinazione = riga;
					mezzotrasporto = file.ReadLine();
					giornivacanza = int.Parse(file.ReadLine());
					costogiorno = int.Parse(file.ReadLine());
					numpersone = int.Parse(file.ReadLine());

					prezzo = 100;

					switch(destinazione.ToLower())
					{
						case "Dubai":
							{
								numviaggiDubai++;
								prezzo += 200;
							}
							break;
						case "Tokyo":
							prezzo += 200;
							break;
						case "Dublino":
						case "Londra":
							prezzo += 150;
							break;
						case "New York":
						case "Miami":
							prezzo += 300;
							break;
						default:
							prezzo += 50;
							break;
					}

					switch (mezzotrasporto.ToLower())
					{
						case "automobile":
						case "autobus":
							prezzo += 100;
							break;
						case "aereo":
							{
								numviaggiaereo ++;
								prezzo += 500;
							}
							break;
						case "traghetto":
							prezzo += 500;
							break;
						default:
							prezzo += 1000;
							break;
					}

					prezzo += costogiorno * numpersone;

					if (numpersone >= 5 && numpersone < 10)
						prezzo -= prezzo * 0.05;
					else if (numpersone >= 10)
						prezzo -= prezzo * 0.1;
					
					if (mezzotrasporto == "aereo")
						sommaPrezziAereo += prezzo;

					if (destinazione == "Dubai")
						sommacostoDubai += prezzo;
					





					riepilogoviaggio += "> Destinazione: " + destinazione +
								"\n> Mezzo: " + mezzotrasporto +
								"\n> Giorni: " + giornivacanza +
								"\n> costogiorno: " + costogiorno +
								"\n> numpersone: " + numpersone +
								"\n> Prezzo: " + prezzo +
								"\n======================\n";
					riepilogo += riepilogoviaggio;
				}
				
				if (!listaDestinazione.Contains(destinazione))
                {
					listaDestinazione += "\n> " + destinazione;
                }

				if (!listaMezzitrasporto.Contains(mezzotrasporto))
                {
					listaMezzitrasporto += "\n>" + mezzotrasporto;
                }

				if (prezzo > maxPrezzo)
				{
					maxPrezzo = prezzo;
					listaviaggicostosti = riepilogoviaggio;
				}
				else if (prezzo == maxPrezzo)
					listaviaggicostosti += riepilogoviaggio;
				if (prezzo < minprezzo)
				{
					minprezzo = prezzo;
					listaviaggieconomici = riepilogoviaggio;
				}
				else if (prezzo == minprezzo)
					listaviaggieconomici += riepilogoviaggio;
					



			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("Percorso sbagliato.");
			}
			catch (Exception)
			{
				Console.WriteLine("Il percorso era giusto, ma qualcosa è andato storto");
			}
			Console.WriteLine(riepilogo + "\n> prezzimediAereo: " + sommaPrezziAereo / numviaggiaereo +
								  "\n> costomedioDubai: " + sommacostoDubai / numviaggiDubai + "\n\nGrazie e Arrivederci!");
		}
	}
}
