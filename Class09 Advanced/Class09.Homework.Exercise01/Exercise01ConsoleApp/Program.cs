using System;
using System.IO;

namespace Exercise01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //●Create a folder called Exercise
            //●Create a txt file in it called calculations
            //●Create a method  that calculates  2 numbers and returns a string in the format: num1 + num2 = result
            //( Ex: 2 + 3 = 5 )●Ask the user to enter 2 numbers,  call the calculate  method and give the result
            //●After the result
            //is written in the console it should also be written in the calculations.txt  file with a time stamp  next to it
            //●Call the console 3 times and write 3 results in the txt file


            string currentDirectory = Directory.GetCurrentDirectory();
            string folderName = "Exercises";
            string newFolderPath = $@"{currentDirectory}\{folderName}\";

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("New folder path has been created with the new folder");
            }

            string fileName = "calculations.txt";
            bool doesTxtFileExist = File.Exists(newFolderPath + fileName);
            Console.WriteLine($"Does this txt file exist: {doesTxtFileExist}");

            if(!File.Exists(newFolderPath + fileName))
            {
                File.Create(newFolderPath + fileName).Close();
                Console.WriteLine("A new file has been created");
            }

            Console.WriteLine("Please enter two numbers");
            int firstNumInput = int.Parse(Console.ReadLine());
            int secondNumInput = int.Parse(Console.ReadLine());
            
            using (StreamWriter sw = new StreamWriter(newFolderPath + fileName, true))
            {
                Console.WriteLine(CalculateNumbers(firstNumInput, secondNumInput));
                sw.WriteLine(CalculateNumbers(firstNumInput, secondNumInput));
            }


            Console.ReadLine();
        }

        static string CalculateNumbers(int num1, int num2)
        {

            int sum = num1 + num2;

            return $"{num1} + {num2} = {sum} --- Time: {DateTime.Now} ";

            
        }
    }
}
