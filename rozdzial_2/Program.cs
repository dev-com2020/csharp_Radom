using System;

namespace rozdzial_2
{
class Program {
    static void Main(string[] args) {
        int wiek = 41;
        wiek = 234;
        float temp = 22.30f;
        decimal liczba = 42.99m;
        char a = 'A';
        string imie = "Tomek";
        var nazwisko = "Kaniecki";
        var b = 12.45m;
        var s1 = "To jest program \"demo\"";
        bool czy_pali;
        czy_pali = false;
        const int bb = 44;
        DateTime dt = new DateTime(2024,06,24);
        int? cyfra;
        int? cyfra2 = 42;
        int? cyfra3 = null;
        // int cyfra4 = null;

        // Console.WriteLine("Wartosc zmiennej dt: "+ dt);
        // Console.WriteLine("Wartosc zmiennej s1: "+ s1);
        // Console.WriteLine("Wartosc zmiennej wiek: "+ wiek);
        // Console.WriteLine($"Wartosc zmiennej wiek: {wiek}");
        // Console.WriteLine("Wartosc zmiennej temp: "+ temp);
        // Console.WriteLine("Wartosc zmiennej liczba: "+ liczba);
        // Console.WriteLine("Dlugosc zmiennej imie: "+ imie.ToUpper());

        int[] array = Tablice.GetArray();
        Console.WriteLine("Tablica z innego pliku:");
        Tablice.PrintArray(array);
   
    }
}
}