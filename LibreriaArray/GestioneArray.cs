using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            Console.WriteLine($"Inserisci {array.Length} elementi");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
                array[i] = n;
            }
        }

        public static void StampaArray(int[] array)
        {
            Console.Write("L'array contiene: ");
            for (int i = 0; i< array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public static int[] CopiaArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public static bool RicercaArray(int[] array, int chiave)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length && !trovato; i++)
            {
                if (array[i] == chiave)
                {
                    trovato = true;
                }
            }
            return trovato;
        }
    }
}
