using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Campionato
{
	class Allenatore : Persona
	{
		private string squadraAttuale;
		private string[] squadreAllenate;
		private int anniExp;
		private int campionatiVinti;

		public Allenatore(string nome, string cognome, int dob,
						  string squadraAttuale, string[] squadreAllenate, 
						  int anniExp, int campionatiVinti)
						: base(nome, cognome, dob)
		{
			SquadraAttuale = squadraAttuale;
			SquadreAllenate = squadreAllenate;
			AnniExp = anniExp;
			CampionatiVinti = campionatiVinti;
		}

		public string SquadraAttuale { get => squadraAttuale; set => squadraAttuale = value; }
		public string[] SquadreAllenate { get => squadreAllenate; set => squadreAllenate = value; }
		public int AnniExp { get => anniExp; set => anniExp = value; }
		public int CampionatiVinti { get => campionatiVinti; set => campionatiVinti = value; }

		//=====================================================\\

		public override string Scheda()
		{
			return base.Scheda() +
					$"squadra :		{squadraAttuale}\n" +
					$"squadreAllenate :  {squadreAllenate}\n" +
					$"anniExp :		{anniExp}\n" +
					$"CampionatiVinti : {campionatiVinti}\n";
		}

		//Ritorna true se gli anniEsperienza sono più di 10 e
		//ha allenato solo la squadraAttuale

		public bool Fedele()
        {
			bool fedele = false;

            for (int i = 0; i < squadreAllenate.Length; i++)
            {
				if (squadreAllenate[i] == squadraAttuale && anniExp >= 10)
					fedele = true;

            }


			return fedele;
        }


		//Ritorna true se il numero di campionati vinti è maggiore di 4;
		public bool BuonAllenatore()
        {
			bool goodcoach = false;

			if (campionatiVinti > 4)
				goodcoach = true;


			return goodcoach;
        }



		//-> Ritorna true se ha allenato un numero di squadre maggiore della metà degli anniEsperienza;
		public bool Mercenario()
        {
			bool mercenario = false;
			int nsquadre = 0;

            for (int i = 0; i < squadreAllenate.Length; i++)
            {
				nsquadre++;
			}

			if (nsquadre > anniExp / 2)
				mercenario = true;

			return mercenario;
        }

		//Aggiungere il 20% se è un allenatore fedele,
		//a questo, aggiungere il 35% se è un buon allenatore
		//inoltre, togliere il 10% se è un mercernario,
		//altrimenti premiarlo con un bonus di 600 

		public override double Stipendio()
        {
			double stipendio = base.Stipendio();

			if (Fedele())
				stipendio += stipendio * 20 / 100;

			if (BuonAllenatore())
				stipendio += stipendio * 35 / 100;

			if (Mercenario())
				stipendio -= stipendio * 10 / 100;

			else stipendio += 600;



				return stipendio;
        }





	}//fine classe
}
