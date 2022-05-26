using System;
using System.Collections.Generic;

namespace antralistuuzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai;
            List<int> pazymiai2;
            int PirmasStudentas;
            int AntrasStudentas;

            Console.WriteLine("Pirmo studento pazymiu kiekis:");
            PirmasStudentas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pirmo studento pazymiai:");

            pazymiai = NuskaitoLista(PirmasStudentas);

            Console.WriteLine("Pirmo studento vidurkis yra:");
            PazymiuVidurkis(pazymiai);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Antro studento pazymiu kiekis:");
            AntrasStudentas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antro studento pazymiai:");

            pazymiai2 = NuskaitoLista(AntrasStudentas);
            Console.WriteLine("Antro studento pazymiu vidurkis yra:");
            PazymiuVidurkis(pazymiai2);

            Console.WriteLine("Kurio studento vidurkis didesnis");
            DidesnisVidurkis(PazymiuVidurkis(pazymiai),PazymiuVidurkis(pazymiai2) );
        }

        static List<int> NuskaitoLista(int x)
        {
            List<int> listas = new List<int>();
            for (int i = 0; i < x; i++)
            {
                listas.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return listas;
        }
        static int PazymiuSuma(List<int> listas)
        {
            int suma = 0;
            foreach (int elementas in listas)
            {
                suma += elementas;
            }
            return suma;

        }
        static double PazymiuVidurkis(List<int> listas)
        {
            double vidurkis;
            vidurkis = (double)PazymiuSuma(listas) / (double)listas.Count;
            Console.WriteLine(vidurkis);
            return vidurkis;
        }
        static void DidesnisVidurkis(double x, double y)
        {
            if (x == y)
            {
                Console.WriteLine("Pirmo studento vidurkis lygus Antro studento vidurkis");
            }
            else if (x > y)
            {
                Console.WriteLine("Pirmo studento vidurkis didesnis ");
            }
            else if (x < y)
            {
                Console.WriteLine("Pirmo studento vidurkis mazesnis uz Antro studento vidurkis");

            }
        }
    }
}
