using System;

class Program
{
    static void Main()
    {
        // Wybór kierunku konwersji
        Console.WriteLine("Wybierz kierunek konwersji:");
        Console.WriteLine("C - Celsjusz na Fahrenheit");
        Console.WriteLine("F - Fahrenheit na Celsjusz");
        string wybor = Console.ReadLine().ToUpper();

        // Sprawdzanie, czy użytkownik podał poprawny wybór
        if (wybor == "C" || wybor == "F")
        {
            // Wprowadzenie temperatury przez użytkownika
            Console.Write("Podaj wartość temperatury: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (wybor == "C")
            {
                // Konwersja Celsjusza na Fahrenheita
                double fahrenheit = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"Temperatura {temperatura}°C to {fahrenheit}°F");
            }
            else if (wybor == "F")
            {
                // Konwersja Fahrenheita na Celsjusza
                double celsius = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"Temperatura {temperatura}°F to {celsius}°C");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór! Wprowadź 'C' lub 'F'.");
        }
    }
}
