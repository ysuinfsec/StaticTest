namespace Inheritance
{
    class Employee : Person
    {
        public string WorkPlace { get; set; }

        public Employee(string name, string surname, string workPlace) : base(name, surname)
        {
            this.WorkPlace = workPlace;
        }
    }
}
