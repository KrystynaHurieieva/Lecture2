namespace Lecture5
{
    public class Car
    {
        public int Power { get; set; }
        public string  Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public static int Count;
        public static float Rate;

        static Car()
        {
            Rate = 4.95f;
            Count = 100;
        }
        public Car()
        {
            
        }
        public Car(int Power,
            string Model,
            string Color,
            int Year) 
        {
            this.Year = Year;
            this.Power = Power;
            this.Model = Model;
            this.Color = Color;
            Count++;
        }

        ~Car()
        {
            Count--;
        }
    }

}