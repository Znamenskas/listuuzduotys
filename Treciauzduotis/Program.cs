using System;
using System.Collections.Generic;

namespace Treciauzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> skaiciai;

            skaiciai = ListoNuskaitymas();
            
            IsvestiListaForEach(skaiciai);

            Console.WriteLine(NeigiamiSkaiciai(skaiciai));

            Console.WriteLine(NeigiamiSkaiciai(skaiciai));

            Console.WriteLine(TeigiamiSkaiciai(skaiciai));


            KiekisDidesnis(NeigiamiSkaiciai(skaiciai), TeigiamiSkaiciai(skaiciai));

           
        }

        static List<double> ListoNuskaitymas()
        {
            int kiekis;

            Console.WriteLine("Iveskite skaiciu kieki");
            kiekis = Convert.ToInt32(Console.ReadLine());




            List<double> listas = new List<double>();
            for (double i = 0; i < kiekis; i++)
            {
                listas.Add(Convert.ToDouble(Console.ReadLine()));
            }
            return listas;


        }
        static void IsvestiListaForEach(List<double>listas)
        {
            foreach (int elementas in listas)
            {
                Console.WriteLine(elementas);
            }
        }
        static int NeigiamiSkaiciai(List<double> listas)
        {
            int kiekis = 0;
            foreach (int elementas in listas)
            {
                if (elementas < 0)
                {
                    kiekis++;
                }
                
            }
            return kiekis;
        }
        static int TeigiamiSkaiciai(List<double> listas)
        {
            int kiekis = 0;
            foreach (int elementas in listas)
            {
                if (elementas > 0)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }

        
        static void  KiekisDidesnis( int x, int y)
        {
            if (x > y) 
            {
                Console.WriteLine("Teigiamu yra daugiau");
            }
            else if (x == y)
            {
                Console.WriteLine("Teigiamu ir neigiamu vienodai");
            }
            else 
            {
                Console.WriteLine("Neigiamu yra daugiau");
            }

        }
    }
}
