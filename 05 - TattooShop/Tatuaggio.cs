using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace _05___TattooShop
{
    class Tatuaggio : Entity
    {
        public Tatuaggio(){}

        public Tatuaggio(int id, string descrizione, DateTime data, bool colori, int prezzo, int altezzacm, int larghezzacm) 
                       : base(id)
        {
            Descrizione = descrizione;
            Data = data;
            Colori = colori;
            Prezzo = prezzo;
            Altezzacm = altezzacm;
            Larghezzacm = larghezzacm;
        }

        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public bool Colori { get; set; }
        public int Prezzo { get; set; }
        public int Altezzacm { get; set; }
        public int Larghezzacm { get; set; }

        //Oltre alle solite proprieta ci aggiungo un oggetto Tatuatore 
        //cioe chi e che ha fatto ogni tatuaggio, consiglia di chiamare
        //la variabile in un altro modo per non confondere la classe 
        public Tatuatore Tat { get; set; }

        public void FromDictionary(Dictionary<string, string> riga)
        {
            Id = int.Parse(riga["id"]);
            Descrizione = riga["descrizione"];
            Data = DateTime.Parse(riga["data"]);
            Colori = bool.Parse(riga["colori"]); 
            Prezzo = int.Parse(riga["prezzo"]);
            Altezzacm = int.Parse(riga["altezzacm"]);
            Larghezzacm = int.Parse(riga["larghezzacm"]);
        }









    }//fine classe
}
