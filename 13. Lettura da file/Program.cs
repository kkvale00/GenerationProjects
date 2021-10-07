using System;
using System.IO; //Dizionario che conosce StreamReader

namespace _13._Lettura_da_file
{
	class Program
	{
		static void Main(string[] args)
		{

			//Per automatizzare l'inserimento di dati, spesso si vanno a scrivere
			//all'interno di file, che possono essere .txt, .csv
			//Le nostre info saranno formattatte una sotto l'altra
			//info1
			//info2
			//info 3

			//first of all: scrivere il file
			//second of all: importare i dati del programma

			string riga;
		
			//Se il file non si trova dove dico, 
			//si usa il "try { } catch", GESTIONE ECCEZION
			//nel TRY meto il "codice caldo" cioè il codice ha la potenzialità di crashare il prgm
			//nel CATCH metto il comprtamento che il programma assume nel caso crasha
			// il CATCH comprendo vari errori: mettere tutti i catch e ordinarli dall'eccezione più specifica al più generica
			//Blocco FINALLY, facolt. --> precedenza di esecuzione su tutto, anche sul crash

			try
			{

				//Strumento che permette di cercare il file e leggere il suo contenuto
				StreamReader file = new StreamReader(@"C:\Users\kkvale\source\repos\PrimaSettimana\13. Lettura da file\PrimoFile.txt");
				//La @ serve a far ignorare \ al programma, che altrimenti li leggerebe come codici di codifica.
				//Un altro modo per farli ignorare sarebbe renderli doppi\\

				//Ciclo che va da 0 a infinite volte
				while ((riga = file.ReadLine()) != null)
				{
					//Per leggere la riga del file si usa file.ReadLine()
					//riga = file.ReadLine();//Ciao come
					Console.WriteLine(riga);
				}


				
			}
			catch(FileNotFoundException)
			{
				Console.WriteLine("Percorso errrato, chiudo tutto. ");
				
			}
			catch(Exception) //Qualunque errore esistente
			{
				Console.WriteLine("Qualcosa non va, ma non so cosa");
			}
			finally
			{
				Console.WriteLine("Sono dentro al FINALLY");
			}

			Console.WriteLine("Fuori dal Catch");
			
		}
	}
}
