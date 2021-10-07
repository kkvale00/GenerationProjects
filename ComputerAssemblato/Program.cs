using System;

namespace ComputerAssemblato
{
	class Program
	{
		static void Main(string[] args)
		{
			//DICHIARAZIONE
			double prezzo = 200;

			string marca;
			int ram;
			int dimensioniHD;
			bool ssd;

			//INPUT: chidere all'utente i dati del pc
			Console.WriteLine("Che marca vuoi acquistare?");
			marca = Console.ReadLine().ToLower();

			Console.WriteLine("\nQuanta RAM deve avere?");
			ram = int.Parse(Console.ReadLine());

			Console.WriteLine("\nQuanto deve essere grande l'HDD");
			dimensioniHD = int.Parse(Console.ReadLine());

			Console.WriteLine("\nDesideri anche l'SSD? s/n");
			ssd = Console.ReadLine() == "s";

			//CALCOLO
			//Lo switch serve ad analizzare una singola variabile e a descrivere
			//al suo programma come comportarsi in base al suo valore.
			switch(marca)
            {
				case "asus":
				case "hp":
					prezzo += 200;
					break;
				case "lenovo":
					prezzo += 400;
					break;
				case "apple":
					prezzo += 700;
					break;
				default:
					prezzo += 350;
					break;
            }

			/* la scrittura qui sopra ^ si può utilizzare al posto 
			// che ho scritto qui sotto 

			if (marca == "Asus" || marca == "HP")
			    prezzo += 200;
			else if (marca == "Lenovo")
				prezzo += 400;
			else if (marca == "Apple")
				prezzo += 700;
			//==================*/

			prezzo += ram * 6.5;


			if (ssd == true)
				 prezzo += dimensioniHD * 0.3;
			else prezzo += dimensioniHD * 0.12;

			//===================================
			if ((marca == "asus" || marca == "lenovo") && ssd == false)
				prezzo -= prezzo * 20 / 100;

			else if (marca == "apple" && ram > 8)
				prezzo -= prezzo * 3.5 / 100;

			else if (marca != "HP" && ssd == true)
				prezzo -= prezzo * 12 / 100;
			//===================================

			if (prezzo < 500)
            {
				prezzo = 500;
				Console.WriteLine("\n\nE DAJEEE! Caccia più sordi...");
            }

			//Output
			
			Console.WriteLine(
								"==================\n" +
							   "Marca: " + marca + "\n" +
							   "RAM: " + ram + "\n" +
							   "HDD: " + dimensioniHD + "\n" +
							   "SSD: " + (ssd ? "Si" : "No")+ "\n" +
							   "===================\n"
							   );
			Console.WriteLine("Il prezzo del tuo pc è " + prezzo + " euro.");
			Console.ReadKey();

			



			


			







		}
	}
}
