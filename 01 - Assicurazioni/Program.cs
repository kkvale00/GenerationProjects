using System;

namespace _01___Assicurazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            DAOAssicurazione daoa = new DAOAssicurazione();

           
            Console.WriteLine(daoa.CostoMax().ToString());

        

            Console.ReadKey();
        }
    }
}