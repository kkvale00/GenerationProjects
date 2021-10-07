using System;
using System.IO;
namespace _02___EsercizioVettori1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Film:titolo, genere, regista, durata
			//Leggiamo queste info da un file .txt
			//stampare in console le schede dei film
			//e il file con la durata minima

			string[] titoli;
			string[] generi;
			string[] registi;
			int[]    durate;

			string rigaFile;
			string listaSchede = "";
			string durataminima = "";
			int min = int.MaxValue;

			StreamReader file = null; //per usarlo anche dopo il try-catch

			try
			{
				file = new StreamReader(@"C:\Users\kkvale\source\repos\SecondaSettimana\02 - EsercizioVettori1\film.txt");
			}
			catch(FileNotFoundException)
			{
				Console.WriteLine("Percorso errato");
			}

			int indice = 0;
			int dimensione = int.Parse(file.ReadLine());

			titoli = new string[dimensione];
			generi = new string[dimensione];
			registi = new string[dimensione];
			durate = new int[dimensione];

			
			while((rigaFile = file.ReadLine()) != null)
            {
				titoli[indice] = rigaFile;
				generi[indice] = file.ReadLine();
				registi[indice] = file.ReadLine();
				durate[indice] = int.Parse(file.ReadLine());

				indice++;
            }
			//Da qui in poi si dà per scontato che i dati siano dentro i vettori
			//non ci serve più il file

			for (int i = 0; i < titoli.Length; i++)
				listaSchede +=  "\n=== FILM ===\n"         +
								"\nTitolo:  " + titoli[i]  +
								"\nRegista: " + registi[i] +
								"\nGenere:  " + generi[i]  +
								"\nDurata:  " + durate[i]  + "min";

			for (int i = 0; i < titoli.Length; i++)
			{
				if (durate[i] < min)
				{
					min = durate[i];
					durataminima = titoli[i];
				}
				else if (durate[i] == min)
					durataminima += ", " + titoli[i];
					
					
				
			}

			Console.WriteLine("Lista: " + listaSchede + "\nDurata minima " + durataminima + ": " + min + " minuti");
			

		}
		
	}
}
