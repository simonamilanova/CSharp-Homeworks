using BonusHomeworkConsoleApp.Enum;
using BonusHomeworkConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Classes
{
    public class Moderator : User, IModerator
    {
        public Moderator(string username, List<string> comments, List<string> users)
            :base(username, comments)
        {
            Users = users;
            Role = Role.Moderator;
        }
        public List<string> Users { get; set; }

        public void BanUser(string reason)
        {
            Console.WriteLine($"The user {Users[0]} is banned for this reason: {reason}");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"The users list has: {Users.Count} users and a role {Role}");
        }
    }
}
