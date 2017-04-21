using System;
using System.Collections.Generic;


namespace Inheritance
{
    class Student : Person
    {
        public string Faculty { get; set; }
        public double Group { get; set; }

        private List<double> grades;

        public Student() : base("", "")
        {
        }

        public Student(string name, string surname, string faculty, double group) : base(name, surname)
        {
            Passport = "";
            this.Faculty = faculty;
            this.Group = group;
            grades = new List<double>();

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Faculty {0} , Group {1}", Faculty, Group);
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format("Faculty {0} , Group {1}", Faculty, Group);
        }

        public void AddGrade(List<double> grades)
        {
            foreach (var item in grades)
            {
                this.grades.Add(item);
            }
        }

        public double AverageGrade()
        {
            double c = 0;
            double sum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
                c++;
            }
            return sum / c;
        }

    }
}

