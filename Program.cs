using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== Prosty Kalkulator ==");

        // Pobranie pierwszej liczby
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        // Pobranie drugiej liczby
        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        // Pobranie operacji
        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik = 0;
        bool poprawnaOperacja = true;

        // Wybór działania
        if (operacja == "+")
        {
            wynik = liczba1 + liczba2;
        }
        else if (operacja == "-")
        {
            wynik = liczba1 - liczba2;
        }
        else if (operacja == "*")
        {
            wynik = liczba1 * liczba2;
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
                wynik = liczba1 / liczba2;
            else
            {
                Console.WriteLine("Błąd: Dzielenie przez zero!");
                poprawnaOperacja = false;
            }
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
            poprawnaOperacja = false;
        }

        // Wyświetlenie wyniku
        if (poprawnaOperacja)
        {
            Console.WriteLine($"Wynik: {wynik}");
        }
    }
}
