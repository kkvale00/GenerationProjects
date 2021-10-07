using System;
using System.Collections.Generic;
using System.Text;

namespace _02___EserciziVettori
{
    class Metodi
    {
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        /*
        scrivere un metodo nella classe Metodi
        questo si chiama Calcolo1, void
        2 parametri: vettore interi numero intero
        il metodo conta quante compare il singolo numero nel vettore
        e stampa "il numero [x] compare [x] volte nel vettore
        */

        public static void Calcolo1(int[] numeri,int n)
        {
            int conta = 0;

            for (int i = 0; i < numeri.Length; i++) //===>foreach(int numero in numeri)
            {
                if (numeri[i] == n)                 //===>if(numero == n)
                                                    //       conta;
                    conta++;
            }

            Console.WriteLine($"il numero {n} compare {conta} volte nel vettore");
        }

        //scriviere un metodo statico di tipo int di nome media
        //questo metodo prende come parametro 3 numeri interi
        //restituisce la media tra il numero maggiore e il numero minore
        //stamp that shit
        public static int Media(int a, int b,int c)
        {
            int max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;

            int min = a;

            if (b < min)
                min = b;
            if (c < min)
                min = c;


            return (max + min) / 2;
        }


        //scrivere un metodo statico di tipo int[] di nome modifica
        // riceve come parametro int
        //questo metodo guarda uno ad uno tutti i numeri contenuti nel parametro
        //se il numero è pari non fa niente, se il numero è dispari lo aumenta di 1
        //infine restituisce il vettore modificato

        public static int[] Modifica(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 1)
                    vet[i]++;
            }

            return vet;
        }







    }
}
