using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter first number: ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second number: ");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second number: ");
        int num3=Convert.ToInt32(Console.ReadLine());

        if(num1>=num2 && num1>=num3)
        {
            Console.WriteLine($"{num1} is the greatest number");
        }
        else if(num2>=num1 && num2>=num3)
        {
            Console.WriteLine($"{num2} is the greatest number");
        }
        else
        {
            Console.WriteLine($"{num3} is the greatest number");
        }
    }
}