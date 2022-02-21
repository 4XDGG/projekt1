using System;

namespace KacperDudek
{
    class Przebieg
    {
        public string WyborPrzeciwnika()
        {
            Random rnd = new Random();
            int Rand;
            string znak = "";
            Rand = rnd.Next(1, 4);

            if (Rand == 1)
                znak = "1";
            else if (Rand == 2)
                znak = "2";
            else if (Rand == 3)
                znak = "3";

            return znak;
        }
        public void Rozgrywka(string Wybor, string znakP)
        {
            string WyborP = "", WyborT = "";

            if (Wybor == "1") //sprawdzanie wyboru uzytkownika
            {
                WyborT = "Papier";
            }
            else if (Wybor == "2")
            {
                WyborT = "Kamien";
            }
            else if (Wybor == "3")
            {
                WyborT = "Nozyce";
            }
            Console.WriteLine($"Twoj wybor: {WyborT}"); //wypisanie wyboru użytkownika

            if (znakP == "1") //sprawdzanie wyboru przeciwnika
            {
                WyborP = "Papier";
            }
            else if (znakP == "2")
            {
                WyborP = "Kamien";
            }
            else if (znakP == "3")
            {
                WyborP = "Nozyce";
            }
            Console.WriteLine($"Wybor przeciwnika: {WyborP}"); //wypisanie wyboru przeciwnika 
        }
        public string WynikZwrotny(string znak, string Wybor)
        {
            string zwrot = " ";

            if (znak == Wybor) //sprawdzanie wyniku rozgrywki
            {
                zwrot = "REMIS";
            }
            else if (znak == "1" && Wybor == "2")
            {
                zwrot = "PRZEGRANA";
            }
            else if (znak == "1" && Wybor == "3")
            {
                zwrot = "WYGRANA";
            }
            else if (znak == "2" && Wybor == "1")
            {
                zwrot = "WYGRANA";
            }
            else if (znak == "2" && Wybor == "3")
            {
                zwrot = "PRZEGRANA";
            }
            else if (znak == "3" && Wybor == "1")
            {
                zwrot = "PRZEGRANA";
            }
            else if (znak == "3" && Wybor == "2")
            {
                zwrot = "WYGRANA";
            }
            return zwrot;
        }
    }
}
