using System;
namespace Question2;
public delegate int EventManager(int number1,int number2);
class Program{
    public static EventManager addition,subtraction,multiplication;
    public static int  Addition(int number1,int number2)
    {
        return number1+number2;
    }
    public static int  Subtraction(int number1,int number2)
    {
        return number1-number2;
    }
    public static int  Multipilcation(int number1,int number2)
    {
        return number1*number2;
    }
    public static void Main(string[] args)
    {
        addition=new EventManager(Addition);
        subtraction=new EventManager(Subtraction);
        multiplication=new EventManager(Multipilcation);
        System.Console.WriteLine(addition(2,5));
    }
}