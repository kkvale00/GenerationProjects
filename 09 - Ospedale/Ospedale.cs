using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace _09___Ospedale
{
    /*Una classe tipo lei è, svolge un lavoro particolare.
     viene definita come classe AGGREGATRICE e non ha lo scopo solo di modellare un oggetto
     ma ha anche la funziona di aggregare molteplici oggetti di tipo uguale o diversi tra loro
    */

    class Ospedale
    {
        //Campi
        public Paziente[] pazienti;
       
        //Metodi
        public Ospedale(string path) //string path = parametro: è una varaiabile che passa nel mommento in cui si invoca questo metodo.

        {    
            StreamReader file = null;

            if(File.Exists(path))
            {
                file = new StreamReader(path);
            }
            else
            {
                Console.WriteLine("VOLEEEEEEEVI");
            }

            pazienti = new Paziente[int.Parse(file.ReadLine())];

            string riga;

            int indice = 0;

            while((riga = file.ReadLine()) != null)
            {
                string[] info = riga.Split(",");

                Paziente p = new Paziente(
                                            info[0], //nominativo
                                            info[1], //dob
                                            info[2], //patologia
                                            int.Parse(info[3]) //Giornidegenza
                                          );

               /* usiamo la cosa sopra al posto di questa sotto:
                
                p.nominativo = info[0];
                p.dob = info[1];
                p.giorniDegenza = int.Parse(info[3]);
                p.patologia = info[2];*/

                pazienti[indice] = p;
                indice++;
            } //campo è pieno
        }//fine metodo,

        //lista completa dei pazienti
        public string ListaCompleta()
        {
            string ris = "";

            for (int i = 0; i < pazienti.Length; i++)
            {
                ris += pazienti[i].Scheda();
            }

            return ris;
        }
        //pazienti con la degenza più lunga
        public string DegenzaLunga()
        {
            string ris = "";
            int max = 0;

            for (int i = 0; i < pazienti.Length ;  i++)
            {
                if(pazienti[i].giorniDegenza > max)
                {
                    max = pazienti[i].giorniDegenza;
                    ris = pazienti[i].nominativo;
                }
                else if(pazienti[i].giorniDegenza == max)
                    ris += ", " + pazienti[i].nominativo;
            }
            return ris;
        }

        //degenza media dei pazienti
        public int DurataMediaDegenza()
        {
            int ris = 0;

            for (int i = 0; i < pazienti.Length; i++)
            {
                ris += pazienti[i].giorniDegenza;
            }

            return ris/pazienti.Length;
        }

        //paziente più anziano
        public string PazienteAnziano()
        {
            string ris = "";
            int max = 0;

            for (int i = 0; i < pazienti.Length; i++)
            {
                if (pazienti[i].Eta() > max)
                {
                    max = pazienti[i].Eta();
                    ris = pazienti[i].nominativo;
                }
                else if (pazienti[i].Eta() == max)
                    ris += ", " + pazienti[i].nominativo;
            }

            return ris;
                
        }




    }//fine classe
}
