using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the number of terms :");
        int terms=Convert.ToInt32(Console.ReadLine());
        int num1=0;
        int num2=1;
        int temp;
        int i=0;
        Console.Write("Here is the Fibonacci series upto to 10 terms :");
        do{
            Console.Write($"{num1} ");
            temp=num1;
            num1=num2;
            num2=num1+temp;
            i++;
        }while(i<terms);
    }
}