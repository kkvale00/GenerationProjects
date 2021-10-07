using System;
using System.Collections.Generic;
using System.Text;

namespace Ospedale
{
    class Persona
    {
        public string nome;
        public string cognome;
        public int eta;

        public Persona(string nome, string cognome, int eta)
        {   
            //Questo blocco viene eseguito quando qualcuno prova a creare un oggetto
            //persona e ci passa 3 paramente, prima di assegnarli facciamo dei controlli
            this.nome = nome;
            this.cognome = cognome;

            //Se l'età che arriva ha un valore coerente ok
            //else valorizzo con un valore default
            if (eta > 0 && eta < 120)
                this.eta = eta;
            else if (eta >= 119)
                this.eta = 119;
            else
                this.eta = 1;
                
        }
        //il virtual indica che una classe figlia potrebbe fare override di questo metodo
        public virtual string Scheda()
        {
            return $"Nome : {nome}\n" +
                   $"Cognome : {cognome}\n" +
                   $"Eta : {eta}\n";

        }
        //Questa è una lambda expression indica direttamente qual è il return senza corpo

        public int AnnoNascita() => 2021 - eta;

    }
}
