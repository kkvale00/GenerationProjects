using System;
using System.Collections.Generic;
using System.Text;

namespace Ospedale
{
    class Chirurgo : Medico
    {
        public int interventi;
        public int interventiRiusciti;

        
        

        public Chirurgo(string nome, string cognome, int eta,
                        int anniLavoro,
                        int interventi, int interventiRiusciti)
                        : base(nome, cognome, eta, "Chirurgia", anniLavoro)
        {

            if (interventi >= 0)
                 this.interventi = interventi;
            else this.interventi = 0;


            if (interventiRiusciti <= this.interventi)
                this.interventiRiusciti = interventiRiusciti;
            else
                this.interventiRiusciti = this.interventi;

            if (interventiRiusciti == 100 && interventi == 50)
                interventiRiusciti = 50;
        }
        

        public override string Scheda()
        {
            return base.Scheda() +
                $"Interventi : {interventi}\n" +
                $"Interventi riusciti : {interventiRiusciti}\n";
        }



        //: metodo che calcola gli interventi sbagliati
        public int InterventiSbagliati() => interventi - interventiRiusciti;

        //metodo che ritorna true se il chirurgo ha sbagliato al massimo 1
        //intervento per ogni 2 anni di lavoro...  
        public bool buonChirugo()
        {
            //se anniLavoro vale X
            //InterventiSbagliati() dovrà essere minore o uguale a x"
            return InterventiSbagliati() * 2 <= anniLavoro;
        }

        //public double stipendio() alla classe Chirurgo: questo metodo farà override.
        //Lo stipendio parte dallo stipendio calcolato sulla classe padre a cui vanno tolti 30€ per ogni intervento sbagliato!
        //Se il chirurgo non ha mai sbagliato nessun intervento dargli un bonus del 25%.
        //NOTA BENE: lo stipendio di un chirurgo non può mai essere < 800. 


        public override double Stipendio()
        {
            double stipendio = base.Stipendio();

            stipendio -= 30 * InterventiSbagliati();

            if (InterventiSbagliati() == 0)
                stipendio += stipendio * 25 / 100;

            if (stipendio < 800)
                stipendio = 800;

            return stipendio;
        }

    }//7end
}
