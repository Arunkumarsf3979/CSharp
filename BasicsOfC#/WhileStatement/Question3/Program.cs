using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input number of terms to display :");
        int terms=Convert.ToInt32(Console.ReadLine());
        int num1=0;
        int num2=1;
        int i=0;
        int temp;
        Console.Write("Here is the Fibonacci series upto to 10 terms : ");
        while(i<terms)
        {
            Console.Write($"{num1} ");
            temp=num1;
            num1=num2;
            num2=num1+temp;
            i++;
        }
    }
}
