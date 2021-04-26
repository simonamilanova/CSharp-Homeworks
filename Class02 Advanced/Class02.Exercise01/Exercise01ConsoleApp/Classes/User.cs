using Exercise01ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public abstract class User : IUser
    {
        public User (int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void PrintUser();

        
    }

    
}
