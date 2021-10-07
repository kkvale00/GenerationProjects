using System;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            DAODipendente d = new DAODipendente("company");
           
            //foreach (Dipendente dp in d.LeggiTutto())
            //Console.WriteLine(dp.ToString());
            Dipendente dip = new Dipendente(0, "pino", "pane", "1987/12/2", 2541, "URP");
            Console.WriteLine( $":insert riuscito?"); d.Create(dip);

            
            }
        }
    }
}
