using System;
using System.Collections.Generic;
using System.Text;

namespace Prodotto
{
    class Prodotto
    {
        //Questo in C# si definisce field (campo)
        // andiamo a segnalare PUBLIC  tutte le proprieta'
        //in modo
        public string nome;
        public string categoria;
        public double prezzo;
        //una volta che si ha una classe la si puo' utilizzare nel proggetto

        public string Scheda() //non stampa su console, restiuisce una stringa.
        {
            //string ris =    "Nome :  " + nome + "\n"           +
            //                "Categoria :  " + categoria + "\n" +
            //                "Prezzo :  " + prezzo + "\n"       ;
            string ris = $"Nome: {nome}," +
                                $"\nCategoria: {categoria}," +
                                $"\nPrezzo: {prezzo}" +
                                $"\n----------------------------\n";
            // La parte sopra si puo' scrivere come prima con ($)
            return ris;
        }

    }
}