Mój pierwszy projekt w github.
Plik uruchamiający projekt to: KacperDudek17893.csproj .

Program jest grą "Papier, kamień, nożyce". 

Statystyki z gry zapisane są w bin/Debug/netcoreapp3.1/statystyki.txt .

W pliku AuthorInfo.cs zawarte są informacje o autorze.

W pliku DaneStatystyki.cs zawarte są zmienne potrzebne do obliczania statystyk.

W pliku MenuProgramu.cs zawarte jest okno statystyk oraz menu programu, w którym zawarte są opcje uruchomienia gry, wyświetlenia aktualnego wyniku, zapisania wyniku do pliku, wczytania wyniku z pliku i zamknięcia programu.

W pliku Operacje.cs zawarte są operacje zapisu i odczytu danych z pliku statystyki.txt .

Plik Program.cs służy do wyświetlenia przy pierwszym uruchomieniu programu informacji o autorze oraz wywołania menu programu.

Plik Przebieg.cs służy do pobierania podczas rozgrywki wyboru użytkownika i przeciwnika, a następnie zwrócenie odpowiedniego wyniku (wygranej, przegranej lub remisu).

Plik Rozgrywka.cs służy do rozpoczęcia gry i dodawaniu punktów do odpowiednich statystyk, w zależności od wyniku meczu.
