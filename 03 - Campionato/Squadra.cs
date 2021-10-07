using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _03___Campionato
{
	class Aggregatore_Squadra
	{
		private Persona[] persone;
	

		public Aggregatore_Squadra(string path)
		{
			if(File.Exists(path))
			{
				string[] righe = File.ReadAllLines(path);

				persone = new Persona[righe.Length];

				for (int i = 0; i < righe.Length; i++)
				{

					string[] riga = righe[i].Split(",");

					switch (riga[0].ToLower())
					{
						case "giocatore":
							persone[i] = new Giocatore (
														riga[1],
														riga[2],
														int.Parse(riga[3]),
														riga[4],
														riga[5],
														int.Parse(riga[6]),
														int.Parse(riga[7]),
														int.Parse(riga[8]),
														bool.Parse(riga[9]),
														int.Parse(riga[10])
														);
							break;

						case "allenatore":
							persone[i] = new Allenatore
												(
													riga[1],
													riga[2],
													int.Parse(riga[3]),
													riga[4],
													riga[5].Split("-"),
													int.Parse(riga[6]),
													int.Parse(riga[7])
												);
							break;
						default:
							Console.WriteLine("cristo di un dio guarda la riga " + (i + 1));
							break;
					}
					
				}
			}
			else
			{
				Console.WriteLine("C'è momento e luogo per ogni cosa, ma non ora");
				Console.ReadKey();

				//Se nn esiste, chiudo il progrmma
				Environment.Exit(0);
			}
		}

		//La lista di tutte le squadre senza ripetizioni presenti
		public string ListaSquadre()
        {
			string ris = "";

			foreach (Persona p in persone)
			{
				if (p is Giocatore gio)
				{
					//controllo che non ci sia gia' la squadra
					if (!ris.Contains(gio.Squadra)) 
						ris += gio.Squadra.ToLower() + ">\n";
				}
            }

			return ris;
        }

		public string ListaGiocatori() //-> Ritorna la scheda di tutti i giocatori
        {
			string ris = "";

			foreach (Persona p in persone)
			{
				if (p is Giocatore gio)
					ris += $"{gio.Nome} +, {gio.Cognome} +, {gio.Squadra}";
					//sei un tossico, voleva la scheda
					// ris += g.Scheda();

			}

			return ris;
		}

		//Ritorna la scheda di tutti i giocatori della squadra passata come parametro

		public string ListaGiocatori(String squadra)
        {
			string ris = "";

            foreach (Persona p in persone)
            {
				if (p is Giocatore gio && gio.Squadra == squadra)
					ris += $"{gio.Nome} +, {gio.Cognome} +, {squadra}";
					//sei un tossico, voleva la scheda
					// ris += g.Scheda();

			}

			return ris;
        }

		//-> Ritorna la scheda di tutti gli allenatori
		public string ListaAllenatori() //-> Ritorna la scheda di tutti gli allenatori
        {
			string ris = "";

			foreach (Persona p in persone)
			{
				if (p is Allenatore all)
					ris += $"{all.Nome} +, {all.Cognome}";

			}

			return ris;
		}
		
		// -> Ritorna la scheda di tutti gli allenatori attuali della squadra passata come parametro
		public string ListaAllenatori(String squadra)
        {
			string ris = "";

			foreach (Persona p in persone)
			{
				if (p is Allenatore all && all.SquadraAttuale == squadra)
					ris += $"{all.Nome} +, {all.Cognome} +, {squadra}";

			}

			return ris;
		}


		//Ritorna il giocatore che ha vinto più partite in assoluto

		public Persona MaxVincite()
        {
			Persona ris = null;
			int max = 0;
			int npartite = 0;

            foreach (Persona p in persone)
            {
				if(p is Giocatore gio)
                {
					for (int i = 0; i < persone.Length; i++)
					{
						npartite += gio.PartiteVinte;
					}
					if (npartite > max)
                    {
						max = npartite;
						ris = gio;
                    }
				}
            }

            return ris;
        }

		//Ritorna il giocatore che ha il nome passato come parametro
		public Persona Cerca(String nome)
        {
			Persona ris = null;

			
            foreach (Persona p in persone)
            {
				if (p is Giocatore gio)
					if(p.Nome == nome)
						ris = p;
            }

			return ris;
        }

		//Restituisce il numero di tutti gli allenatori che hanno allenato
		//un numero di squadre maggiore della metà degli anniEsperienza;

		public int Mercenari()
        {
			int ris = 0;
			

            foreach (Persona p in persone)
            {
				if (p is Allenatore all && all.Mercenario())
					ris++;
					
            }
			return ris;
        }

		//Ritorna true se la squadra passata come parametro
		//contiene almeno 10 giocatori e un allenatore	

		public bool SquadraValida(String squadra)
        {
			int ngiocatori = 0;
			int nallenatori = 0;

			foreach (Persona p in persone)
			{
				if (p is Giocatore gio && gio.Squadra == squadra)
					ngiocatori++;
				else if (p is Allenatore a && a.SquadraAttuale == squadra)
					nallenatori++;

			}


			return ngiocatori >= 10 && nallenatori >= 1;
        }

		public string SquadreFake()
        {
			string ris = "";

            foreach (Persona p in persone)
            {
				string squadraDacontrollare = "";

				if (p is Giocatore gio)
					squadraDacontrollare = gio.Squadra;

				else if (p is Allenatore all)
					squadraDacontrollare = all.SquadraAttuale;

				if (!SquadraValida(squadraDacontrollare))
					ris += squadraDacontrollare + " ";
            }

			return ris;
        }















	}//fine classe
}
