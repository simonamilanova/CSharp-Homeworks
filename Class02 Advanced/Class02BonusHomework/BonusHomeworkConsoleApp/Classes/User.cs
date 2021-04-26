using BonusHomeworkConsoleApp.Enum;
using BonusHomeworkConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Classes
{
    public abstract class User : IUser
    {
        public User (string username, List<string> comments)
        {
            Username = username;
            Comments = comments;
        }
        public string Username { get; set; }
        public Role Role { get; set; }
        public List<string> Comments { get; set; }

        public void PostComment(List<string> comment, string textComment)
        {
            comment.Add(textComment);
        }

        public abstract void PrintUser();
       
    }
}
