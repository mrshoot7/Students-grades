using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    struct Student
    {
        public String name;
        public int degree;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Student = new Student();
            List<Student> Students = new List<Student>();

            Start:
            Console.Clear();
            Console.WriteLine("1- To add a new student");
            Console.WriteLine("2- To view students degree");
            Console.WriteLine("3- To exit");
            Console.Write("Number: ");

            int mode = int.Parse(Console.ReadLine());
            Console.Clear();

            if (mode == 1)
            {
                Console.WriteLine("Enter the student name: ");
                Student.name = Console.ReadLine();
                Console.WriteLine("Name: " + Student.name + " Enter the degree: ");
                Student.degree = int.Parse(Console.ReadLine());
                Students.Add(Student);
                goto Start;
            }
            else if (mode == 2)
            {
                if (Students.Count > 0)
                {
                    foreach (var s in Students)
                    {
                        string result;
                        result = s.degree < 60 ? "Failed" : "Passed";
                        Console.WriteLine("Name: " + s.name + " | " + "Degree: " + s.degree + " Result: " + result);
                    }
                } else
                {
                    Console.WriteLine("There's no students....");
                }
                Console.WriteLine("Press enter to return to menu");
                Console.ReadLine();
                goto Start;
            }
            else if (mode == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
