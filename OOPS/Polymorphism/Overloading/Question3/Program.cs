using System;
namespace Question3;

// 3.	Create a set of methods that will calculate the square of given type number
// a.	Compute square of given integer
// b.	Compute square of given float
// c.	Compute square of given double
// d.	Compute square of given long

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(CalculateSquare(10));
        System.Console.WriteLine(CalculateSquare(14.5));
        System.Console.WriteLine(CalculateSquare(12.89338));
        System.Console.WriteLine(CalculateSquare(12327843433043));
    }
    static int CalculateSquare(int number)
    {
        return number*number;
    }
    static float CalculateSquare(float number)
    {
        return number*number;
    }
    static double CalculateSquare(double number)
    {
        return number*number;
    }
    static long CalculateSquare(long number)
    {
        return number*number;
    }
}