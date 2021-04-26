using BonusHomeworkConsoleApp.Enum;
using BonusHomeworkConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Classes
{
    public class Poster : User, IPoster
    {
        public Poster (string username, List<string> comments, int points, bool isPosterOfTheWeek)
            :base(username, comments)
        {
            Points = points;
            IsPosterOfTheWeek = isPosterOfTheWeek;
            Role = Role.Poster;
        }
        public int Points { get; set; }
        public bool IsPosterOfTheWeek { get; set; }

        public void CheckStats()
        {
            Console.WriteLine($"This user has {Points} points and {Comments.Count} comments");
        }

        public override void PrintUser()
        {
            Console.WriteLine($" Username: {Username} - Has role: {Role} - No. of comments {Comments.Count} ");
        }
    }
}
