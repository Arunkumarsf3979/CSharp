using System;
namespace MultiCasting;
public delegate int Calculator(int value);//Can add methods having int return type and i int arg
class Program{
    static int value=10;
    public static int Add(int number){value+=number;return value;}
    public static int Multiply(int number){value*=number;return value;}
    public static int GetNum(){return value;}
    public static void Main(string[] args)
    {
        Calculator nc;
        nc=new Calculator(Add);
        nc+=new Calculator(Multiply);
        int result=nc(5);
        Console.WriteLine("value of num1 {0} ",GetNum());
        System.Console.WriteLine(result);
        // nc(10);
        // Console.WriteLine("value of num1 {0} ",GetNum());
        // nc(5);
        // Console.WriteLine("value of num1 {0} ",GetNum());
        // nc(10);
        // Console.WriteLine("value of num1 {0} ",GetNum());
    }
}
