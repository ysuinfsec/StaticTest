using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Piloyan");
            Console.WriteLine("Call Person print");
            person.Print();

            Console.WriteLine();
            Person person2 = new Person("Jack", "Piloyan");
            Console.WriteLine("Call Person2 print");
            person2.Print();

            Console.WriteLine();
            person = new Student("John", "Piloyan", "IAM", 500);
            Console.WriteLine("Call student print");
            person.Print();

            Console.Read();
        }
    }
}
