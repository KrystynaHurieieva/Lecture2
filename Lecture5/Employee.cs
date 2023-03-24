namespace Lecture5
{
    class Employee : Person
    {
        public Employee(string name, DateTime dob, string position) : base(name, dob)
        {
            Position = position;
        }

        public string Position { get; set; } = "Temp Position";

       public void PrintEmployee()
        {
            Console.WriteLine($"Name = {Name}, DoB = {DoB}, Position = {Position}");
        }
    }
}