using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Scuola
{
	class Persona
	{
		//i 3 principi della programmazione ad oggetti:
		//1) Ereditarietà = creare gradi di parentale tra classi diverse (medico : persona)
		//                  eredita così classi e metodi, senza riscriverli
		//2) Polimorfismo = capacità di un oggetto di adattarsi ad X situazioni, 2 forme principali:
		//                  override = il metodo classe figlia sovrascrive il metodo ereditato dal padre
		//                  overload = nella stessa classe abbiamo più metodi con stesso nome ma parametri diversi (quantità o tipo)
		//3) Incapslamnto = andare a nascondere i campi degli oggetti, rendendoli privati 
		//                  visibile solo nella classe stessa, per utilizzarli si dovrà passare sia in lettera che scrittura
		//                  da un getter o setter (getter: lettura /\ setter: scrittura)


		//I veri contenitori sono i campi
		private string cognome;
		private string dob;
		private string sesso;
		private string residenza;


        //QUeste sono proprietà, ossia l'unico modo che le altre classi hanno x accendere in lettura e scrittura ai campi
        public string Cognome { get => cognome; set => cognome = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Sesso { get => sesso;
			set
			{
				if (value.ToLower() == "uomo" || value.ToLower() == "donna")
					sesso = value;
				else
					sesso = "Uomo";
			}

		}
        public string Residenza { get => residenza; set => residenza = value; }

		public Persona(string cognome, string dob, string sesso, string residenza)
		{
			Cognome = cognome;
			Dob = dob;
			Sesso = sesso;
			Residenza = residenza;
		}

		public virtual string Scheda()
		{
			return $"Cognome : {cognome}\n" +
				   $"DatadiNascita : {dob}\n" +
				   $"Sesso : {sesso}\n" +
				   $"Residenza : {residenza}\n";
				   
		}


	}
}		
		