using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Utility;
namespace _09___LibreriaCarol
{
    class Libro : Entity
    {
        public Libro() { }

        public Libro(int id, string titolo, string autore, string genere, int annopubblicazione, string lingua)
                   :base(id)
        {
            Titolo = titolo;
            Autore = autore;
            Genere = genere;
            Annopubblicazione = annopubblicazione;
            Lingua = lingua;
        }

        public string Titolo {get;set;}    
        public string Autore {get;set;}    
        public string Genere {get;set;}    
        public int Annopubblicazione {get;set;}
        public string Lingua { get; set; }

        public List<Libro> libro;

        public Libro(string path)
        {
            libro = new List<Libro>();

            if (File.Exists(path))
            {
                string[] righe = File.ReadAllLines(path);

                for (int i = 0; i < righe.Length; i++)
                {
                    string[] riga = righe[i].Split(",");

                    switch (riga[0].ToLower())
                    {
                        case "libro":
                            libro.Add(new Libro
                                (
                                    int.Parse(riga[1]),
                                    riga[2],
                                    riga[3],
                                    riga[4],
                                    int.Parse(riga[5]),
                                    riga[6]
                                )
                                );
                        break;
                    }
                }
            }
        }

        //public override string ToString()
        //{
        //    string ris = "";

        //    foreach(Libro l in libro)
        //        ris+=$"Id: {l.Id} \n" +
        //             $"Titolo: {l.Titolo}\n" +
        //             $"Autore: {l.Autore}\n" +
        //             $"Genere: {l.Genere}\n" +
        //             $"Anno: {l.Annopubblicazione}\n" +
        //             $"Lingua: {l.Lingua} \n\n";

        //    return ris;
        //}
     


    }
}
