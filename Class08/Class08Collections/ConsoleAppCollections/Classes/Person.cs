using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCollections.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favouriteMusicType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = favouriteMusicType;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public void GetFavouriteSongs()
        {
            if(FavouriteSongs.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} likes these songs: ");
                foreach(var song in FavouriteSongs)
                {
                    Console.WriteLine($"{song.Title} {song.Genre} {song.Length}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {GetFullName()} doesn't have any favourite songs");
            }
        }
    }
}
