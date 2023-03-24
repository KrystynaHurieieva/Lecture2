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
            {
                //var person = new Person("Tom", new DateTime(1990, 01, 01));
                //var emp = new Employee("Jerry", new DateTime(1994, 08, 03), "Mouse");
                //person.Print();
                //emp.Print();
                //emp.PrintEmployee();

                //var newEmp = new Employee("Sam", new DateTime(1997, 02, 14), "Developer");
                //Person newPerson = newEmp;
                //newPerson.Print();
                //object newObject = newPerson;

                //Employee myEmp = (Employee)newPerson;
                //myEmp.PrintEmployee();
                ////Employee myEmp1 = (Employee)person;
                ////myEmp1.PrintEmployee();
                //Employee myEmp1 = null;

                //if(myEmp1 == null)
                //{
                //    Console.WriteLine("myEmp1 is null");
                //}

                //if(myEmp is Employee)
                //{
                //    Console.WriteLine("myEmp is Employee");
                //}
                //else
                //{
                //    Console.WriteLine("myEmp is not Employee");
                //}

                //if (newPerson is Employee)
                //{
                //    var t = person as Employee;
                //    Console.WriteLine($"newPerson is Employee. {newPerson.GetType()}");
                //    Console.WriteLine($"person. {person.GetType()}");
                //}
                //else
                //{
                //    Console.WriteLine("newPerson is not Employee");
                //}
            }
            {
                //var person = new Person("Test", new DateTime(1990, 10,19));
                //person.Print();
                //person.Print("I'm test");

                //Print(5);
                //Print(5.5);
                //Print("5");

                //var shape = new Shape(5, 2);
                //var rectangle = new Rectangle(5, 2);
                //var triangle = new Triangle(5, 2);

                //Print(shape.Area());
                //Print(rectangle.Area());
                //Print(triangle.Area());

                //var shape1 = new Rectangle(1, 4);
                //var shape2 = new Rectangle(2, 8);
                //var shape3 = new Rectangle(0, 12);

                //var shape31 = new Rectangle(1, 4);

                //var shape21 = shape2;

                //if (shape1 == shape3)
                //    Print("Rectangle are same (shape1 == shape3)");

                //if (shape1 == shape31)
                //    Print("Rectangle are same (shape1 == shape31)");

                //if (shape2 == shape21)
                //    Print("Rectangle's references are same (shape2 == shape21)");

                //var res = shape1 + shape2;
                //res.Print();

                //var res2 = shape1 - shape2;
                //abstract 
            }

            {
                //var dev = new Development();
                //dev.Name = "Development";
                //dev.CalculateSallary();
                //dev.PrintName();

                //var man = new Management();
                //man.Name = "Management";
                //man.CalculateSallary();
                //man.PrintName();

                //var list = new List<EmployeeN>() {
                //    new Development() { Name = "Development1"},
                //    new Development() { Name = "Development2"},
                //    new Development() { Name = "Development3"},
                //    new Development() { Name = "Development4"},
                //    new Management() { Name = "Management1"},
                //    new Management() { Name = "Management2"},
                //    new Management() { Name = "Management3"},
                //    new Management() { Name = "Management4"}
                //};


                //foreach (var item in list)
                //{
                //    item.CalculateSallary();
                //    item.PrintName();
                //}


                //list.Add(new Management() { Name = "Manager ! :) " });
                //list.Add(new Development() { Name = "Dev ! :) " });


                //foreach (var item in list)
                //{
                //    item.CalculateSallary();
                //    item.PrintName();
                //}

            }

            //Console.WriteLine(Point.Pi);
            //Point.Pi = 222;
            //Console.WriteLine(Point.Pi);

            //var car1 = new Car(2500, "Toyota Camry", "Red", 2023);
            //var car2 = new Car(2000, "Toyota CHR", "White", 2023);
            //var car3 = new Car(2500, "Toyota RAV4", "Grey", 2023);
            //var car4 = new Car(3500, "Toyota Prado", "Black", 2023);

            //Console.WriteLine(Car.Count);

            //Console.WriteLine($"Value Pi : {MyMath.Pi}");
            ////Console.WriteLine($"Cube of car1.Power: {MyMath.cube(car1.Power)}");
            ////Console.WriteLine($"Cube of car1.Power: {MyMath.cube(car1.Power - 2000)}");
            ////Console.WriteLine($"Cube of 5: {MyMath.cube(5)}");

            //Console.WriteLine($"Value Car.Count {Car.Count} ");
            //Console.WriteLine($"Value Car.Rate {Car.Rate} ");

            //car1 = null;

            //Console.WriteLine($"Value Car.Count {Car.Count} ");
            //var rec = new Rectangle(10, 20);
            //rec.Draw();

            //var names = new List<string>();
            //names.Add("Ivan");


            //var cars = new List<Car>()
            //{ new Car() { Model = "BMW"},
            //new Car() { Model = "Toyota"},
            //new Car() { Model = "Tesla"},
            //new Car() { Model = "Nissan"},
            //new Car() { Model = "Porshe"},
            //new Car() { Model = "ЗАЗ"},
            //new Car() { Model = "VW"},
            //new Car() { Model = "Audi"},
            //new Car() { Model = "Pontiace"}};
            //var cars2 = new List<Car>()
            //{ new Car() { Model = "BMW2"},
            //new Car() { Model = "Toyota2"},
            //new Car() { Model = "Tesla2"},
            //new Car() { Model = "Nissan2"},
            //new Car() { Model = "Porshe2"},
            //new Car() { Model = "ЗАЗ2"},
            //new Car() { Model = "VW2"},
            //new Car() { Model = "Audi2"},
            //new Car() { Model = "Pontiace2"}};

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}
            //cars.Add(new Car() { Model = "BMW" });
            //cars.Add(new Car() { Model = "Audi" });
            //cars.Add(new Car() { Model = "ЗАЗ" });
           
            //cars.AddRange(cars2);
            
            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}
            //System.Collections.Generic;

            //var carsStack = new Stack<Car>();

            //carsStack.Push(new Car() { Model = "BMW" });
            //carsStack.Push(new Car() { Model = "Audi" });
            //carsStack.Push(new Car() { Model = "ЗАЗ" });
            //foreach (var car in carsStack)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}

            //Console.WriteLine($"Pop: {carsStack.Pop().Model}");

            //foreach (var car in carsStack)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}
            //var carsQueue = new Queue<Car>();
            //carsQueue.Enqueue(new Car() { Model = "Audi" });
            //carsQueue.Enqueue(new Car() { Model = "Tesla" });
            //carsQueue.Enqueue(new Car() { Model = "BMW" });
            //carsQueue.Enqueue(new Car() { Model = "VW" });
            //carsQueue.Enqueue(new Car() { Model = "Заз" });
            //carsQueue.Enqueue(new Car() { Model = "Porche" });

            //foreach (var car in carsQueue)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}
            //Console.WriteLine($"Dequeue: {carsQueue.Dequeue().Model}");
            //foreach (var car in carsQueue)
            //{
            //    Console.WriteLine($"Model: {car.Model}");
            //}
            IDrawble rec = new Rectangle(10, 20);
            rec.Draw();

            var dictionaty = new Dictionary<int, string>();
            dictionaty.Add(1, "Tom");
            dictionaty.Add(2, "Kevin");
            dictionaty.Add(3, "Mia");
            dictionaty.Add(4, "Kira");

            foreach (var car in dictionaty)
            {
                Console.WriteLine($"{car.Key} {car.Value}");
            }
        }
        //sealed
        //Stack -> FILO
        //QUEUE -> FIFO
    }

    public interface IDrawble
    {
        public void Draw()
        {
            Console.Write("Hello");
        }
    }


    public static class MyMath
    {
        public static float Pi = 3.14f;
        public static long cube(int n)
        {
            return n * n * n;
        }

        static MyMath()
        {
            
        }
    }
}