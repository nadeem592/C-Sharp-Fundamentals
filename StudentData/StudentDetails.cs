using System;
using StudentData.test;
namespace StudentData
{
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of student details you want to enter: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Student[] S = new Student[students];
            for (int i = 0; i < students; i++)
            {
                S[i] = new Student();
                Console.WriteLine();
                Console.WriteLine($"Enter the Details of Student {i + 1}");
                Console.WriteLine();
                Console.Write("Enter Id: ");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                S[i].setDetails(sid, name, age);

            }
            for (int i = 0; i < students; i++)
                S[i].display(i+1);
            // MethodAccessException()
            test1 t = new test1();
            t.method1();

        }
    }
}
