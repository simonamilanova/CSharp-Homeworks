using System;
using ObjectsHomework.Classes;

namespace ObjectsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //drivers
            Driver bob = new Driver("Bob", 5);
            Driver greg = new Driver("Greg", 4);
            Driver jill = new Driver("Jill", 3);
            Driver anne = new Driver("Anne", 2);

            //cars
            Car hyundai = new Car("Hyundai", 100, bob);
            Car mazda = new Car("Mazda", 110, greg);
            Car ferrari = new Car("Ferrari", 230, jill);
            Car porsche = new Car("Porsche", 240, anne);

        }


        static void RaceCars()
        {
            Console.WriteLine("Select the first car: Hyundai, Mazda, Ferrari, Porsche");
            string firstUserInputCar = Console.ReadLine();

            Console.WriteLine("Select the second car: Hyundai, Mazda, Ferrari, Porsche");
            string secondUserInputCar = Console.ReadLine();

            if(firstUserInputCar == "Hyundai" && secondUserInputCar == "Mazda")
            {

            }


        }

        
        
    }
}
