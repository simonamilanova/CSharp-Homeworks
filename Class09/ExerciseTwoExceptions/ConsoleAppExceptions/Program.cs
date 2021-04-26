using System;
using System.Collections.Generic;
using ConsoleAppExceptions.Classes;

namespace ConsoleAppExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
            Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);


            Console.WriteLine("Please select a cinema, type 1 for Cineplexx or 2 for Milenium");
            int userInputCinema = 0;
            int userInputMoviesOrGenre = 0;
            try
            {
                userInputCinema = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException nullEx)
            {
                Console.WriteLine($"Argument null exception mesage: {nullEx.Message}");
            }
            catch (FormatException  formEx)
            {
                Console.WriteLine($"Format exception message: {formEx.Message}");
            }
            catch (OverflowException overFlEx)
            {
                Console.WriteLine($"Overflow exception message:  {overFlEx.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

  
            if (userInputCinema == 1)
            {
                Console.WriteLine($"You've selected the cinema {cinema1.Name}");
                Console.WriteLine("See all movie titles or by genre? Type 3 for movies or 4 for genre");

                try
                {
                    userInputMoviesOrGenre = int.Parse(Console.ReadLine());
                }
                catch (ArgumentNullException argNullEx)
                {
                    Console.WriteLine($"Argument null exception mesage: {argNullEx.Message}");
                }
                catch (FormatException forEx)
                {
                    Console.WriteLine($"Format exception message: {forEx.Message}");
                }
                catch (OverflowException overEx)
                {
                    Console.WriteLine($"Overflow exception message:  {overEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                }


                if (userInputMoviesOrGenre == 3)
                {
                    Console.WriteLine("Here are all the movies: ");
                    MovieSet1.ForEach(movie => Console.WriteLine(movie.Title));
                }
                else if (userInputMoviesOrGenre == 4)
                {
                    Console.WriteLine("Here are all the movies: ");
                    MovieSet1.ForEach(movie => Console.WriteLine($"Movie Title: {movie.Title} - Genre: {movie.Genre}"));
                }
            }
            else if (userInputCinema == 2)
            {
                Console.WriteLine($"You've selected the cinema {cinema2.Name}");
                Console.WriteLine("See all movies or by genre? Type 3 for movies or 4 for genre");

                try
                {
                    userInputMoviesOrGenre = int.Parse(Console.ReadLine());
                }
                catch (ArgumentNullException argNullEx)
                {
                    Console.WriteLine($"Argument null exception mesage: {argNullEx.Message}");
                }
                catch (FormatException forEx)
                {
                    Console.WriteLine($"Format exception message: {forEx.Message}");
                }
                catch (OverflowException overEx)
                {
                    Console.WriteLine($"Overflow exception message:  {overEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                }

                if (userInputMoviesOrGenre == 3)
                {
                    Console.WriteLine("Here are all the movies: ");
                    MovieSet1.ForEach(movie => Console.WriteLine(movie.Title));
                }
                else if (userInputMoviesOrGenre == 4)
                {
                    Console.WriteLine("Here are all the movies: ");
                    MovieSet1.ForEach(movie => Console.WriteLine($"Movie Title: {movie.Title} - Genre: {movie.Genre}"));
                }
            }

            Console.ReadLine();

        }
    }
}
