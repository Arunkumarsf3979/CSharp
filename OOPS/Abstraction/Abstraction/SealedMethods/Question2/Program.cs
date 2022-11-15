using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        CircleCalculator circle=new CircleCalculator(13);
        circle.Area();
        CylinderCalculator cylinder=new CylinderCalculator(13,14);
        cylinder.Area();
        cylinder.Volume();
    }
}