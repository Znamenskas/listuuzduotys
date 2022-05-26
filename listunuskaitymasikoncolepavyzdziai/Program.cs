using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai;
            int n;

            Console.WriteLine("Įveskite kiek bus iš viso pažymių (kiekį)");
            n = Convert.ToInt32(Console.ReadLine());

            pazymiai = ListoNuskaitymas(n);

            Console.WriteLine("------------------");

            IsvestiListaForEach(pazymiai);


            Console.WriteLine("Pažymių vidurkis yra: ");
            Console.WriteLine(ListoVidurkis(pazymiai));
            

        } 


        // Funkcija, kuri nuskaito duomenis iš konsolės ir juos išsaugo į listą
        static List<int> ListoNuskaitymas(int n)
        {
            List<int> listas = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listas.Add(Convert.ToInt32(Console.ReadLine()));

            }
            return listas;
        }


        // Papildoma funkcija, kuri išveda visus list'o elementus, BET NAUDOJA FOREACH CIKLĄ VIETOJ FOR CIKLO
        static void IsvestiListaForEach(List<int> listas)
        {

            // foreach (vidinisDuomenųTipas elementoPavaedinimas in sąrašoKintamojoPavadinimas)
            foreach (int elementas in listas)
            {
                Console.WriteLine(elementas);
            }
        }


        // Papildoma funkcija, kuri suranda listo sumą
        static int ListoSuma(List<int> listas)
        {
            int suma = 0;
            foreach (int elementas in listas)
            {
                suma += elementas;
            }
            return suma;
        }


        // Papildoma funkcija, kuri suranda listo vidurkį (ji naudoja taip pat ir kitą papildomą funkciją - ListoSuma)
        static double ListoVidurkis(List<int> listas)
        {
            double vidurkis;
            vidurkis = (double) ListoSuma(listas) / (double) listas.Count;
            Console.WriteLine(vidurkis);
            return vidurkis;
        }





    }
}