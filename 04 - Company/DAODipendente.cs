using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class DAODipendente
    {
        private Database db;

        public DAODipendente(string nomeDB)
        {
            db = new Database(nomeDB);
        }


        public List<Dipendente> LeggiTutto()
        {

            List<Dipendente> ris = new List<Dipendente>();

            string query = "select * from dipendenti";

            List<Dictionary<string,string>> righe = new List<Dictionary<string, string>>();

            righe = db.Read(query);

            foreach (Dictionary<string,string> riga in righe)
            {
                Dipendente d = new Dipendente();

                d.FromDictionary(riga);

                ris.Add(d);
            }
            return ris;
        }

        public bool Create(Dipendente d)
        {
            string query = $"insert into dipendenti (nome,cognome,dob,stipendio,reparto) " +
                           $"values ('{d.Nome}', '{d.Cognome}', '{d.Dob}','{d.Stipendio}','{d.Reparto}'";



            return db.Update(query);
        }

        public bool UpdateDipendente(Dipendente d)
        {
            string query = $"update dipendenti" +
                           $"Nome = '{d.Nome}', cognome = { d.Cognome }," +
                           $" dob = '{d.Dob}', stipendio = {d.Stipendio}" +
                           $" where id = {d.Id}"; 

            return db.Update(query);
        }

        public bool DeleteCliente(int id)
        {

            string query = $"delete from dipendenti where id = {id}";

            return db.Update(query);
        }

        public string MaxStipendio()
        {
            string ris = "";
            string query = "select nome, stipendio from dipendenti" +
                          " where stipendio = (select max(stipendio) from dipendenti);";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach (Dictionary<string, string> riga in righe)
                ris += riga["nome"] + " " + riga["cognome"] + ":" + riga["stipendio"] + "euro";

            return ris;
           
        }

        public List<Cliente> CercaCliente(string cognome)
        {

            List<Cliente> ris = new List<Cliente>();

            string query = $"select * f4rom clienti where cognome = '{cognome}'";

            List<Dictionary<string, string>> righe = db.Read(query);

            foreach(Dictionary<string,string> riga in righe)
            {
                Cliente c = new Cliente();

                c.FromDictionary(riga);

                ris.Add(c);

            }

            return ris;
        }

    }//fine classe
}
