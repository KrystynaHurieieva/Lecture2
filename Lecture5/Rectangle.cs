namespace Lecture5
{
    public class Rectangle : Shape, IDrawble
    {
        public Rectangle(int width = 0, int height = 0) : base(width, height)
        { }

        public override double Area()
        {
            Console.WriteLine("Rectangle class area!");
            return (Width * Height);
        }

        //public void Draw()
        //{
        //    Console.WriteLine($"Rectangle width : {Width}, height : {Height}");
        //}
    }

}