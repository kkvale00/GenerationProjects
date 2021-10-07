using System;

namespace _01___Vettori
{
	class Program
	{
		static void Main(string[] args)
		{
		 /*
											VETTORE o ARRAY

			- Vettore: è un insieme oridnato di elementi dello stesso tipo di dimensione
					   fissa.

			- Insieme: molteplici informazioni sperate all'interno della stessa variabile
		  
			- Ordinato: esiste un indice che numera le posizioni agli elementi, dando così
						un  ordine all'insieme.
						L'indice parte da 0 e arriva a N-1, "N"--->DIMENSIONE del vettore.

			- Dimensione fissa: per creare un vettore, devo sapere quanti elementi dovrà contenere
								cioè sapere la sua dimensione. Non si può creare un vettore se non si sa
								quanto è grande. La dimensione non può mai cambiare dopo che è stato creato.
		  */
			
			//Dichiarazione
			int[] prova;

			//Inizializzazione
			prova = new int[5]; //Vettore di dimensione 5 --> 5 elementi, indice max "N-1", ossia 4.

			//Inserire dati in un vettore
			prova[0] = 10;
			prova[1] = 5;
			prova[2] = 9;
			prova[3] = 3;
			prova[4] = 2;
			/*prova[5] = 7;   /'\ ATTENZIONE!! E' permesso scrivere indici non esistenti,
						     ma nel momento di esecuzione del programma daranno errore.*/

			//Come stampare un vettore
			//BOCCIATO: Console.Writeline(prova);
			//APPROVATO:
			int indice = 0;

            while(indice < prova.Length) //Length: restituisce  quanti indici ci sono al suo interno
			{
				Console.WriteLine("Indice: " + indice + " Valore Vettore: "+ prova[indice]);
				indice++;
			}

			//IL FOR, in alternativa al while, essendo scomodo con i vettori,
			for (int i = 0; i < prova.Length; i++)
				Console.WriteLine("Indice: " + i + " Valore Vettore: " + prova[i]);






		}
	}
}
