using System;
namespace Question3;
class Program{
    static int num1;
    static int num2;
    public static void Main(string[] args)
    {
        Console.Write("Enter a number :");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a another number :");
        num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before Swapping");
        Console.WriteLine($"The first number is {num1}");
        Console.WriteLine($"The second number is {num2}");
        Swap(num1,num2);
        
    }
    public static void Swap(int num1,int num2)
    {
        int temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine("After Swapping");
        Console.WriteLine($"Now the first number is {num1}");
        Console.WriteLine($"Now the second number is {num2}");
    }
}