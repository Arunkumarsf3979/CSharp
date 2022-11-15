using System;
namespace Action;
class Program{

    static void Add(int number1,int number2)
    {
        System.Console.WriteLine("Output "+(number1-number2));
    }
    static void Multiply(int number1,int number2)
    {
        System.Console.WriteLine("Output "+(number1*number2));
    }
    static void Calculator(Action<int,int> action, int input1,int input2)
    {
        action(input1,input2);
    }
    public static void Main(string[] args)
    {
        Action<int,int> action=Add;
        action+=Multiply;
        action(10,20);
        Calculator(Add,10,10);
    }
}
