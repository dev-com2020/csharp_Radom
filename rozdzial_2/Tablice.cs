using System;
using System.Collections.Generic;

namespace rozdzial_2
{
    public static class Tablice
    // dodajemy metodę GET oraz dodajemy metodę która wydrukuje tablice
    {
        public static string[] GetArray(){
            return new string[] { "Tomek","Janek","Franek" };
        }
        public static void PrintArray(string[] array){
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }





//         int[] tablica1;
//         int[] tablica2 = null;
//         int[] tablica3 = new int[6];

//         int[] tablica4 = new int[] { 22, 33, 44, 55, 66 };

//         int[] tablica5 = new int[3] { 3, 4, 5 };

//         int[] tablica6 = { 34, 56, 78, 90 };

//         // tablice wielowymiarowe

//         int[,] arr1;
//         int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//         int[,] arr3 = null;
//         int[,] arr4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
//         int[,] arr5 = new int[2, 3];
//         int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };

//         int[,,] arr7 = new int[4, 3, 2]
//         {
//     { {1,2},{1,2},{1,2} },
//     { {1,2},{1,2},{1,2} },
//     { {1,2},{1,2},{1,2} },
//     { {1,2},{1,2},{1,2} },
//         };
//         int[][] parr1;
//         int[][] parr2 = null;
//         int[][] parr3 = new int[2][];

//         parr3[0] = new int[3] {1,2,3};
//     parr3[1] = new int[] {3,4,5,6,7};


// List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
// lista.Add(354);

// niejawna konwersja
// int i = 10;
// float f = i;

// string s = "example";
// object o = s;
// jawna konwersja
// double d = 12.34;
// int j = (int)d;

}

}

// https://github.com/dev-com2020/csharp_Radom