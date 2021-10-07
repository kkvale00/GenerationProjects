using System;

namespace Studente
{
	class Program
	{
		static void Main(string[] args)
		{
			//Nella fase di dichiarazioe creare 5 variabili di tipo double  "D"
			//chiamate: votoita, votoing, votosto, votomat, media
			double votoita;
			double votoing;
			double votosto;
			double votomat;
			double media;

			//Nella fase di input fare richiesta all'utente  per fargli inserire i voti  "I"
            Console.WriteLine("inserisci il voto di italiano ");
			votoita = double.Parse(Console.ReadLine());
			Console.WriteLine("inserisci il voto di inglese ");
			votoing = double.Parse(Console.ReadLine());
			Console.WriteLine("inserisci il voto di storia ");
			votosto = double.Parse(Console.ReadLine());
			Console.WriteLine("inserisci il voto di matematica ");
			votomat = double.Parse(Console.ReadLine());

			//Nella fase di calcolo, calcolare la media dei voti e mettere il risultato  "C"
			//all'interno della media
			media = (votoita + votoing + votosto + votomat) / 4;

			//Nella fase di output stampare qual è la media dello studente     "O"
			Console.WriteLine("La tua media artimetica è " + media + ". Potresti fare di meglio, CAPRA! ");
			Console.ReadKey();

		
			


        }
    }
}
