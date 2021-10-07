using System;
using System.Collections.Generic;
using System.Text;

namespace _02___EserciziVettori
{
    class Persona
    {
        public string nome;
        public string cognome;
        public int eta;

        //questo campo è statico, comune per tutta la categoria di persone
        public static int etaMax = 120;



        //const = costante, rimane invariato nel tempo
        //ogni variabile dichiarata con const sarà anche static
        public const int ETAMAX = 120;


    }
}
