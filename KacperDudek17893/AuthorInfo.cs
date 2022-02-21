namespace KacperDudek17893
{
    class AuthorInfo
    {
        public string Info()
        {
            string Author;
            int NrAlbumu;
            Author = "Kacper Dudek";
            NrAlbumu = 17893;//przypisywanie do zmiennych danych o autorze
            string Info = "Copyright by " + Author + " " + NrAlbumu;
            return Info;
        }
    }
}
