using System;
using System.Collections.Generic;
using System.Text;

namespace BonusHomeworkConsoleApp.Interfaces
{
    public interface IGuest
    {
        int Id { get; set; }

        void ReadComment(string commentString);
    }
}
