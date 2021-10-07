using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _05___Azienda
{
	class Azienda
	{
		public List<Persona> persone;


		public Azienda(string path)
		{
			persone = new List<Persona>();

			if (File.Exists(path))
			{
				string[] righe = File.ReadAllLines(path);

				for (int i = 0; i < righe.Length; i++)
				{
					string[] riga = righe[i].Split(",");

					switch (riga[0].ToLower())
					{
						case "dirigente":
							persone.Add(new Dirigente
														(
															riga[1],
															riga[2],
															riga[3],
															riga[4],
															int.Parse(riga[5]),
															riga[6].Split("-")
														)
										);
							break;
						case "dipendente":
							persone.Add(new Dipendente
														(
															riga[1],
															riga[2],
															riga[3],
															riga[4],
															riga[5],
															riga[6] == "si",
															int.Parse(riga[7])
														 )
									   );
							break;
						case "dipendenteSpecializzato":
							persone.Add(new DipendenteSpecializzato
														(
															riga[1],
															riga[2],
															riga[3],
															riga[4],
															riga[5],
															int.Parse(riga[6])
														 )
									   );
							break;
						default:
							Console.WriteLine("attaccati al tram");
							break;
					}
				}
					
					
			}

		}
		
		public static string Stampa<T>(List<T> x)
		{
			string ris = "";

			for (int i = 0; i < x.Count; i++)
			{
				ris += x[i] ;
			}

			return ris;
		}


		public List<Persona> ListaDipendenti()
		{
			List<Persona> ris = new List<Persona>();

			for (int i = 0; i < persone.Count; i++)
			{
				if (persone[i] is Dipendente)
					ris.Add(persone[i]);

			}

			return ris;
		}

		public List<Persona> ListaDirigenti()
		{
			List<Persona> ris = new List<Persona>();

			for (int i = 0; i < persone.Count; i++)
			{
				if (persone[i] is Dirigente)
					ris.Add(persone[i]);

			}


			return ris;
		}

		public List<Dirigente> DirigenteRicco() //ritorna il dirigente piu ricco
		{
			List<Dirigente> ris = new List<Dirigente>();

			double max = double.MinValue;

			foreach (Persona persona in persone)
			{
				if (persona is Dirigente d)
				{
					if (d.Stipendio() > max)
					{
						max = d.Stipendio();

						ris.Clear();
						ris.Add(d);
					}
					if (d.Stipendio() == max)
					{
						ris.Add(d);
					}
				}
			}
			return ris;
		}

		public double MediaDipendente()
		{
			double somma = 0;
			int n = 0;

			foreach (Persona p in persone)
				if(p is Dipendente d)
				{
					somma += d.Stipendio();
					n++;

				}

			return somma / n;
		}

		public double MediaDipendente(string reparto)
		{
			double somma = 0;
			int n = 0;

			foreach (Persona p in persone)
				if(p is Dipendente d && d.Reparto == reparto)
				{
					somma += d.Stipendio();
					n++;
				}

			return somma / n;
		}

		//Numero di dipendenti che lavorano nello specifico reparto indicato

		public int DipendentiIn(string reparto)
		{
			int n = 0;

			foreach (Persona pers in persone)
				if (pers is Dipendente d && d.Reparto == reparto)
					n++;

			return n;
		}

		 // Ritorna le persone assunte da meno di 2 anni
		public List<Persona> NeoAssunti()
		{
			List<Persona> ris = new List<Persona>();

			foreach (Persona persona in persone)
			{
				if (persona is Dipendente d && 2021 - d.AnnoAssunzione  < 2)
					ris.Add(d);
			}

			return ris;
		}

		public int MediaDipendentiGestiti()
		{
			int somma = 0;
			int n = 0;

			foreach (Persona persona in persone)
				if (persona is Dirigente d)
					somma += d.DipendentiGestiti;
					n++;    
	
			return somma / n;
		}

		public List<string> QuantiDipendentiPerReparto()
		{
			List<string> ris = new List<string>();

			foreach (Persona persona in persone)
				if(persona is Dipendente dip)
				{
					ris.Add(DipendentiIn(dip.Reparto) + " " + dip.Reparto);
				}
					
			return ris;
		}

		// Ritorna una lista senza ripetizioni di tutti i reparti che i dirigenti gestiscono
		public List<string> Reparti()
		{
			List<string> ris = new List<string>();

			foreach (Persona p in persone)
				if(p is Dirigente dig)
				{
					for (int i = 0; i < dig.RepartiGestiti.Length; i++)
					{
						if (!ris.Contains(dig.RepartiGestiti[i])) 
							 ris.Add(dig.RepartiGestiti[i]);
					}
				}

			return ris;
		}

		public List<Persona> ElencoPersone(string reparto)
		{
			List<Persona> ris = new List<Persona>();

            foreach (Persona persona in persone)
            {
                if(persona is Dipendente dip)
                {
					if (dip.Reparto == reparto)
						ris.Add(dip);
                }

				if (persona is Dirigente dir)
                {
                    for (int i = 0; i < dir.RepartiGestiti.Length; i++)
                    {
						if (dir.RepartiGestiti[i] == reparto)
							ris.Add(dir);
					}
                }

            }
			return ris;
		}

		//: ritorna una lista contenente solo i dipendenti specializzati
		public List<DipendenteSpecializzato> ElencoDipendentiSpec()
		{
			List<DipendenteSpecializzato> ris = new List<DipendenteSpecializzato>();

			foreach (Persona persona in persone)
				if (persona is Dipendente dip)
					if (dip is DipendenteSpecializzato dipspe)
						ris.Add(dipspe);

			return ris;
        }

		//metodo che ritorna una stringa nella quale c'è scritto se l'azienda spende
		//di più per gli stipendi dei dirigenti o dei dipendenti (dipendenti + dipendenti specializzati)

		public string ChiPaghiamoDiPiu()
        {
			string ris = "";
			double sommadip = 0;
			double sommadipspe = 0;
			double sommadir = 0;



			foreach (Persona p in persone)
			{
				if (p is Dipendente dip || p is DipendenteSpecializzato dipspe)
					sommadip += p.Stipendio();

				if (p is Dirigente dir)
					sommadir += dir.Stipendio();
			}

			if ((sommadip + sommadipspe) > sommadir)
				ris = "Dipendenti";
			else
				ris = "Dirigente";



			return "L'azienda spende di piu per : " + ris;
        }

	}//fine classe




}

