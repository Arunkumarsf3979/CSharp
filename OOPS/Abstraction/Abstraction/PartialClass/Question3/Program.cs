using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Addition");
        Console.WriteLine(Calculator.Addition(5,2));
        System.Console.WriteLine("Subtraction");
        Console.WriteLine(Calculator.Subtraction(10,2));
        System.Console.WriteLine("Sin");
        Console.WriteLine(Calculator.Sin(90));
        System.Console.WriteLine("Cos");
        Console.WriteLine(Calculator.Cos(60));
        System.Console.WriteLine("Tan");
        Console.WriteLine(Calculator.Tan(45));
    }
}