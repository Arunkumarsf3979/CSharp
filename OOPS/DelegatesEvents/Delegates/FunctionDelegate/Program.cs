using System;
namespace FucntionDelegate;
class Program{
    static double Sum(int number1,int number2)
    {
        return number1+number2;
    }
    static double Multiply(int number1,int number2)
    {
        return number1*number2;
    }
    static double Calculator(Func<int, int,double> operation,int x,int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        Func<int,int,double> operation=Multiply;
        operation+=Sum;//for multicasting
        double result=operation(10,20);
        System.Console.WriteLine("final result :"+result);
        System.Console.WriteLine(Calculator(Sum,10,20));
        System.Console.WriteLine(Calculator(Multiply,10,20));

    }
}
