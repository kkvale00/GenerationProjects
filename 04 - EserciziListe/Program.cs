using System;
using System.Collections.Generic;


namespace _04___EserciziListe
{
    class Program
    {   
        static void Bo() { /*puoi creare i metodi statici anche qui e usarli nel main*/}
            

        static void Main(string[] args)
        {
            /*
             * Creare una lista di stringhe. Chiedere all'utente di inserire al suo interno
             * delle parole. Dopo ogni parola chiedere se vuole fermarsi oppure inserirne
             * un'altra. /DONE
             */
            List<string> parole = new List<string>();

            

            while (true) //ripeto all'infinito //for non ha senso, il vettore e vuoto non sappiamo quanter parole l'utente 
            {
                    Console.WriteLine("Inserisci parola");
                    parole.Add(Console.ReadLine());

                    Console.WriteLine("Un'altra parola? [s/n]");

                    if (Console.ReadLine() == "si")
                    {
                        Console.WriteLine("Inserisci parola");
                        parole.Add(Console.ReadLine());
                    }
                    else
                        break;
                }


          //  Una volta che l'utente avrà terminato l'inserimento fare i seguenti calcoli:
          //  *-chiedere all'utente di inserire un indice e stampare tutte le parole tranne 
          //* quella indicata

            Console.WriteLine("inserisci un indice");
            int indexnostmp = int.Parse(Console.ReadLine());

            for (int i = 0; i < parole.Count; i++)
            {
                if(i != indexnostmp)
                    Console.WriteLine(parole[i]);
            }

            //-stampare qual è la parola più lunga contenuta nella lista
            string parolaLunga = "";
            int lunghezzamax = 0;

            for (int i = 0; i < parole.Count; i++)
            {
                if (parole[i].Length > lunghezzamax)
                {
                    lunghezzamax = parole[i].Length;
                    parolaLunga = parole[i];
                }
            }

            //* - stampare la posizione della parola più corta
            int posizioneparolacorta = 0;
            int lunghezzamin = lunghezzamax;

            for (int i = 0; i < parole.Count; i++)
            {
                if(parole[i].Length < lunghezzamin)
                {
                    lunghezzamin = parole[i].Length;
                    posizioneparolacorta = i;
                }
            }

            //*-stampare la lunghezza media delle parole
            double sommalunghezze = 0;

            foreach (string p in parole)
            {
                sommalunghezze += p.Length;
            }
            Console.WriteLine("lunghezza media parole: " + (sommalunghezze / parole.Count));


            // * - stampare quante parole iniziano con la lettera "a"

            int inizialeA = 0;

            foreach (string p in parole)
            {
                if(p.ToLower().IndexOf("a") == 0)
                {
                    inizialeA++;
                    
                }
            }
            Console.WriteLine("Parole che iniziano con a " + inizialeA);


            //*-stampare quante parole finiscono con la lettera "a"
            int finaleA = 0;

            foreach (string p in parole)
            {
                if (p.ToLower().LastIndexOf("a") == 0)
                {
                    finaleA++;
                }
            }
            Console.WriteLine("Parole che iniziano con a " + finaleA);

            
        }
    }
}
