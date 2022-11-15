using System;
namespace Question8;
class Program{
    public delegate int Events(int number1,int number2);
    public static Events addition,subtraction,multiplication;
    public static void Main(string[] args)
    {
        addition+=new Events(Calculator.Addition);
        subtraction+=new Events(Calculator.Subtraction);
        multiplication+=new Events(Calculator.Multiplication);
        Calculator.MainMenu();
        System.Console.WriteLine(multiplication(4,5));
    }
}