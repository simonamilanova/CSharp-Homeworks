using BonusHomeworkConsoleApp.Enum;
using BonusHomeworkConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Classes
{
    public class Guest : User, IGuest
    {
        public Guest(string username, List<string> comments, int id)
            :base(username, comments)
        {
            Id = id;
            Role = Role.Guest;
        }
        public int Id { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"User Id: {Id}, username: {Username}, Id: {Id}");
        }

        public void ReadComment(string commentString)
        {
            Console.WriteLine($"The Guest with Id: {Id} read this comment: {commentString}");
        }
    }
}
