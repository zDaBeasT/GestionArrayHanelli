using System;
using LibreriaArray;

namespace InvocaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti elementi vuoi?");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            GestioneArray.LeggiArray(a);
            int[] nuovoArray = GestioneArray.CopiaArray(a);
            GestioneArray.StampaArray(nuovoArray);
            bool trovato = GestioneArray.RicercaArray(a, 4);
            Console.WriteLine("Trovato: " + trovato);
            Console.ReadLine();
        }
    }
}
