using System;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the program.");

            Address home = new Address();

            // Console.WriteLine("What is your street? ");
            // home._street = Console.ReadLine();

            home._street = "123 North Street";
            home._city = "Rigby";
            home._state = "ID";


            home.DisplayMailingLabel(true);

            Address work = new Address();
            work._street = "STC 320Q";
            work._city = "Rexburg";
            work._state = "ID";

            work.DisplayMailingLabel(true);

            Address vacation = new Address();
            vacation.DisplayMailingLabel(false);
        }
    }
}
