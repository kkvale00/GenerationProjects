using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Campionato
{
	class Persona
	{
		private string nome;
		private string cognome;
		private int dob;
		

		public string Nome { get => nome; set => nome = value; }
		public string Cognome { get => cognome; set => cognome = value; }
		public int Dob { get => dob; set => dob = value; }
		

		public Persona(string nome, string cognome, int dob)
		{
			this.Nome = nome;
			this.Cognome = cognome;
			this.Dob = dob;
			
		}
		public virtual string Scheda()
		{
			return $"Nome :		{nome}\n" +
				   $"Cognome :  {cognome}\n" +
				   $"DOB :		{dob}\n";
				   
		}

		public int Eta()
        {
			int eta = 0;

			eta = 2021 - Dob;

			return eta;
        }

		public virtual double Stipendio()
        {
			double stipendio = 700;


			return stipendio;
        }




	}//fine classe







}
