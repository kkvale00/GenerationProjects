using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Campionato
{
	class Giocatore : Persona
	{
		private string squadra;
		private string ruolo;
		private int anniExp;
		private int numeromaglia;
		private int partiteVinte;
		private bool capitano;
		private int campionatiVinti;

        public Giocatore(string nome, string cognome, int dob, 
                         string squadra, string ruolo, int anniExp, int numeromaglia, 
                         int partiteVinte, bool capitano, int campionatiVinti)
                         : base(nome, cognome, dob)
        {
            Squadra = squadra;
            Ruolo = ruolo;
            AnniExp = anniExp;
            Numeromaglia = numeromaglia;
            PartiteVinte = partiteVinte;
            Capitano = capitano;
            CampionatiVinti = campionatiVinti;
        }

        public string Squadra { get => squadra; set => squadra = value; }
        public string Ruolo { get => ruolo; set => ruolo = value; }
        public int AnniExp { get => anniExp; set => anniExp = value; }
        public int Numeromaglia { get => numeromaglia; set => numeromaglia = value; }
        public int PartiteVinte { get => partiteVinte; set => partiteVinte = value; }
        public bool Capitano { get => capitano; set => capitano = value; }
        public int CampionatiVinti { get => campionatiVinti; set => campionatiVinti = value; }


        //===================================================\\

        public override string Scheda()
        {
            return base.Scheda() +
                   $"squadra :		{squadra}\n" +
                   $"ruolo :  {ruolo}\n" +
                   $"anniExp :		{anniExp}\n" +
                   $"numero : {numeromaglia}\n" +
                   $"wins :		{partiteVinte}\n" +
                   $"capitano :  {capitano}\n" +
                   $"campionattiW :		{campionatiVinti}\n";
        }

        public bool Esperto()
        {
            bool experto = false;

            if (anniExp >= 10)
                experto = true;

            return experto;
        }

        public bool Vincitore()
        {
            bool ris = false;

            if (campionatiVinti >= anniExp / 2)
                ris = true;

            return ris;
        }

        public double Statistica() // -> Ritorna la percentuale di partiteVinte rispetto al totale delle partite giocate
        {
            double partiteGiocate = 0;

            partiteGiocate++;

            return (partiteVinte / partiteGiocate) * 100;
        }

        //Aggiungere il 10% se è un giocatore esperto, a questo,
        //aggiungere il 35% se è un vincitore,
        // inoltre, dividete per 10 il valore delle statistiche del giocatore
        // e aggiungete il valore ottenuto allo stipendio fin'ora calcolato

        public override double Stipendio()
        {
            double stipendio = base.Stipendio();

            if (Esperto())
                stipendio += stipendio * 10 / 100;

            if (Vincitore())
                stipendio += stipendio * 35 / 100;

            stipendio += Statistica() / 10;

            return stipendio;
        }





    }//fine classe
}
