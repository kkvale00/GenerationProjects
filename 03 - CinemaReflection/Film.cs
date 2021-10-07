using System;
using System.Collections.Generic;
using System.Text;

namespace _03___CinemaReflection
{
    class Film : Entity
    {
        public string Titolo { get; set; }
        public int Durata { get; set; }
        public string Genere { get; set; }
        public int Annouscita { get; set; }

        public Film(int Id, string titolo, int durata, string genere, int annouscita) 
                    : base(Id)
        {
            Titolo = titolo;
            Durata = durata;
            Genere = genere;
            Annouscita = annouscita;
        }
            
        public Film() { } //costruttore mafia: o me li dai tutti o nessuno piccioto

        //Questo metodo servira a volirazzare le proprieta di un film partendo
        //dal dictionary. Di fato questo metodo void modifica lo stato dell'oggetto
        //lo stato dell'oggetto e l'insieme dei valori delle proprieta di un oggetto
        //in un dato istante.
        public void FromDictionary(Dictionary<string,string> riga)
        {
            Id = int.Parse(riga["id"]);
            Titolo = riga["titolo"];
            Durata = int.Parse(riga["durata"]);
            Genere = riga["genere"];
            Annouscita = int.Parse(riga["annouscita"]);
        }

    }//fineclasse

}
