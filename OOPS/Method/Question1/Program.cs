using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        // Addition
        int Addition(int num1,int num2)
        {
            return num1+num2;
        }
        // Subtraction
        int Subtraction(int num1,int num2)
        {
            return num1-num2;
        }
        int Multiplication(int num1,int num2)
        {
            return num1*num2;
        }
        int Division(int num1,int num2)
        {
            return num1/num2;
        }
        Console.Write("Input 1:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 2:");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition: "+Addition(num1,num2));
        Console.WriteLine("Subtraction: "+Subtraction(num1,num2));
        Console.WriteLine("Multiplication: "+Multiplication(num1,num2));
        Console.WriteLine("Division: "+Division(num1,num2));
    }
}