using System;

class Program
{
    static void Main()
    {
        // Wprowadzenie liczby ocen
        Console.Write("Podaj liczbę ocen: ");
        int liczbaOcen = int.Parse(Console.ReadLine());

        // Deklaracja zmiennej do sumy ocen
        double sumaOcen = 0;

        // Pętla for do wprowadzenia ocen
        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę {i}: ");
            double ocena = double.Parse(Console.ReadLine());

            // Dodanie oceny do sumy
            sumaOcen += ocena;
        }

        // Obliczenie średniej
        double srednia = sumaOcen / liczbaOcen;

        // Wyświetlenie średniej
        Console.WriteLine($"Średnia: {srednia:F2}");

        // Sprawdzenie, czy uczeń zdał przedmiot
        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał przedmiot.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał przedmiotu.");
        }
    }
}
