using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();

            int winNum = randomNum.Next(1, 101);

            bool win = false;

            Console.WriteLine("Select a level: easy(e), normal(n) or hard(h)");
            char levelSelected = Convert.ToChar(Console.ReadLine());
            int numOfGuesses = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 100!");
                int inputNum = int.Parse(Console.ReadLine());

                //Easy level
                if (levelSelected == 'e' || levelSelected == 'E')
                {
                    numOfGuesses++;
                    if (inputNum == winNum && numOfGuesses == 1)
                    {
                        Console.WriteLine("Lucky First Try. You WON!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        } else
                        {
                            Console.Clear();
                            continue;
                        }  
                    }

                    if (inputNum == winNum)
                    {
                        Console.WriteLine("You Won !!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                    if (inputNum > winNum)
                    {
                        Console.WriteLine("Too high! Guess lower.");
                    }

                    if (inputNum < winNum)
                    {
                        Console.WriteLine("Too low! Guess higher.");
                    }

                    if (numOfGuesses == 9)
                    {
                        Console.WriteLine("You are out of tries!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            win = true;
                        } else
                        {
                            Console.Clear();
                        }    
                    }
                }

                //Normal Level
                if (levelSelected == 'n' || levelSelected == 'N')
                {
                    numOfGuesses++;
                    if (inputNum == winNum && numOfGuesses == 1)
                    {
                        Console.WriteLine("Lucky First Try. You WON!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                    if (inputNum == winNum)
                    {
                        Console.WriteLine("You Won !!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();
                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                    if (inputNum > winNum)
                    {
                        Console.WriteLine("Too high! Guess lower.");
                    }

                    if (inputNum < winNum)
                    {
                        Console.WriteLine("Too low! Guess higher.");
                    }
                    
                    if (numOfGuesses == 7)
                    {
                        Console.WriteLine("You are out of tries!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            win = true;
                        } else
                        {
                            Console.Clear();
                        }    
                    }
                }

                //Hard Level
                if (levelSelected == 'h' || levelSelected == 'H')
                {
                    numOfGuesses++;
                    if (inputNum == winNum && numOfGuesses == 1)
                    {
                        Console.WriteLine("Lucky First Try. You WON!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                    if (inputNum == winNum)
                    {
                        Console.WriteLine("You Won !!!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }  
                    }

                    if (inputNum > winNum)
                    {
                        Console.WriteLine("Too high! Guess lower.");
                    }

                    if (inputNum < winNum)
                    {
                        Console.WriteLine("Too low! Guess higher.");
                    }
                    
                    if (numOfGuesses == 5)
                    {
                        Console.WriteLine("You are out of tries!");
                        Console.WriteLine("Play again? Enter Y or N");
                        string playAgainInput = Console.ReadLine();

                        if (playAgainInput == "n" || playAgainInput == "N")
                        {
                            Console.Clear();
                            win = true;
                        } else
                        {
                            Console.Clear();
                        }   
                    }
                }

            } while (win == false);
            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to exit.");


           
                
         
        }
    }
}
