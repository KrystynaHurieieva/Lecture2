namespace Lecture5
{
    public class Person
    {   
        public string Name { get; set; }

        private int _age;

        public DateTime DoB { get; set; }

        public Person(string name, DateTime dob)
        {
            Name = name;
            DoB = dob;
            _age = DateTime.UtcNow.Year - DoB.Year;
        }
        public void Print()
        {
            Console.WriteLine($"Name = {Name}, DoB = {DoB}, age = {_age}");
        }

        public void Print(string nameInput)
        {
            Console.WriteLine($"Name = {Name}, DoB = {DoB}, age = {_age}, nameInput = {nameInput}");
        }
    }
}