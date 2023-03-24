namespace Lecture5
{
    public abstract class EmployeeN
    {
        public abstract void CalculateSallary();

        public string Name { get; set; }

        public string Sallary { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Name= {Name} \t Sallary = {Sallary}");
            Console.WriteLine();
        }

    }

}