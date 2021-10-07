using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Utility
{
    abstract class Entity
    {
        public int Id { get; set; }

        public Entity() { }

        public Entity(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            string ris = "";

            foreach (PropertyInfo proprieta in this.GetType().GetProperties())
                ris += proprieta.Name.ToLower() + " : " + proprieta.GetValue(this) + "\n";

            return ris;
        }

    }//fine classe  
}
