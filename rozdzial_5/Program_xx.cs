using System;
using System.Collections.Generic;

namespace ApkKonsolowa
{
    internal static class Program_xx
    {
        private const int NumberOfElements = 5;

        private static int[] _integerArray = new int[NumberOfElements]; 

        public static void Main(string[] args)
        {
            Console.WriteLine("Wczytywanie 10 liczb z klawiatury: ");
            
            for (var i = 0; i < NumberOfElements; i++)
            {
                var add = int.Parse(Console.ReadLine());

                _integerArray[i] = add;
            }
            
            SelectionSort(_integerArray);
            
            Console.WriteLine("Po sortowaniu: ");
            
            foreach (var item in _integerArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Najwieksza liczba w tablicy: ");
            Console.WriteLine(GetHighestNumber(_integerArray));
        }

        private static int[] SelectionSort(int[] list)
        {
            for (var i = 0; i < NumberOfElements - 1 ; i++)
            {
                var max = i;

                for (var j = i + 1 ; j < NumberOfElements; j++)
                {
                    if (list[max] < list[j])
                        max = j;
                }
                
                (list[max], list[i]) = (list[i], list[max]);
            }

            return list;
        }

        private static int GetHighestNumber(IList<int> list)
        {
            return list[0];
        }
    }
}