using System;

namespace MyApp
{
    class Student
    {
        public void Show()
        {
            Console.WriteLine("This is Student class");
        }
    }

    class Teacher
    {
        public void Show()
        {
            Console.WriteLine("This is Teacher class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Show();

            Teacher t = new Teacher();
            t.Show();
        }
    }
}