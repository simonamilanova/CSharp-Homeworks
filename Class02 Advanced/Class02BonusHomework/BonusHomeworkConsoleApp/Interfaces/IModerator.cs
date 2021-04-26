using BonusHomeworkConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Interfaces
{
    public interface IModerator
    {
        List<string> Users { get; set; }

        void BanUser(string reason);
    }
}
