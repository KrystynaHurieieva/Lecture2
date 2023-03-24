namespace Lecture5
{
    public abstract class Shape
    {
        public Point Point { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public Shape()
        {
            this.Width = 0;
            this.Height = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Shape class: Width= {Width}, Height = {Height} ");
        }
        public abstract double Area();

        //{
        //    Console.WriteLine("Parent class area!");
        //    return 0;
        //}

        //public static Shape operator+ (Shape a, Shape b) // - * / % 
        //{
        //    Shape shape = new Shape();
        //    shape.Width = a.Width + b.Width;
        //    shape.Height = a.Height + b.Height;
        //    return shape;
        //}

        public static bool operator ==(Shape a, Shape b)
        {
            if (a.Height == b.Height && a.Width == b.Width)
                return true;

            return false;
        }
        public static bool operator !=(Shape a, Shape b)
        {
            if (a.Height != b.Height || a.Width != b.Width)
                return true;

            return false;
        }
    }

}