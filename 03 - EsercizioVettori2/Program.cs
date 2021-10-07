using System;
using System.IO;

namespace _03___EsercizioVettori2
{
	class Program
	{
        static void Main(string[] args)
		{
			string[] nomi;
			int[] classi;
			double[] votoita;
			double[] votomate;
			double[] votosto;
			double[] votoinf;
			

			string rigafile;
			string listavoti = "";


			StreamReader file = null;

			try
			{
				file = new StreamReader(@"C:\Users\kkvale\source\repos\SecondaSettimana\03 - EsercizioVettori2\voti classi.txt");
			}
			catch(FileNotFoundException)
			{
				Console.WriteLine("Il percorso è errato.");
			}

			int dimensione = int.Parse(file.ReadLine()); //con questo comando leggo la prima riga
			int indice = 0; //inizializzo la variabile indice
			double[] media = new double[dimensione];

			//ora proseguo con inizializzare i vettori.
			nomi = new string[dimensione];
			classi = new int[dimensione];
			votoita = new double[dimensione];
			votomate = new double[dimensione];
			votosto = new double[dimensione];
			votoinf = new double[dimensione];
			media = new double[dimensione];
			
			//ora leggo cosa c'è nel file, più volte, quindi uso while
			while ((rigafile = file.ReadLine()) != null)
            {
				nomi[indice] = rigafile;
				classi[indice] = int.Parse(file.ReadLine());
				votoita[indice] = double.Parse(file.ReadLine());
				votomate[indice] = double.Parse(file.ReadLine());
				votosto[indice] = double.Parse(file.ReadLine());
				votoinf[indice] = double.Parse(file.ReadLine());
				media[indice] = (votosto[indice] + votoita[indice] + votomate[indice] + votoinf[indice]) / 4;

				indice++;
            }
			// Lista delle schede di tutti gli studenti, con le loro medie dei voti
			for (int i = 0; i < nomi.Length; i++) //Per pgni i = 0, e non superi la lunghezza, i si incrementa
            {
				listavoti += "\n=== Pagella ===\n" +
								"\nNome:  " + nomi[i] +
								"\nClasse: " + classi[i] +
								"\nItaliano:  " + votoita[i] +
								"\nMatematica:  " + votomate[i] +
								"\nStoria:  " + votosto[i] +
								"\nInformatica:  " + votoinf[i] +
								"\n\n La tua media dei voti è: " + media[i];
			}
			Console.WriteLine(listavoti);
			
			//  Il nome dello studente con la media più alta in assoluto
			double max = 0;
			string nomiMax = "";

			for (int i = 0; i < nomi.Length; i ++)
            {
				if (media[i] > max)
				{

					max = media[i];
					nomiMax = nomi[i];
				}
				else if (media[i] == max)
					nomiMax += ", " + nomi[i];
            }
			Console.WriteLine("\nStudente con la media più alta " + "\n" + nomiMax + ": " + max);
			
			//- Il numero di studenti della classe 4° con un voto uguale o superiore a 8 in informatica
			int studenti4inf8più = 0;

			for(int i = 0; i < nomi.Length; i++)
            {
				if (classi[i] == 4 && votoinf[i] >= 8)
                {
					studenti4inf8più++;
                }
            }
			Console.WriteLine("\nStudenti di 4° con votoinf >= 8: " + studenti4inf8più);
			
			//- Il nome degli studenti della classe di 3°
			string nomi3 = "";

			for(int i = 0; i < nomi.Length; i++)
            {
				if(classi[i] == 3)
                {
					nomi3 += "\n> " + nomi[i];
                }
            }

			Console.WriteLine("\nLista dei nomi della classe 3° " + nomi3);
			
			//- Il nome dello studente con la media più bassa della classe di 1°
			string nomemediapeggiore = "";
			double min = 10;//dopo l'uguale va il maxvalue. 

			for(int i = 0; i < nomi.Length; i++)
            {
				if (media[i] < min && classi[i] == 1)
				{
					min = media[i];
					nomemediapeggiore = nomi[i];
				}
				else if (media[i] == min && classi[i] == 1)
					nomemediapeggiore += "> " + nomi[i];
            }

			Console.WriteLine("\nStudente 1° con peggior media: " + nomemediapeggiore + ": " + min);

			//- La media complessiva di Matematica di tutti gli studenti della classe 2°
			double mediamate = 0;
			int contastudenti2 = 0;

			for(int i = 0; i < nomi.Length; i++)
            {
				if (classi[i] == 2)
					mediamate += votomate[i];
					contastudenti2++;
            }

			Console.WriteLine("\nLa media complessiva degli studenti di 2° " + mediamate / contastudenti2);


		}
	}
}
