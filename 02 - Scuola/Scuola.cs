using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _02___Scuola
{
	class Scuola
	{
		private Persona[] persone;
		public Persona[] Persone { get => persone; }

		public Scuola(string path)
		{
			if (File.Exists(path))
			{
				string[] righe = File.ReadAllLines(path);

				persone = new Persona[righe.Length];

				for (int i = 0; i < righe.Length; i++)
				{

					//Prendiamo una singola riga dal vettore -> persona del vettore persona
					string[] riga = righe[i].Split(",");

					switch (riga[0].ToLower())
					{
						case "ata":
							persone[i] = new Ata(
													riga[1], //cognome
													riga[2], //dob
													riga[3], //sesso
													riga[4], //residenza
													riga[5], //ruolo	
													riga[6], //dataassunto											
													riga[7].ToLower() == "si" //parttime
												);
							break;
						case "insegnante":
							persone[i] = new Insegnante(
													riga[1], //cognome
													riga[2], //dob
													riga[3], //sesso
													riga[4], //residenza
													riga[5], //dataAssunto
													int.Parse(riga[6]), //nclassi
													riga[7].Split("-") //materieinsegnate
														);
							break;
						case "studente":
							persone[i] = new Studente(
													riga[1], //cognome
													riga[2], //dob
													riga[3], //sesso
													riga[4], //residenza
													int.Parse(riga[5]), //classe
													int.Parse(riga[6]), //votoIta
													int.Parse(riga[7]), //votoMate
													int.Parse(riga[8]), //votoSto
													int.Parse(riga[9])  //votoIng
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
		public string ElencoPersone()
		{
			string ris = "";



			for (int i = 0; i < persone.Length; i++)
				ris += persone[i].Scheda();

			return ris;

		}

		public string ElencoInsegnanti()
		{
			string ris = "";

			foreach (Persona p in persone) //ripeto il blocco di codice per ogni persona p all'interno del vettore
			{
				if (p is Insegnante)
				{
					ris += p.Scheda();
				}
			}

			return ris;
		}

		public double SommaStipendi()
		{
			double sommaStipendi = 0;
			double n = 0;

			foreach (Persona p in persone)
			{
				if (p is Insegnante ins)
				{
					sommaStipendi += ins.Stipendio();
					n++;
				}
			}


			return sommaStipendi / n;
		}


		public double StipendioMedioPersonale(string ruolo)
		{
			double somma = 0;
			double n = 0;

			foreach (Persona p in persone)
			{
				if (p is Personale pers && pers.Ruolo.ToLower() == ruolo)
				{
					somma += pers.Stipendio();
					n++;
				}
			}

			return somma / n;
		}

		public int ContaBocciati()
		{
			int contaBocciati = 0;

			foreach (Persona p in persone)
			{
				if (p is Studente stud && stud.Promosso() == false)
				{
					contaBocciati++;
				}
			}

			return contaBocciati;
		}

		public double MediaClassi() // fare la media del campo "nClassi" dei vari insegnanti
		{
			double sommaclassi = 0;
			double n = 0;

			foreach (Persona p in persone)
			{
				if (p is Insegnante ins)
				{
					sommaclassi += ins.NClassi;
					n++;
				}
			}

			return sommaclassi / n;
		}

		public int Analfabeti() // stampare il numero di studenti che hanno italiano e inglese insufficienti
		{
			int contaAnalfabeti = 0;

			foreach (Persona p in persone)
			{
				if (p is Studente stud && stud.VotoIta < 6 && stud.VotoIng < 6)
					contaAnalfabeti++;
			}
			return contaAnalfabeti;
		}

		public double StipendioMedioPartTime()
		{
			double somma = 0;
			double n = 0;

			foreach (Persona p in persone)
			{
				if (p is Ata ata && ata.PartTime)
					somma += ata.Stipendio();
				n++;
			}


			return somma / n;
		}

		public double StipendioPiuAlto()
		{
			double max = double.MinValue;

			foreach (Persona p in persone)
			{
				if (p is Personale pers && pers.Stipendio() > max)
					max = pers.Stipendio();

				
			}

			return max;
		}

		public int TotaleInsufficienze(string materia) //contare quanti voti insufficienti sono stati dati nella materia passata come parametro
		{
			int contavoti = 0;

			foreach (Persona p in persone)
			{
				if (p is Studente stud)
				{
					switch (materia)
					{
						case "Mate":
							if (stud.VotoMat < 6)
								contavoti++;
							break;

						case "Ita":
							if (stud.VotoIta < 6)
								contavoti++;
							break;
						case "Storia":
							if (stud.VotoSto < 6)
								contavoti++;
							break;
						case "Ing":
							if (stud.VotoIng < 6)
								contavoti++;
							break;
						default:
							break;
					}

				}



			}
			return contavoti;
		}
		public int ContaItaliano() //stampare quanti integnanti hanno "italiano" tra le materie insegnate
		{
			int ris = 0;

			foreach (Persona p in persone)
			{
				if (p is Insegnante ins)

					for (int i = 0; i < ins.MaterieInsegnate.Length; i++)
					{
						if (ins.MaterieInsegnate[i] == "italiano")
						{
							ris++;
						}
					}

			}
			return ris;
		}
		public int ContaUmanistici() //insegnanti hanno "italiano", "latino" o "greco" tra le materie insegnate
		{
			int ris = 0;

			foreach (Persona p in persone)
			{
				if (p is Insegnante ins)

					for (int i = 0; i < ins.MaterieInsegnate.Length; i++)
					{
						if (ins.MaterieInsegnate[i] == "italiano" ||
							ins.MaterieInsegnate[i] == "latino" ||
							ins.MaterieInsegnate[i] == "greco")
						{
							ris++;
						}
					}

			}
			return ris;
		}
		public int ContaMateria(string m) //stampare quanti insegnanti insegnano la materia m
        {
			int conta = 0;

            foreach (Persona p in persone)
            {
				if(p is Insegnante ins)
                    for (int i = 0; i < ins.MaterieInsegnate.Length; i++)
                    {
                        if (ins.MaterieInsegnate[i] == m)
						{
							conta++;
                        }
                    }
            }


			return conta;
        }
		public int ContaMaterie(string[] m) //stampare quanti insegnanti insegnano
                                            //TUTTE le materie contenute nel vettore m
        {
			int conta = 0;

            foreach (Persona per in persone)
            {
                if (per is Insegnante ins)
                {
                    if (ins.Insegna(m))
                    {
						conta++;
                    }
                }
            }
			return conta;
        }




	}
}
