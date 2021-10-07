using System;
using System.Collections.Generic;
using System.Text;

namespace Ospedale
{   //Con questa dicitura, Paziente è sottoinsieme di Persona.
    //quindi in automatico, EREDITA tutti i campi e metodi di Persona.
    class Paziente : Persona
    {
        public string reparto;
        public int giorniPrognosi;
        public bool coma;
       

        //Per poter identificafre un paziente, ho bisogno di tutte le caratteristiche
        //Quelle di persona le passiamo al costruttore della classe padre tramite ": base"
        //mentre quelle di paziente le gestiamo normalmente
        public Paziente(string nome, string cognome, int eta, string reparto, int giorniPrognosi, bool coma)
                        : base(nome, cognome,eta)
        {
            if (reparto == "cardiologia" || reparto == "ortopedia" ||
                reparto == "oncologia" || reparto == "urologia" || reparto == "pronto soccorso")
                 this.reparto = reparto;
            else this.reparto = "pronto soccorso";


            if (giorniPrognosi > 0)
                 this.giorniPrognosi = giorniPrognosi;
            else this.giorniPrognosi = 1;

            this.coma = coma;
        }
        //Si richiama con override la virtual string del padre.
        //Sovrascriviamo il metodo scheda eriditato
        public override string Scheda()
        {
            //base.Scheda() indica il metodo Scheda della classe padre
            return base.Scheda()                         +
                   $"Reparto : {reparto}\n"              +
                   $"giorni dentro : {giorniPrognosi}\n" +
                   $"Coma : {(coma ? "Si" : "No")}\n"    ;
        }
        /* il costo di un paziente è pari a 2.5 se è nel reparto "cardiologia", "ortopedia" o "urologia", DONE
           3.8 se è "pronto soccorso", 6.5 se è "oncologia" o "neurologia". 
           Aumentare del 30% se il paziente è in coma. Aumentare di un ulteriore 45% se il paziente ha 65 anni o più. 
           Infine moltiplicare il tutto per i giorni di prognosi.
         */
        public double Costo()
        {
            double prezzo = 0;

            if (reparto == "Cardiologia" || reparto == "Ortopedia" || reparto == "Urologia")
                prezzo += 2.5;
            else if (reparto == "pronto soccorso")
                prezzo += 3.8;
            else if (reparto == "oncologia" || reparto == "neurologia")
                prezzo += 6.5;
            if (coma)
                prezzo += prezzo * 30 / 100;
            if (eta >= 65)
                prezzo += prezzo * 45 / 100;

            prezzo += prezzo * giorniPrognosi;
            return prezzo;
        }
    }
}
