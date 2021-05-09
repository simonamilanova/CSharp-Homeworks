using Exercise01ConsoleApp.ExerciseData;
using System;
using System.Linq;

namespace Exercise01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find and print all persons firstnames starting with 'R', ordered by Age -DESCENDING ORDER
            var persons1 = Exercise.Persons.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
            persons1.ForEach(x => Console.WriteLine($"Person: {x.FirstName}, Age: {x.Age}"));

            Console.WriteLine("-------------");

            //Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            var persons2 = Exercise.Dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList();
            persons2.ForEach(x => Console.WriteLine($"Dog: {x.Name}, Age: {x.Age}"));

            Console.WriteLine("-------------");

            //Find and print all persons with more than 2 dogs, ordered by Name -DESCENDING ORDER
            var persons3 = Exercise.Persons.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
            persons3.ForEach(x => Console.WriteLine($"Person: {x.FirstName}"));

            Console.WriteLine("-------------");

            //Find and print all Freddy`s dogs names older than 1 year
            var freddysDogNames = Exercise.Persons.SingleOrDefault(x => x.FirstName == "Freddy").Dogs.Where(x => x.Age > 1).ToList();
            freddysDogNames.ForEach(x => Console.WriteLine($"Freddy's dogs name: {x.Name}, Age: {x.Age}"));

            Console.WriteLine("-------------");

            //Find and print Nathen`s first dog
            var nathansFirstDog = Exercise.Persons.SingleOrDefault(x => x.FirstName == "Nathen").Dogs.FirstOrDefault();
            Console.WriteLine($"Nathen's first dog name is: {nathansFirstDog.Name}");

            Console.WriteLine("-------------");

            //Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name -ASCENDING ORDER
            var allWhiteDogNames = Exercise.Persons.Where(x => x.FirstName == "Christofer"
                || x.FirstName == "Freddy"
                || x.FirstName == "Erin"
                || x.FirstName == "Amelia")
                .SelectMany(x => x.Dogs.Where(x => x.Color == "White"))
                .OrderBy(x => x.Name)
                .ToList();

            allWhiteDogNames.ForEach(x => Console.WriteLine($"Dog name: {x.Name}, Color: {x.Color}"));



        }
    }

}
