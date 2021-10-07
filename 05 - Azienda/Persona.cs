using System;
using System.Collections.Generic;
using System.Text;

namespace _05___Azienda
{
    class Persona //classe tipo
    {
        /*
         una classe è un modello che dà linee guida sulla creazione di oggetti
         Le classi si dividono in due categorie:
            - classi di avvio: contiene il MAIN ed è unica all'interno del progetto
                               Essa è l'unica che interagisce con la console
               
            - classi tipo o modello: servono per dare forma agli oggetti che il programma
                                     usa durante l'exe.
         */

        //Campi[field] //public=tutto il progetto, tutte le classi vedono quasta string
        public string nome; 
        public string cognome; 
        public string dob;
        public string residenza;

        //Oggetto: è un'istanza della classe
        //Significa che l'oggetto è il caso concreto, l'esempio che esiste nella realtò
        //Per farlo, si valorizza il campo

        //Stato dell'oggetto: è l'insieme dei valori dei campi di un oggetto in un determinato momento

        /*Metodo/Funzione: un blocco di codice a se stante, 
                            svolge un compito 
                            restituisce un valore
                            SEMPRE CON PARENTESI TONDE
        Il metodo si divide in due parti: la firma e il corpo
        La firma è data dal nome e dal tipo dei parametri passati
        Il corpo è dato dalle istruzioni presenti dentro il blocco di codice
        */    

        public string scheda() //firma = "scheda()" corpo = "{...}"
        {
            //corpo
            string ris = ""; //ris=risposta

            ris = $"Nominativo {nome} {cognome},"    + //$=indica che arrivati ad una graffa {}, troverà un codice: variabile, campo o testo
                  $"\nNat* il {dob}, di anni {eta()}"      +
                  $"\n============================\n";

            return ris; //Permette l'uscita del dato. Una volta letto return, finisce e 
                        //porta la risposta fuori dal metodo.
        }//Fine metodo scheda

        public int eta()
        {
            int ris = 0;
            //solo l'anno, 2021 - l'anno di nascita -> yod lo trovo dob 
            //--> dob è string quindi posso splittare
            string[] data = dob.Split("-");

            ris = 2021 - int.Parse(data[2]);

            return ris;
        }//Fine eta()



    }
}
