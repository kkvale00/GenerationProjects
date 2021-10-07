using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace _03___CinemaReflection
{
    abstract class Entity
    {
        public int Id {get; set;}

        public Entity() { }

        public Entity(int id)
        {
            this.Id = id;
        }




        public override string ToString()
        {
            string ris = "";


            //PropertyInfo è un oggetto che conterra tutte le informazioni
            //di una proprietà
            //this.GetType().GetProprierties();
            //this -> indica Entity
            //GetType -> e un metodo che si trova nella classe object che ci restituisce
            //           un oggetto di tipo Type
            //GetProperties() -> e un metodo che si trova nella classe Type e ci restituisce
            //                   un vettore di oggetti PropertyInfo
            foreach (PropertyInfo proprieta in this.GetType().GetProperties())
                ris += proprieta.Name + " : " + proprieta.GetValue(this) + "\n";


            // proprieta.Name prende il nome della proprietà (al primo giro sarà "Id")
            // proprieta.GetValue(this) : vai a prendere il valore della proprietà che
            // stai ciclando ("Id") dall'oggetto this (l'oggetto sul quale è
            // stato chiamato il metodo ToString






            return ris;
        }
















    }//fine classe
}
