using System;

//Tutto il codice che va dall'apertura alla chiusura di una parentesi graffa viene
//definito come blocco di codice.

namespace HelloWorld //Questo è un commento, il namespace indica il nome del Progetto
{
    class Program //E' il nome della classe, spesso combacia con il nome del file (program.cs)
    {
        //Main indica che qui dentro c'è il codice che il programma eseguirà quando sarà fatto partire.
        //Cliccando su "play" nel menu in alto Visual studio eseguirà tutto il codice del Main. 
        static void Main(string[] args) 
        {
            //Console.Writeline serve a stampare quello che mettiamo tra le parentesi tonde
            //Ogni volta che vederete del testo esso sarà scritto SEMPRE tra " ... "
            Console.WriteLine("Hello World!");

            //C# fa schifo perché quando il programma termina chiude automaticamente la console senza
            //che io possa fermarmi a vedere il risultato. Con questo comando dico al programma di 
            //aspettare che io scriva qualcosa nella console. Nel momento in sui scrivo il programma termina.
           Console.ReadKey();
        }
    }
}