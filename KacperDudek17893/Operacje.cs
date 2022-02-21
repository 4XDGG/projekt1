using System;
using System.IO;

namespace KacperDudek
{
    class Operacje //zawarte są tu operacje zapisu i odczytu z pliku
    {
        public string path = @"statystyki.txt";
        public void Zapis(string x)
        {
            StreamWriter sw;

            if (!File.Exists(path)) //sprawdzenie, czy plik istnieje
            {
                File.CreateText(path); //jeśli nie istnieje należy go utworzyć
            }

            sw = new StreamWriter(path);
            sw.WriteLine(x);
            sw.Close();
            Console.WriteLine("Statystyki zostały zapisane!\n");
        }
        public void Odczyt()
        {
            try
            {
                if (!File.Exists(path)) //sprawdzenie, czy plik istnieje
                {
                    throw new FileNotFoundException("Brak pliku!", path); //jeśli nie istnieje wyświetli komunikat
                }
                else
                {
                    StreamReader sr = File.OpenText(path);
                    string s = "";
                    Console.WriteLine("STATYSTYKI z pliku:\n");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
