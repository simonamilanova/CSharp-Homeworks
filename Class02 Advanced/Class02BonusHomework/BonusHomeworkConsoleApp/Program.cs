using BonusHomeworkConsoleApp.Classes;
using System;
using System.Collections.Generic;

namespace BonusHomeworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest guestOne = new Guest("Guest1", new List<string>{ "Excellent", "Awful", "Horrible"}, 25);
            Guest guestTwo = new Guest("Guest2", new List<string>{ "Excellent", "Great", "Amazing"}, 26);

            guestOne.PrintUser();
            guestTwo.PrintUser();

            Console.WriteLine("========");

            guestOne.ReadComment("Everything is great!");
            guestTwo.ReadComment("Everything is horrible!");


            Console.WriteLine("------");

            Poster posterOne = new Poster("posterOne12", new List<string> { "Bad", "Not good", "Okay" }, 100, false);
            Poster posterTwo = new Poster("posterOne122", new List<string> { "Excellent", "Great", "Good", "Amazing" }, 200, true);

            posterOne.CheckStats();
            posterTwo.CheckStats();

            Console.WriteLine("========");

            posterOne.PrintUser();
            posterTwo.PrintUser();

            Console.WriteLine("------");

            Moderator moderatorOne = new Moderator("moderator1234", new List<string> { "Comment one", "Comment two", "Comment three"}, new List<string> { "User123", "User256", "User198"});
            Moderator moderatorTwo = new Moderator("moderator987", new List<string> { "Comment one", "Comment two"}, new List<string> { "User123", "User256", "User198", "User45"});

            moderatorOne.PrintUser();
            moderatorTwo.PrintUser();

            Console.WriteLine("========");

            moderatorOne.BanUser("Some reason");
            moderatorTwo.BanUser("More reasons");

            Console.ReadLine();
        }
    }
}
