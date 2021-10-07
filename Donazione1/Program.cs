using System;

namespace Donazione1
{
	class Program
	{
		static void Main(string[] args)
		{
			//All'utente verrà richiesto di inserire dei dati
			string nome;
			int eta;
			string residenza;
			int peso;
			bool fumatore;
			bool tatuaggi;
			bool droga;

			string donatore;

			//Fase di input
			Console.WriteLine("Come ti chiami?");
			nome = Console.ReadLine();

			Console.WriteLine("Quanti anni hai?");
			eta = int.Parse(Console.ReadLine());

			Console.WriteLine("Qual è la tua residenza?");
			residenza = Console.ReadLine();

			Console.WriteLine("Quanto pesi");
			peso = int.Parse(Console.ReadLine());

			Console.WriteLine("Sei un fumatore? s/n");
			fumatore = Console.ReadLine() == "s";
			
			Console.WriteLine("Hai fatto tatuaggi negli ultimi 6 mesi? s/n");
			tatuaggi = (Console.ReadLine()) == "s";

			Console.WriteLine("Hai assunto droghe nelle ultime 24h? s/n");
			droga = Console.ReadLine() == "s";

			//Fase di calcolo
			//Una persona può donare il sangue se pesa più di 50 kg, è residente a milano
			//e non ha fatto tatuaggi negli mesi né usato droga nelle ultime 24h
			if( peso > 50 && residenza.ToLower() == "milano" && tatuaggi == false && droga == false && fumatore == false)
			{
				donatore = ("Puoi donare il sangue.");
			}
			else
			{
				donatore = ("Bro...mi dispiace ma non sei idoneo :(");
			}
			Console.Clear();
			//Fase di output
			Console.WriteLine(
							   "==================\n" +
							   "Nome: " + nome + "\n" +
							   "Età: " + eta + "\n" +
							   "Residenza: " + residenza + "\n" +
							   "Peso: " + peso + "\n" +
							   "Fumatore: " + fumatore + "\n" +
							   "Tatuaggi: " + tatuaggi + "\n" +
							   "Droga: " + droga + "\n" +
							   donatore + "\n" + 
							   "===================\n"
							   );
							   
			Console.ReadKey();

		}
	}
}
