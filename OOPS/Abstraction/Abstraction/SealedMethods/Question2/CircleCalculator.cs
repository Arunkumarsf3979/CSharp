namespace Question2
{
    
// Class CircleCalculator inherit Calculator
// Methods: sealed override void area - 3.14 * r 2

    public class CircleCalculator:Calculator
    {
        public int Radius { get; set; }
        // public double Area{get;set;}
        
        public CircleCalculator(int Radius)
        {
            this.Radius=Radius;
        }
        public sealed override void Area()
        {
            System.Console.WriteLine("Circle Area is "+(3.14*Radius*Radius));
        }
        public sealed override void Volume()
        {
            
        }
    }
}