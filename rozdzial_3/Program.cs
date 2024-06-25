using System;

namespace rozdzial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ++a; // to oznacza a = a + 1
            Console.WriteLine(a);
            int b = 42;
            bool v1 = a != b;
            bool v2 = 0 <= a && a <=100;
            Console.WriteLine(v2);
            bool b1 = true, b2 = false;
            bool c = b1 && b2;
            bool d = b1 || !b2;
            Console.WriteLine(d);

            static int max(int liczba1,int liczba2)
            {
                return liczba1 >= liczba2 ? liczba1 : liczba2;
            }

            int wynik = max(10,20);
            Console.WriteLine("Większa liczba: " + wynik);
        }
    }
}