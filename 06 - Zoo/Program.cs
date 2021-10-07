using System;

namespace _06___Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Animale a in DAOAnimali.GetInstance().Elenco())
                Console.WriteLine(a.ToString());
            
        }
    }
}
