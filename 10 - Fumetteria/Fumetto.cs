using System;
using System.Collections.Generic;
using System.Text;

namespace _10___Fumetteria
{
	class Fumetto
	{
		public string testata;
		public int numero;
		public string titolo;
		public string casaEditrice;

		//costruttore
		public Fumetto()
		{

		}
		public Fumetto(string testata, int numero, string titolo, string casaEditrice)
		{
			this.testata = testata;
			this.numero = numero;
			this.titolo = titolo;
			this.casaEditrice = casaEditrice;
		}

		public string Scheda()
		{
			return $"======================\n£ +"                           +
				   $"Nome testata: {testata}"                               +
				   $"\nNumero: {numero} "                                   +
				   $"\nTitolo: {titolo} "                                   +
				   $"\nCasa Editrice: {casaEditrice} "                      +
				   $"\nPrezzo: {Prezzo()} euro"                             +
				   $"\n==================================================\n";
		}
		public double Prezzo()
		{
			
			double ris = 0;

			switch(casaEditrice.ToLower())
            {
				case "bonelli":
					ris += 4;
					break;
				case "dc":
				case "marvel":
					ris += 5;
					break;

				default:
					ris += 3;
					break;

            }

			switch (testata.ToLower())
			{
				case "dylan dog":
					ris += 0.40;
					break;
				case "martin":
					ris += 0.60;
					break;
				case "superman":
					ris += 0.90;
					break;
				case "batman":
					ris += 0.85;
					break;
				case "x-men":
					ris += 0.95;
					break;

				default:
					break;
			}

			if (numero >= 430 && numero <= 470)
				ris -= ris * 3 / 100;
			else if (numero >= 300)
				ris += ris * 5 / 100;

			
			return ris;
		}

	}

}
		

	
