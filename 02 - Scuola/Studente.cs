using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Scuola
{
    class Studente : Persona
    {
        private int classe;
        private int votoMat;
        private int votoIta;
        private int votoSto;
        private int votoIng;


        public Studente(string cognome, string dob, string sesso, string residenza,
                        int classe, int votoMat, int votoSto, int votoIta, int votoIng)
                       : base(cognome, dob, sesso, residenza)
        {
            Classe = classe;
            VotoMat = votoMat;
            VotoIta = votoIta;
            VotoSto = votoSto;
            VotoIng = votoIng;
        }

        public int Classe { get => classe; set => classe = value; }
        public int VotoMat { get => votoMat; set => votoMat = value; }
        public int VotoIta { get => votoIta; set => votoIta = value; }
        public int VotoSto { get => votoSto; set => votoSto = value; }
        public int VotoIng { get => votoIng; set => votoIng = value; }

        public override string Scheda()
        {
            return base.Scheda() +
                   $"Classe: {classe} \n"  +
                   $"voto mate: {votoMat}\n" +
                   $"voto ita: {votoIta}\n" +
                   $"voto sto: {votoSto}\n" +
                   $"voto ing: {votoIng}";

        }
        public double MediaVoti()
        {
            return (VotoMat + VotoIta + VotoSto + VotoIng) / 4;

        }

        //Il- fare il metodo bool Promosso() in Studente: uno studente viene promosso
        //se la sua media di voti è maggiore di 6 e ha al massimo 2 insufficienze
        //(voto < 6) di cui al massimo 1 insufficienza grave (voto < 5)

        //MAT = 5, ITA = 8, STO = 3, ING = 9
        public bool Promosso() => MediaVoti() >= 6 &&
                                    (
                                        (VotoMat < 6 ? 1 : 0) + //APRO IL TERNARIO PER VERIFICARE 
                                        (VotoIta < 6 ? 1 : 0) + //CHE NON CI SIANO + DI 2 VOTI < 6
                                        (VotoSto < 6 ? 1 : 0) +
                                        (VotoIng < 6 ? 1 : 0)
                                    ) <= 2
                                    &&
                                     (
                                        (VotoMat < 5 ? 1 : 0) + //APRO IL TERNARIO PER VERIFICARE 
                                        (VotoIta < 5 ? 1 : 0) + //CHE NON CI SIANO + DI 1 VOTI < 5
                                        (VotoSto < 5 ? 1 : 0) +
                                        (VotoIng < 5 ? 1 : 0)
                                    ) <= 1;

        public bool PromossoFor()
        {
            int votiInsufficienti = 0;
            int votiGravi = 0;

            int[] elencoVoti = { VotoMat, VotoIta, VotoSto, VotoIng };

            for (int i = 0; i < elencoVoti.Length; i++)
            {
                {
                    if (elencoVoti[i] < 6)
                        votiInsufficienti++;
                    if (elencoVoti[i] < 5)
                        votiGravi++;
                }

            }

                return MediaVoti() >= 6 && votiInsufficienti <= 2 && votiGravi <= 1;
        }


    }







    
}
