using MathLib;
namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double _radius=10;
        public double Radius{get;set;}
        public double Area{get;set;}
        public CircleArea()
        {
            Radius=_radius;
        }
        public double CalculateCircleArea()
        {
            Area=PI*Radius*Radius;
            return Area;
        }
    }
}