using BonusHomeworkConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        Role Role { get; set; }
        List<string> Comments { get; set; }

        void PostComment(List<string> comment, string textComment);
        void PrintUser();
    }
}
