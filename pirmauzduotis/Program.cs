using System;
using System.Collections.Generic;

namespace pirmauzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> skaiciai; 
            double n;

            Console.WriteLine("Iveskite kiek bus is viso skaiciu(kiekis)");
            n = Convert.ToDouble(Console.ReadLine());

            skaiciai = ListoNuskaitymas(n);

            Console.WriteLine("-------------");

            IsvestiVisusListusForEach(skaiciai);
            IsvedaElementus(skaiciai);

           

            Console.WriteLine("-----------");

            NisvestiNulio(skaiciai);



            

            

           

         }
        static List<double> ListoNuskaitymas(double n)
        {
            List<double> listas = new List<double>();
            for (int i = 0; i < n; i++)
            {
                listas.Add(Convert.ToDouble(Console.ReadLine()));
            }
            return listas;
        }
        static void IsvestiVisusListusForEach(List<double> listas)
        {
            foreach (double skaiciai in listas)
            {
                Console.WriteLine(skaiciai);
            }

        }
        static void IsvedaElementus(List<double> listas)
        {
            for (int i = 0; i < listas.Count; i++) 
            {
                Console.WriteLine(i + ": " + listas[i]);
            }
        }
        static void NisvestiNulio(List<double> listas)
        {
            for (int i = 0; i < listas.Count; i++)
            {
                if (listas[i] != 0)
                {
                    Console.WriteLine(listas[i]);
                }
            }
        }

    }
}
