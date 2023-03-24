namespace Lecture5
{
    public class Polygone : Shape
    {
        public Polygone(int width = 0, int height = 0) : base(width, height)
        { }

        public override double Area()
        {
            Console.WriteLine("Polygone class area!");
            return (Width * Height) * (Width * Height);
        }
    }

}