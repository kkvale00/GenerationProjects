using System;
using System.Collections.Generic;
using System.Text;
using Utility;
namespace Utility
{
    public interface IDAO
    {
        //l'interfaccia è un contratto. E un file ccontiene X metodi
        //che dovranno essere concretizzati nelle classi che implementano l'interfaccia.
        public Entity Cerca(int id);
        public List<Entity> Elenco();
        public bool Insert(Entity e);
        public bool Update(Entity e);
        public bool Delete(int id);


    }//fine interfaccia
}
