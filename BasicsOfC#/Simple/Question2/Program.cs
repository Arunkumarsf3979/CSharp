using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the radius: ");
        double radius=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area is {3.14*radius*radius}");
        Console.WriteLine($"Perimeter is{2*3.14*radius} ");
    }
}