using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Utility
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public Entity() { }

        public Entity(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            string ris = "";

            foreach (PropertyInfo proprieta in this.GetType().GetProperties())
                ris += proprieta.Name + " : " + proprieta.GetValue(this) + "\n";

            return ris;
        }

        //questo metodo riceve come parametro in ingresso un dizionario
        //ricevera la riga della tabella di un database e valorizzera le proprieta pescandole
        //dal dictionary

        public void FromDictionary(Dictionary<string,string> riga)
        {
            //Guardare una ad una tutte le proprietà dell'oggetto
            //Prenderò la singola proprietà e cercherò la chiave con quel nome
            //Dovrò valorizzare la proprietà con il valore contenuto in riga

            foreach (PropertyInfo proprieta in this.GetType().GetProperties())
            {
                if (riga.ContainsKey(proprieta.Name.ToLower()))
                {
                    object valore = riga[proprieta.Name.ToLower()];

                    switch (proprieta.PropertyType.Name.ToLower())
                    {
                        case "datetime":
                            valore = DateTime.Parse(riga[proprieta.Name.ToLower()]);
                            break;

                        case "int32":
                            valore = int.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                        case "double":
                            valore = double.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                        case "boolean":
                            valore = bool.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                    }
                    proprieta.SetValue(this, valore);
                }

            }
        }








    }//fine classe  
}
