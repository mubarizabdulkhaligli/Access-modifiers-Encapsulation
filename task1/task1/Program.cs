using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.FullName = "Orxan Mammadov";

            student.Age=12;

            student.Age = 17;

            student.Age = 10;

            Console.WriteLine(student.Age);

        }
    }
}

