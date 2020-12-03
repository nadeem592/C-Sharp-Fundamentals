using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            Console.WriteLine("**** WELCOME TO BASIC CALCULATOR ****");
            Console.WriteLine();
            Console.WriteLine("1.ADDITION\n2.SUBTRACTION\n3.MULTIPLICATION\n4.DIVISION\n5.EVEN OR ODD\n6.PRIME OR NOT");
            Console.WriteLine();
            Console.WriteLine("CHOOSE YOUR OPTION");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    p.addition();
                    break;
                case 2:
                    p.subtraction();
                    break;
                case 3:
                    p.multiplication();
                    break;
                case 4:
                    p.division();
                    break;
                case 5:
                    p.evenorodd();
                    break;
                case 6:
                    p.primeornot();
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;

            }


        }
    }
}
