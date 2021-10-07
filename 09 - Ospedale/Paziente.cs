using System;
using System.Collections.Generic;
using System.Text;

namespace _09___Ospedale
{
    class Paziente
    {
        //campi
        public string nominativo;
        public string dob;
        public string patologia;
        public int giorniDegenza;

        /* Costruttore: è un metodo, con la differenza che, questo metodo, 
                        serve per costruire un oggetto. PUoi personalizzarli, chiedendo i campi.
                        Il suo scopo è valorizzare i campi della classe 
                        Il Nome deve corrsipondere a quello della classe
                        il ritorno è sottinteso, non obbligatoroio
        */

        public Paziente()
        {
            //Costruttore vuoto ->è di default, usabile anche se non scritto, sottointeso
        }

        public Paziente(string nominativo, string dob, string patologia, int giorniDegenza)
        {
            //  campo = parametro
            this.nominativo = nominativo;
            //this->una delle parole chiavi, indica qualcosa appartieni alla classe 
            //in cui ci si trova
            this.dob = dob;
            this.patologia = patologia;
            this.giorniDegenza = giorniDegenza;
        }

        

        public int Eta()
        {
            /*int ris = 0;
            
            string[] data = dob.Split("-");
            
            ris = 2021 - int.Parse(data[2]);
            
            return ris; bro scrivi il rigo sotto al posto di sto casino */
            
            return 2021 - int.Parse(dob.Split("-")[2]);
        }
        
        public string Scheda()
        {
            return $"Nominativo {nominativo} "                              +
                   $"\nNato il {dob} di anni {Eta()} "                       +
                   $"Ricoverato per {patologia} "                            +
                   $"\nGiorni di Degenza Previsti: {giorniDegenza} "         +
                   $"\n==================================================\n";
        }
        public bool Cronico()
        {
            bool ris = false;

            if (giorniDegenza >= 21)  /*oppure return giorniDegenza >= 21;*/
                ris = true;

            return ris;
        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        



    }
}
