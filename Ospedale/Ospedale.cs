using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ospedale
{
	class Ospedale
	{
		public Persona[] persone;

		public Ospedale(string path)
		{
			if (File.Exists(path))
			{
				string[] righe = File.ReadAllLines(path); //legge in una soluzione tutte le righe

				this.persone = new Persona[righe.Length]; //inizializziamo vettore

				//Cicliamo una ad una tutte le righe
				for (int i = 0; i < righe.Length; i++)
				{
					//lavoro sulla singola riga
					string[] riga = righe[i].Split(",");

					//   0        1       2     3          4        5       6         
					//Paziente   Pino   Pane    55    Neurologia    32      no

					//grazie a riga[0] so che oggetto devo creare
					//tutto quello che viene dopo(riga1, 2 ecc) è 
					//il parametro per creare l'oggetto
					switch (riga[0].ToLower())
					{
						case "paziente":
							this.persone[i] = new Paziente(
															riga[1],             //Nome
															riga[2],             //cognome
															int.Parse(riga[3]),  //eta
															riga[4],             //reparto
															int.Parse(riga[5]),  //giorniPrognosi
															riga[6] == "si"      //coma
														   );
							break;
						case "medico":
							this.persone[i] = new Medico(
														   riga[1],             //Nome
														   riga[2],             //cognome
														   int.Parse(riga[3]),  //eta
														   riga[4],             //reparto
														   int.Parse(riga[5])   //anniLavoro
														 );
							break;
						case "chirurgo":
							this.persone[i] = new Chirurgo(
															  riga[1],              //Nome
															  riga[2],              //cognome
															  int.Parse(riga[3]),   //eta
															  int.Parse(riga[5]),   //anniLavoro
															  int.Parse(riga[4]),   //interventi
															  int.Parse(riga[6])    //interventiRiusciti
															);
							break;
						default:
							Console.WriteLine($"La diocane di riga {i + 1} è sbagliata, chissà...");
							break;




					}



				}
			}
			else
			{
				Console.WriteLine("C'è tempo e luogo per ogni cosa, ma non ora. " + path);
				Console.ReadKey();
				//L'istruzione seguente termina con l'errore 0 il programma
				//l'errore 69 (° ͜ʖ ͡°)  è un numero che ho messo a caso
				Environment.Exit(69);

			}

		}

		public string ElencoPersone()
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				ris += persone[i].Scheda() + "\n";
			}

			return ris;

		}
		public string ElencoPazienti()
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Paziente) //Questa istruzione mi controlla il tipo concreto
					ris += persone[i].Scheda() + "\n";
			}

			return ris;

		}

		public double EtaMediaChirurghi()
		{
			double sommaeta = 0;
			double numerochirurghi = 0;
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Chirurgo)
				{
					numerochirurghi++;
					sommaeta += persone[i].eta;


				}


			}
			if (numerochirurghi == 0)
				return 0;
			else
				return sommaeta / numerochirurghi;



		}


		public double EtaMediaMedici()
		{
			double sommaeta = 0;
			double numerochirurghi = 0;
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico && !(persone[i] is Chirurgo))
				{
					sommaeta += persone[i].eta;
					numerochirurghi++;


				}


			}
			if (numerochirurghi == 0)
				return 0;
			else
				return sommaeta / numerochirurghi;

		}

		//Sommare gli stipendi di medici e chirurghi
		public double SommaStipendi()
		{
			double sommastipendi = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico)
				{
					//Attraverso il casting andiamo a modificare il tipo formalle
					//della variabile persone[i] da persona a medico SOLO IN QUESTO FOR.
					sommastipendi += ((Medico)persone[i]).Stipendio();

					//il casting viene definito casting sicuro
					//perché prima di castare mi sono accertato tramite l'if che
					//persone[i] fosse Medico
				}
			}


			return sommastipendi;
		}

		public int NumeroInterventiSbagliati()
		{
			int ris = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Chirurgo c)
				{
					//Per tutt il blocco di cocdice if avrò a disposizione la variabile "c" 
					//che indica la mia persona in posizione [i] castata a Chirurgo
					ris += c.interventi - c.interventiRiusciti;

				}
			}

			return ris;
		}
		//
		public string ElencoComa() //: 1 stampare le schede dei pazienti in coma
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Paziente p)

					if (p.coma)
					{	
						//Nel momento in cui chiamo metodo, 2 fasi:
						//1. la fase di compilazione dove richiamiamo solo metodi al tipo formale
						//2. la fase di esecuzione nella quale il metodo si attiva sul tipo concreto
						ris += p.Scheda();
					}
			}

			return ris;
		}

		public string ElencoProntoSoccorso() //: 2 stampare le schede di chi lavora in pronto soccorso
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m)
				{
					if (m.reparto == "prontosoccorso")
						ris += m.Scheda();
				}
			}

			return ris;
		}
		public string ElencoMedici(string psichiatria)  //: 3 stampare le schede di chi lavora nel reparto r
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m)
				{
					if (m.reparto == psichiatria)
						ris += m.Scheda();

				}
			}

			return ris;
		}

		public double StipendioMedio(double stipendio) //:4 stampare lo stipendio medio totale(medici e chirurghi compresi)
		{
			double sommastipendi = 0;
			double n = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m)
				{

					sommastipendi += m.Stipendio();
					n++;
				}
			}



			return sommastipendi / n;
		}
		public double StipendioMedioPsichiatria(string psichiatria) //:5 stampare lo stipendio medio di coloro che lavorano nel reparto r
		{
			double sommastipendi = 0;
			double n = 0;
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.reparto == psichiatria)
				{
					sommastipendi += m.Stipendio();
					n++;
				}
			}
			return sommastipendi / n;
		}
		public double StipendioMedioEtaPs(string psichiatria) //:6 stampare lo stipendio medio di coloro che lavorano nel reparto r
		{
			double sommastipendi = 0;
			double n = 0;



			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.reparto == psichiatria && m.eta > 25 && m.eta < 69)
				{
					sommastipendi += m.Stipendio();
					n++;
				}
			}
			return sommastipendi / n;
		}
		public double InterventiSbagliatiMedi()    //: 7 stampare la media di interventi sbagliati
		{
			int interventisbagliati = 0;
			int n = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Chirurgo c)
				{
					interventisbagliati += c.InterventiSbagliati();
					n++;
				}
			}



			return interventisbagliati / n;
		}

		public double SpesaOspedale() //: 8 stampare la somma degli stipendi di tutti i medici sommata al costo di tutti i pazienti
		{
			double sommacostopazienti = 0;
			double sommastipendi = SommaStipendi();

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Paziente p)
					sommacostopazienti += p.Costo();
			}

			return sommacostopazienti + sommastipendi;
		}

		public double AnnoNascitaMedio() //: 9 stampare l'anno di nascita medio di tutte le persone
		{
			int ris = 0;
			int n = 0;
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Persona p)
				{
					ris += p.AnnoNascita();
					n++;
				}
			}


			return ris / n;
		}

		public bool Ricco(string n) //: 10 metodo che ritorna true se c'è un medico o un chirurgo il cui nome è uguale a n e che ha uno stipendio > 2200€
		{
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.nome == "n" && m.Stipendio() > 2200)
					n += m.nome;
			}
			return true;
		}

		public double StipendioChirurghiMedio() //: 11 stampare le schede dei medici(chirurghi compresi) il cui stipendio è maggiore dello stipendio medio dei chirurghi
		{
			double somma = 0;
			int n = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Chirurgo c)
					somma += c.Stipendio();
				n++;

			}

			return somma / n;
		}

		public string ElencoSopraMedia()
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.Stipendio() > StipendioChirurghiMedio())
					ris += m.Scheda();
			}

			return ris;
		}

		public double StipendioMaggiore() //: 12 stampare lo stipendio maggiore
		{
			double max = double.MinValue;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.Stipendio() == max)
					max += m.Stipendio();



			}

			return max;
		}
		public double StipendioMinore() //: 13 stampare lo stipendio minore
		{
			double minValue = double.MaxValue;
			bool primo = true;
			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m)
				{
					if (primo || m.Stipendio() < minValue)
					{
						minValue += m.Stipendio();
						primo = false;
					}
				}
			}

			return minValue;
		}

		public string ConciatoPeggio() //: 14 stampare la scheda del paziente che ha la prognosi di giorni maggiore
		{
			string messomale = "";
			double max = 0;

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Paziente p)
					if (p.giorniPrognosi > max)
						messomale = p.Scheda();
					else if (p.giorniPrognosi == max)
						messomale += p.Scheda();

			}

			return messomale;
		}

		public string MediciGiovani() //: 15 stampare la scheda dei medici(chirurghi compresi) che hanno iniziato a lavorare a 27 anni o prima
		{
			string ris = "";

			for (int i = 0; i < persone.Length; i++)
			{
				if (persone[i] is Medico m && m.eta - m.anniLavoro <= 27)
					ris += m.Scheda();
			}

			return ris;
		}































	}
	
}
