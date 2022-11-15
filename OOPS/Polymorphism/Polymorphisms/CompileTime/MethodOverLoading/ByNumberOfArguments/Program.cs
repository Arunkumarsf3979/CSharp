using System;
namespace ByNumberOfArguments;
class Program{
    public static void Main(string[] args)
    {
        Display(10);
        Display(10,20);
    }
    static void Display(int number1)
    {
        System.Console.WriteLine("Number is "+number1);
    }
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine($"numbers are {number1} and{number2}");
    }
}
