using System;

namespace _02___EserciziVettori
{
	class Program
	{
		//La parola static serve ad indicare campi e metodi non sono solo dell'oggetto
		//ma anche della classe
		//gli elementi static sono elementi globali utilizzabili
		//dove abbiamo bisogno scrivendo NomeClasse.NomeMetodo
		/*static void Main(string[] args)
		{
			/*int numero1 = 10;
			int numero2 = 12;

			int risultato = Metodi.Somma(numero1, numero2);

			Console.WriteLine(risultato);

			
			Persona p1 = new Persona();
			p1.eta = 15;

			Persona p2 = new Persona();
			p2.eta = 28;

			Persona.etaMax = 198;

            Console.WriteLine(Persona.etaMax); */

		static void Main(string[] args)
		{
            int[] vettore = { 4, 65, 19, 4, 2, 1, 4, 6, 3 };

            int daCercare = 4;

            Metodi.Calcolo1(vettore, daCercare);

            vettore = Metodi.Modifica(vettore);

            Console.WriteLine("numeri nel vettore modificato");

            foreach (int i in vettore)
            {
                Console.WriteLine(i + " ");
            }

   //         Persona p1 = new Persona { nome = "kkvale" , cognome = "pippo" };

			//Persona p2 = new Persona();
			//p2.nome = "yari";
			//p2.cognome = "pippa";

			//Persona p3 = p1;

			//p3.nome = "luca";
			//p2.nome = "paola";
			//p1.nome = "arnold";

   //         Console.WriteLine(p1.nome);
   //         Console.WriteLine(p2.nome);
   //         Console.WriteLine(p3.nome);
			



						




















		}//fine main
	}
}