using System;
namespace Interfaces;
class Program{
    public static void Main(string[] args)
    {
        Square number=new Square();
        number.Number=10;
        // number.Calculate();
        Console.WriteLine(number.Calculate());
        ICalculate value=new Square();
        value.Number=20;
        System.Console.WriteLine(value.Calculate());
    }
}