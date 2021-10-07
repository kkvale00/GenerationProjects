using System;
using System.Collections.Generic;
using System.Text;

namespace Ospedale
{   //una classe N figli
    //una classe può avere solo un genitore1
    //eriderietà in C# è singola
    class Medico : Persona
    {
        public string reparto;
        public int anniLavoro;
        
        public Medico(string nome, string cognome, int eta, string reparto, int anniLavoro)
                     : base(nome, cognome, eta)
        {
            reparto = reparto.ToLower();
            if (reparto == "cardiologia" || reparto == "ortopedia" ||
                reparto == "oncologia" || reparto == "urologia" || 
                reparto == "pronto soccorso" || reparto == "chirurgia")
                 this.reparto = reparto;
            else this.reparto = "pronto soccorso";

            if (anniLavoro >= 0)
            { 
                //anniLavoro - eta < 25 ==> anniLavoro + 25 > eta===> eta - 25 >= anniLavoro
                if (eta - 25 >= anniLavoro)
                    this.anniLavoro = anniLavoro;
                else this.anniLavoro = eta - 25;
            }
                else this.anniLavoro = 0;
        }


        public override string Scheda()
        {
            return base.Scheda() +
                $"Reparto : {reparto}\n" +
                $"Anni di lavoro : {anniLavoro}\n";
        }
        /*
          lo stipendio di un medico parte da 1200 a cui aggiungiamo in base al reparto:
          +850 se "cardiologia" o "neurologia",
          +630 se "ortopedia", 
          +450 se è altro. 
          Poi aggiungere 22.5 per ogni anno lavoro.
          Infine togliere il 12% se il medico ha meno di 35 anni, 
          aggiungere il 9.8% se il medico ha più di 50 anni
         */
        
        public virtual double Stipendio()
        {
            double stipendio = 1200;

            if (reparto == "cardiologia" || reparto == "neurologia")
                stipendio += 850;
            else if (reparto == "ortopedia")
                stipendio += 630;
            else
                stipendio += 450;

            stipendio += 22.5 * anniLavoro;


            if (eta < 35)
                stipendio -= stipendio * 12 / 100;
            if (eta > 50)
                stipendio += stipendio * 9.8 / 100;

            return stipendio;
        }

        





    }


}
