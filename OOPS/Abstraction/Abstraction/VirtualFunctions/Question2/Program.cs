using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Rectangle rectangle=new Rectangle(20,23,15,25);
        System.Console.WriteLine("Rectangle");
        rectangle.Calculate();
        rectangle.Display();
        Sphere sphere=new Sphere(20,24,3.5333);
        System.Console.WriteLine("Sphere");
        sphere.Calculate();
        sphere.Display();
    }
}