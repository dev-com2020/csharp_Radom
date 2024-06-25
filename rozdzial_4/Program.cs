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
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }
        static void while_demo()
        {
            int licznik = 0;
            while (licznik <= 10)
            {
                Console.WriteLine($"{licznik}");
                licznik++;
            }

        }

        static void do_while_demo()
        {
            int licznik = 0;
            do
            {
                if (licznik % 2 == 0)
                {
                    Console.WriteLine($"{licznik} jest parzysty");
                }
                else
                {
                    Console.WriteLine($"{licznik} jest nieparzysty");
                }
                licznik++;
            }
            while (licznik <= 10);
        }
        static void foreach_demo()
        {
            string[] languages = { "C#", "Python", "Java" };
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }
            var enumerator = languages.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        static void break_demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }
        }
        static void continue_demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        static void FunctionThatThrows(object o)
        {
            if (o is null)
                throw new ArgumentNullException(nameof(o));
            if (!(o is string))
                throw new ArgumentException("to nie jest string");
        }

        static void exceptions_demo()
        {
            try
            {
                Console.WriteLine("wykonuje program");
                FunctionThatThrows("Tomek");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }
            finally
            {
                Console.WriteLine("wykonałem program");
            }
        }


        static void Main(string[] args)
        {
            // if_demo();
            // switch_demo();
            // for_demo();
            // while_demo();
            // do_while_demo();
            // foreach_demo();
            // continue_demo();
            exceptions_demo();
        }
    }
}