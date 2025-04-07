# Pobranie dwóch liczb od użytkownika
liczba1 = float(input("Podaj pierwszą liczbę: "))
liczba2 = float(input("Podaj drugą liczbę: "))

# Pobranie operacji od użytkownika
operacja = input("Wybierz operację (+, -, *, /): ")

# Sprawdzenie wybranej operacji i wykonanie odpowiedniego działania
if operacja == "+":
    wynik = liczba1 + liczba2
    print("Wynik dodawania:", wynik)
elif operacja == "-":
    wynik = liczba1 - liczba2
    print("Wynik odejmowania:", wynik)
elif operacja == "*":
    wynik = liczba1 * liczba2
    print("Wynik mnożenia:", wynik)
elif operacja == "/":
    if liczba2 != 0:
        wynik = liczba1 / liczba2
        print("Wynik dzielenia:", wynik)
    else:
        print("Błąd: nie można dzielić przez zero.")
else:
    print("Nieznana operacja.")

