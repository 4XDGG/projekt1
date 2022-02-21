using System;

namespace KacperDudek
{
    class Rozgrywka : DaneStatystyk
    {
        public void Game()
        {
            LiczbaGier = 0;
            Wygrane = 0;
            Przegrane = 0;
            Remis = 0;
            WinRate = 0; //przpisanie zmiennym wartości 0 w celu wyczyszczenia statystyk z poprzedniej rozgrywki
            string Wybor; //zmienna Wybor odpowiedzialna za wybór opcji
            Console.WriteLine(Statystyki);
            do
            {
                Console.WriteLine("1.Papier\n2.Kamien\n3.Nozyce\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("4.Zakończ\n");
                Console.ResetColor();
                Console.Write("Wybierz opcje: ");
                Wybor = Convert.ToString(Console.ReadLine());
                if (Wybor == "1" || Wybor == "2" || Wybor == "3")
                {
                    Console.Clear();
                    Partia(Wybor);
                }
                else if (Wybor == "4")
                {
                    Console.Clear();
                    Console.WriteLine($"Rozgrywka zostala zakonczona! Statystyki:\n\n{Statystyki}\nCzy chcesz je zapisac?\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Blad! Nie ma takiej opcji!\n");
                    Console.WriteLine(Statystyki);
                }
            } while (Wybor != "4");
        }
        static void Partia(string Wybor)
        {
            Przebieg Prb = new Przebieg(); //utworzenie obiektu Przebieg
            string znakP = Prb.WyborPrzeciwnika();
            Prb.Rozgrywka(Wybor, znakP);
            string WynikZ = Prb.WynikZwrotny(znakP, Wybor);
            Console.WriteLine($"\n{WynikZ}\n"); //wypisanie wyniku rozgrywki

            LiczbaGier++;

            if (WynikZ == "WYGRANA")
                Wygrane++;
            else if (WynikZ == "PRZEGRANA")
                Przegrane++;
            else if (WynikZ == "REMIS")
                Remis++;

            if (Wygrane != 0)
            {
                WinRate = Wygrane / LiczbaGier * 100;
                WinRate = Math.Round(WinRate, 2);
            }

            Statystyki = "Liczba gier: " + LiczbaGier + "\nWygrane: " + Wygrane + " | Przegrane: " + Przegrane + " | Remis: " + Remis + "\nWspolczynnik wygranych: " + WinRate + "%\n";
            Console.WriteLine(Statystyki);
        }
    }
}
