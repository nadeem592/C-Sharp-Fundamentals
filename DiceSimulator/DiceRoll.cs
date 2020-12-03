using System;
using System.Threading;
namespace DiceSimulator
{
    class DiceRoll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** WELCOME TO DICE SIMULATOR *****");
            Console.WriteLine();
            Console.WriteLine("Press r to Roll the Dice");
            string choice = Console.ReadLine();
            Random random = new Random();
            int score = 0;
            while(choice=="r")
            {
                int number = random.Next(1, 6);
                
                if(number==1)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("|        |");
                    Console.WriteLine("|   O    |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("----------");
                    score += number;
                    
                }
                if (number == 2)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("|        |");
                    Console.WriteLine("|  O  O  |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("----------");
                    score += number;
                }
                if (number == 3)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("|        |");
                    Console.WriteLine("| O O O  |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("----------");
                    score += number;
                }
                if (number == 4)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("|  O   O |");
                    Console.WriteLine("|        |");
                    Console.WriteLine("|  O   O |");
                    Console.WriteLine("----------");
                    score += number;

                }
                if (number == 5)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("| O    O |");
                    Console.WriteLine("|   O    |");
                    Console.WriteLine("| O    O |");
                    Console.WriteLine("----------");
                    score += number;

                }
                if (number == 6)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(i + " ");
                        Console.Beep();
                    }
                    Console.WriteLine("----------");
                    Console.WriteLine("| O O O |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| O O O |");
                    Console.WriteLine("----------");
                    score += number;
                }
                Console.WriteLine();
                Console.WriteLine("Press r to roll again ");
                Console.WriteLine();
                Console.WriteLine("Presss q to quit the game");
                choice = Console.ReadLine();
                if (choice == "q")
                {
                    Console.WriteLine();
                    Console.WriteLine("YOUR SCORE IS : " + score);

                }
            }
        }
    }
}
