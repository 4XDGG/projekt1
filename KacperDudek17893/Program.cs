using System;

namespace KacperDudek17893
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorInfo AuthInfo = new AuthorInfo(); //utworzenie obiektu AuthorInfo
            string Info = AuthInfo.Info();
            Console.WriteLine(Info + "\n");

            MenuProgramu menu = new MenuProgramu();
            menu.Menu(); //wywołanie metody Menu
        }
    }
}
