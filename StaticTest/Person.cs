using System;

namespace Inheritance
{
    class Person
    {   
        private static int counter = 1;

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Passport { get; set; }

        protected int ID {get;}

        protected string fullName
        {
            get { return Name + " " + Surname; }
        }

        private Person()
        {
            this.ID = counter++;
        }

        public Person(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name, string surname, string passport) : this()
        {
            Name = name;
            Surname = surname;
            Passport = passport;
        }

        public virtual void Print()
        {
            Console.WriteLine("Name {0} , ID {1}", fullName, ID);
        }

        public override string ToString()
        {
            return String.Format("Name {0} , passport {1}, ID {2}", fullName, Passport, ID);
        }
    }
}
