using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Scuola
{
    class Insegnante : Personale
    {
        private int nClassi;
        private string[] materieInsegnate;

        public Insegnante(string cognome, string dob, string sesso, string residenza, string dataAssunzione,
                          int nClassi, string[] materieInsegnate)
                        : base(cognome, dob, sesso, residenza, "Insegnante", dataAssunzione)
        {
            NClassi = nClassi;
            MaterieInsegnate = materieInsegnate;
        }

        public int NClassi { get => nClassi; set => nClassi = value; }
        public string[] MaterieInsegnate { get => materieInsegnate; set => materieInsegnate = value; }

        public override string Scheda()
        {
            string materie = "";

            for (int i = 0; i < MaterieInsegnate.Length; i++)
            {
                materie += MaterieInsegnate[i] + "\n";
            }
            return base.Scheda() +
                   $"Classi: {nClassi} \n" +
                   $"Materie Ins.: {materie} \n";
        }

        public override double Stipendio()
        {
            bool sto = false;
            bool lat = false;
            bool gre = false;
            bool sci = false;
            bool mat = false;

            //Controllerò una ad una tutte le materie
            //Se trovo tra le materie insegnate "storia" allora il mio bool sto diventerà true
            for (int i = 0; i < MaterieInsegnate.Length; i++)
                switch (MaterieInsegnate[i].ToLower())
                {
                    case "storia":
                        sto = true;
                        break;
                    case "latino":
                        lat = true;
                        break;
                    case "greco":
                        gre = true;
                        break;
                    case "sci":
                        sci = true;
                        break;
                    case "mat":
                        mat = true;
                        break;
                }
            return (base.Stipendio() + (20 * NClassi) + (25 * MaterieInsegnate.Length))
                                * (sto ? 1.1 : 1)
                                * (lat || gre ? 1.15 : 1)
                                * (sci && mat ? 1.2 : 1)
                                ;
        }

        public bool Insegna(string materia)
        {
            bool insegna = false;

            for (int i = 0; i < MaterieInsegnate.Length; i++)
            {
                if (MaterieInsegnate[i].ToLower() == materia)
                    insegna = true;
            }

            return insegna;
        }

        public bool Insegna(string[] m) //yari sei stronzo, matrioske di vettori
        {
            for (int i = 0; i < m.Length; i++)
            {
                bool insegnata = false;
                for (int j = 0; j < MaterieInsegnate.Length; j++)
                
                    if (m[i] == MaterieInsegnate[j])
                    {
                        insegnata = true;
                    }
                if (insegnata == false)
                    return false;
            }
            return true;
        }


    }
}
