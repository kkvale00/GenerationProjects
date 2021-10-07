using System;
using System.Collections.Generic;
using System.Text;

namespace _03___CinemaReflection
{
    class SerieTV : Entity
    {
        public new int Id { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int Stagioni { get; set; }
        public int Puntatemedie { get; set; }
        public double Puntatamediapuntata { get; set; }

        public SerieTV(int id, string titolo, string genere, int stagioni, int puntatemedie, double puntatamediapuntata)
        {
            Id = id;
            Titolo = titolo;
            Genere = genere;
            Stagioni = stagioni;
            Puntatemedie = puntatemedie;
            Puntatamediapuntata = puntatamediapuntata;
        }

        public SerieTV() { }

        public void NewFromDictionary(Dictionary<string, string> riga)
        {
            Id = int.Parse(riga["id"]);
            Titolo = riga["titolo"];
            Genere = riga["genere"];
            Stagioni = int.Parse(riga["genere"]);
            Puntatemedie = int.Parse(riga["puntatemedie"]);
            Puntatamediapuntata = double.Parse(riga["puntatamediapuntata"]);
        }

    }//fine classe
}
