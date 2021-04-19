using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExceptions.Classes
{
    public class Cinema
    {
        public Cinema(string name, List<int> halls, List<Movie> listOfMovies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = listOfMovies;
        }
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }


        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
