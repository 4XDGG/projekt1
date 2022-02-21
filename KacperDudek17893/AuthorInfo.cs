namespace KacperDudek
{
    class AuthorInfo
    {
        public string Info()
        {
            string Author;
            int NrAlbumu;
            Author = "Kacper Dudek";//przypisywanie do zmiennych danych o autorze
            NrAlbumu = 17893;
            string Info = "Copyright by " + Author + " " + NrAlbumu;
            return Info;
        }
    }
}
