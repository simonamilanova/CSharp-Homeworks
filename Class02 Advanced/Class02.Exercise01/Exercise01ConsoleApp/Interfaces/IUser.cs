using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }

        void PrintUser();
    }
}
