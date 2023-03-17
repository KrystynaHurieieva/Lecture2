namespace Lecture5
{
    class Product
    {
        public string Name { get; private set; }

        public string Description { get; set; }

        public Product(string name, string description)
        { 
            Name = name;
            Description = description;
            if(Description.Contains("description"))
            {
                Description += " :) ";
            }
        }
        public Product(string description) : this("Default name", description)
        {
        }
        public Product() : this("Default description")
        {
        }

       
        public void PrintMyInfo()
        {
            Console.WriteLine($"Name = {Name}, Description = {Description}");
        }

        public void Deconstruct(out string name, out string description)
        {
            name = Name;
            description = Description;
        }
    }
}