using System;

namespace rozdzial_4
{
    class Program
    {
        static void if_demo()
        {
            Console.WriteLine("Wpisz liczbę:");
            var line = Console.ReadLine();
            int.TryParse(line, out int number);
            if (number % 2 == 0)
            {
                Console.WriteLine("Parzyste");
            }
            else
            {
                Console.WriteLine("Nieparzyste");
            }
        }
        static void switch_demo()
        {
            Console.WriteLine("Podaj liczbę(1-10):");
            var line = Console.ReadLine();
            int.TryParse(line, out int number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("Jest to jeden");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("liczby pierwsze");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Liczby parzyste");
                    break;
                case 9:
                    Console.WriteLine("Liczba 9");
                    break;
                default:
                    Console.WriteLine("Liczba nie pasuje do zasięgu");
                    break;

            }
        }

        static void for_demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} jest liczbą parzystą");
                }
                else
                {
                    Console.WriteLine($"{i} jest liczbą nieparzystą");
                }
            }
        }


        static void Main(string[] args)
        {
            // if_demo();
            // switch_demo();
            for_demo();
        }
    }
}