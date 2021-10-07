using System;

namespace italiateam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             * Creare un progetto di nome ItaliaTeam. 
               Avremo le seguenti classi tipo:
               -	Entita astratta che avrà come campi: int matricola, string specialita, int piazzamento
               -	Atleta figlia di Entita che avrà come campi aggiuntivi: string nominativo, string dob (scritta nel formato yyyy-MM-dd), string sesso
               -	Squadra figlia di Entita che avrà come campi aggiuntivi: string [] nominativi, string sesso (la squadra potrebbe essere maschile, femminile o mista)
               
               Successivamente aggiungere il metodo ToString in tutte le classi.
               Scrivere il metodo int eta() all’interno della classe Atleta.
               Scrivere il metodo int AtletiInSquadra() che restituisce il numero di atleti in una squadra
               Scrivere il metodo bool Partecipante(string n) che restituisce true se la stringa passata come parametro è il nominativo di qualcuno facente parte della squadra
               
               Creare un file con squadre e atleti.
               
               Creare la classe aggregatrice che avrà come unico campo una lista di Entita che verrà riempita dal costruttore che leggerà dal file le informazioni 
               e creerà gli oggetti di tipo Atleta e Squadra.
               
               Successivamente creare e testare i seguenti metodi nella classe aggregatrice:
               -	un metodo che restituisce il ToString di tutti gli atleti
               -	un metodo che restituisce il tostring di tutte le squadre
               -	un metodo che restituisce l’età media dei nostri atleti
               -	un metodo che ci comunica se abbiamo più atleti donne o uomini (senza contare le squadre)
               -	un metodo che prende come parametro un numero intero e stampa il tostring delle squadre che hanno almeno quel numero di atleti
               -	un metodo che prende un parametro di tipo int e ci restituisce quanti tra atleti e squadre si sono piazzati in quella posizione
               -	un metodo che restituisce un intero che corrisponde ai premi in denaro da distribuire a tutti gli atleti considerando che
                    ogni oro vale 150.000, argento 100.000 e bronzo 50.000. Nota bene: una squadra da 10 persone che vince l’oro ha diritto a 1.500.000 di premio!
             */
        }
    }
}
