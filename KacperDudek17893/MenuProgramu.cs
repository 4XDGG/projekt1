using System;

namespace KacperDudek17893
{
    class MenuProgramu : DaneStatystyk //zawarte jest tu menu programu
    {
        public void Menu()
        {
            Operacje Op = new Operacje();
            Rozgrywka Gra = new Rozgrywka();
            string Opcja; //zadeklarowanie zmiennej Opcja
            do
            {
                Statystyki = "Liczba gier: " + LiczbaGier + "\nWygrane: " + Wygrane + " | Przegrane: " + Przegrane + " | Remis: " + Remis + "\nWspolczynnik wygranych: " + WinRate + "%\n"; //przpisanie do zmiennej globalnej Statystyki danych o statystykach
                Console.WriteLine("MENU\n1.Graj\n2.Pokaz wynik\n3.Zapisz wynik\n4.Wczytaj wynik z pliku"); //menu wyboru operacji
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5.Wyjdź\n");
                Console.ResetColor();
                Console.Write("Wybierz pozycje z menu: ");
                Opcja = Convert.ToString(Console.ReadLine()); //wybranie pozycji z menu
                switch (Opcja)
                {
                    case "1": //opcja odpowiedzialna za rozpoczęcie gry
                        Console.Clear();
                        Gra.Game(); //wywołanie metody Game z klasy Rozgrywka
                        break;
                    case "2": //opcja odpowiedzialna za wyświetlenie obecnych statystyk
                        Console.Clear();
                        Console.WriteLine($"STATYSTYKI:\n\n{Statystyki}");
                        break;
                    case "3": //opcja odpowiedzialna za zapis wyników gry do pliku
                        Console.Clear();
                        Op.Zapis(Statystyki); //wywołanie metody Zapis z klasy Operacje
                        break;
                    case "4": //opcja odpowiedzialna za odczyt zapisanych wyników gry z pliku
                        Console.Clear();
                        Op.Odczyt(); //wywołanie metody Odczyt z klasy Operacje
                        break;
                    default: //wyswietlenie błędu, jęsli użytkownik wybrał złą opcję
                        Console.Clear();
                        Console.WriteLine("Blad! Nie ma takiej pozycji w menu\n");
                        break;
                }
            } while (Opcja != "5");
            Console.Clear();
            Console.WriteLine("Program zakończył działanie!");
        }
    }
}
