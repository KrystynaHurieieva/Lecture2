namespace Lecture5
{
    public class Triangle : Shape
    {
        public Triangle(int width = 0, int height = 0) : base(width, height)
        { }

        public override double Area()
        {
            Console.WriteLine("Triangle class area!");
            return (Width * Height) / 2;
        }

    }

}