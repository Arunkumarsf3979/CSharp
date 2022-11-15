using MathLib;
using System;
namespace CalculatorApp;
class Program{
    public static void Main(string[] args)
    {
        CircleArea circleArea=new CircleArea();
        Console.WriteLine("Circle area is "+circleArea.CalculateCircleArea());
        Maths maths=new Maths();
        CylinderVolume cylinderVolume=new CylinderVolume(25);
        Console.WriteLine("Can access public methods or variable from any application "+maths.CalculateWeight(15));
        // Console.WriteLine(maths.g);
        Console.WriteLine("cylinder volume is "+cylinderVolume.CalculateVoulme());
        Console.WriteLine("Internal values can be accessed only in same namespace "+cylinderVolume.Area);
        Console.WriteLine("Protected radius can be accessed by inheriting the class between namespace "+cylinderVolume.Radius);

    }
}
