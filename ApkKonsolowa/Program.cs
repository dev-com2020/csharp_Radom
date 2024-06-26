using System;
using System.Collections.Generic;

namespace ApkKonsolowa
{
    internal static class Program
    {
        private const int NumberOfElements = 5;

        private static int[] _integerArray = new int[NumberOfElements]; 

        public static void Main(string[] args)
        {
            Console.WriteLine("Wczytywanie 5 liczb z klawiatury: ");
            
            for (var i = 0; i < NumberOfElements; i++)
            {
                var add = int.Parse(Console.ReadLine());

                _integerArray[i] = add;
            }
            
            Array.Sort(_integerArray);
            
            Console.WriteLine("Po sortowaniu: ");
            
            foreach (var item in _integerArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Najwieksza liczba w tablicy: ");
            Console.WriteLine(GetHighestNumber(_integerArray));
        }

        private static int GetHighestNumber(int[] list)
        {
            int max = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}