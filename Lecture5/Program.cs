namespace Lecture5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//var product = new Product();
            //var product1 = new Product("my descriprion");
            //var product2 = new Product("My name", "My descriprion");

            //product.PrintMyInfo();
            //product1.PrintMyInfo();
            //product2.PrintMyInfo();

            //var product3 = new Product(product2.Name, "this is my description");
            //product3.PrintMyInfo();

            //string name, description;
            //product3.Deconstruct(out name, out description);
            //Console.WriteLine($"{name}, {description}");

            // private 
            // private protected 
            // file 
            // protected 
            //internal
            // proctected internal 
            // public
            }

            var person = new Person("Tom", new DateTime(1990, 01, 01));
            var emp = new Employee("Jerry", new DateTime(1994, 08, 03), "Mouse");
            person.Print();
            emp.Print();
            emp.PrintEmployee();

            var newEmp = new Employee("Sam", new DateTime(1997, 02, 14), "Developer");
            Person newPerson = newEmp;
            newPerson.Print();
            object newObject = newPerson;

            Employee myEmp = (Employee)newPerson;
            myEmp.PrintEmployee();
            //Employee myEmp1 = (Employee)person;
            //myEmp1.PrintEmployee();
            Employee myEmp1 = null;

            if(myEmp1 == null)
            {
                Console.WriteLine("myEmp1 is null");
            }

            if(myEmp is Employee)
            {
                Console.WriteLine("myEmp is Employee");
            }
            else
            {
                Console.WriteLine("myEmp is not Employee");
            }

            if (newPerson is Employee)
            {
                var t = person as Employee;
                Console.WriteLine($"newPerson is Employee. {newPerson.GetType()}");
                Console.WriteLine($"person. {person.GetType()}");
            }
            else
            {
                Console.WriteLine("newPerson is not Employee");
            }

        }
    }

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
    }

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