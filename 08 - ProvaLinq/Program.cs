using System;
using System.Collections.Generic;
using System.Linq;

namespace _08___ProvaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Azienda az = new Azienda();
            
            //stampa dipendenti over 30
            //foreach (Dipendente dip in az.dipendenti)
            //    if (dip.eta >= 30)
            //        Console.WriteLine(dip.nome);
            //ora faccio una magia.LINQ 'spe
            //IEnumerable<string>
            var over30 =
                from dip in az.dipendenti
                where dip.eta >= 30
                select dip.nome;

            foreach(string nome in over30)
                Console.WriteLine(nome);

            //stampare in ordine alfabetico i nomi degli over 18 residenti a milano
            var alfa18milano =
                from dip in az.dipendenti
                where dip.residenza.ToLower() == "milano" && dip.eta >= 18
                orderby dip.nome //o discending se decrescente
                select dip.nome;
            Console.WriteLine("===QUERY ALFABETICO 18MILANO===");
            foreach(string nome in alfa18milano)
                Console.WriteLine(nome);

            //contare quanti dipendenti ci sono per ogni reparto
            var dipendentiPerReparto =
                from dip in az.dipendenti
                group dip by dip.reparto;




            foreach(var gruppo in dipendentiPerReparto)
            {
                Console.WriteLine("=========");
                Console.WriteLine(gruppo.Key);

                int contatoregruppo = 0;
                foreach(var dip in gruppo)
                Console.WriteLine(gruppo);
                    contatoregruppo++;
                Console.WriteLine($"Dipendenti: {contatoregruppo}");
            }


        }
    }
}
