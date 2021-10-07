using System;
using System.Collections.Generic;
using System.Text;

namespace ItaliaTeam
{
    class Atleta : Entita
    {
        string nominativo;
        int yob;
        string sesso;

        public Atleta(int matricola, string specialita, int piazzamento, string nominativo, int yob, string sesso)
                        : base(matricola, specialita, piazzamento)
        {
            Nominativo = nominativo;
            Yob = yob;
            Sesso = sesso;
        }

        public string Nominativo { get => nominativo; set => nominativo = value; }
        public int Yob { get => yob; set => yob = value; }
        public string Sesso { get => sesso; set => sesso = value; }

        public override string ToString()
        {
            return base.ToString()+
                   $"nominativo: {nominativo}\n" +
                   $"anno di nascita: {yob}\n" +
                   $"sesso: {sesso}\n";
        }

        public virtual int Eta()
        {
            return 2021 - yob;

        }


    }//fine classe
}
