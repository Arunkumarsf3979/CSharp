using System;
namespace SingleCasting;
public delegate int Calculator(int value);//Can add methods having int return type and i int arg

class Program{
    static int value=10;
    public static int Add(int number){value+=number;return value;}
    public static int Multiply(int number){value*=number;return value;}
    public static int GetNum(){return value;}
    public static void Main(string[] args)
    {
        Calculator nc1=new Calculator(Add);
        Calculator nc2=new Calculator(Multiply);
        System.Console.WriteLine("Output "+Add(10));
        System.Console.WriteLine("Output "+nc1(25));
        System.Console.WriteLine("value of num {0}:",GetNum());
        System.Console.WriteLine("output "+nc2(5));
        System.Console.WriteLine("Value of num {0}:",GetNum());
    }
}