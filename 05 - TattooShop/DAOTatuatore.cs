using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace _05___TattooShop
{   

    //Voglio che all'interno del mio programma ci sia soltanto un DAOTatuatore, perché
    //mi basta un singolo oggetto di questo tipo per fare tutte le operazioni di cui ho
    //bisogno. Ricorriamo dunque al pattern Singleton.
    //Un pattern consiste in una soluzione standard ad un problema ricorrente in programmazione.
    //Il problema nel nostro caso: vogliamo un solo oggetto DAOTatuatore
    //Soluzione: applichiamo il pattern Singleton
    //Per applicare il pattern Singleton abbiamo 3 step da seguire:
    //1) Rendere privato il costruttore della classe
    //2) Definire un oggetto statico dello stesso tipo del Singleton uguale a null
    //3) Creare un metodo che una volta richiamato controlla se l'instance è uguale a null
    //   nel caso dovesse esserlo lo crea (new DAOTatuatore), successivamente lo restituisce
    //   N.B. Quell'if fa si che l'instance venga inizializzato solo la prima volta che questo
    //   metodo viene richiamato

    class DAOTatuatore
    {
        private Database db;

        //instance e' una variaible statica che conterra
        //l'unico oggetto DAOTtatuatore esistente nel nostro programma
        //Inizialmente e vuota
        private static DAOTatuatore instance = null;

        //il csotruttore e privato perche vogliamo vietare a chiunmque altro
        //di creare istanze di DAOTatuatore, questa classe e' l'unica che ne e in grado
        //il resto del costruttore e uguale al solito
        private DAOTatuatore()
        {
            db = new Database("tattoostudio");

        }

        public static DAOTatuatore GetInstance()
        {
            if (instance == null)
                instance = new DAOTatuatore();

            return instance;
        }

        public Tatuatore Cerca(int id)
        {
            string query = "select * from tatuatori where id = " + id;

            Dictionary<string,string> riga = db.ReadOne(query);

            Tatuatore t = new Tatuatore();
            t.FromDictionary(riga);



            return t;

        }

        public bool Delete(int id)
        {
            return db.Update($"delete from tatuatori where id = {id}");
        }

        public bool Update(Tatuatore t)
        {
            string query = $"update tatuatori set nome = '{t.Nome}', cognome = '{t.Cognome}'," +
                           $" dob = '{t.Dob.Year}-{t.Dob.Month}-{t.Dob.Day}'," +
                           $" anniesperienza = {t.AnniEsperienza} where id = {t.Id}";


          return db.Update(query);
        }

        public bool Insert(Tatuatore t)
        {
            string query = "insert into tatuatori" +
                           $"(nome,cognome,dob,residenza,anniesperienza) values ('{t.Nome}','{t.Cognome}'," +
                           $"'{t.Dob.Year}-{t.Dob.Month}-{t.Dob.Day}','{t.Residenza}'," +
                           $"{t.AnniEsperienza});";

            return db.Update(query);
        }
    }//fine classe
}
