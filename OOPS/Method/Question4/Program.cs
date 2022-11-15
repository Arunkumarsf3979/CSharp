using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the number of fibonacci series: ");
        int fib=Convert.ToInt32(Console.ReadLine());
        Console.Write("The Fibonacci series of 5 numbers is :");
        for(int i=0;i<fib;i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
    }
    public static int Fibonacci(int fib)
    {
        if(fib<2)
        {
            return fib;
        }
        return (Fibonacci(fib-1)+Fibonacci(fib-2));
    }
}