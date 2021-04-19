using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExceptions.Classes
{
    public class Movie
    {
        public Movie(string title, Genre genre, short rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                this.Rating = rating;
            }
            else
            {
                throw new Exception("The rating you added was not valid");
            }

            this.Title = title;
            this.Genre = genre;
            this.TicketPrice = 5 * Rating;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public short Rating { get; set; }
        public double TicketPrice { get; set; }
    }
}
