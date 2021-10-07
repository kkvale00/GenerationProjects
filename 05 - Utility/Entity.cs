using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace _05___Utility
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
                ris += proprieta.Name + " : " + proprieta.GetValue(this) + "\n";

            return ris;
        }

    }//fine classe  
}
