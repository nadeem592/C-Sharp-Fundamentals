using System;
using System.Collections.Generic;
using System.Text;

namespace StudentData
{
    class Student
    {
        private int sid;
        private string name;
        private int age;
        public void setDetails(int sid, string name, int age)
        {
            this.sid = sid;
            this.name = name;
            this.age = age;
        }
        public int Sid
        {
            get
            {
                return sid;
            }
            set
            {
                sid = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public void display(int i)
        {
            Console.WriteLine($"Student Record {i}: ");
            Console.WriteLine();
            Console.WriteLine("\tID     : " + sid);
            Console.WriteLine("\tName   : " + name);
            Console.WriteLine("\tAge    : " + age);
            Console.WriteLine();
        }
    }
}
