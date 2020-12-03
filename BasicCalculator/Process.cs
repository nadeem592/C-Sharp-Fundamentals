using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    class Process
    {
        public void addition()
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The addition of {num1} and {num2} is " + (num1 + num2));
        }
        public void subtraction()
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The difference of {num1} and {num2} is " + (num1 - num2));
        }
        public void multiplication()
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The multiplication of {num1} and {num2} is " + (num1 * num2));
        }
        public void division()
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The division of {num1} and {num2} is " + (num1 / num2));
        }
        public void evenorodd()
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even");
            else
                Console.WriteLine($"{num} is Odd");
        }
        public void primeornot()
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=2;i<num;i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 0)
                Console.WriteLine("{0} is Prime Number", num);
            else
                Console.WriteLine("{0} is not Prime Number", num);
        }
    }
}
