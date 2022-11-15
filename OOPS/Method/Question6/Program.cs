using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The factorial of {num}! is: {Fact(num)}");
    }
    public static int Fact(int num)
    {
        if(num==1)
            return 1;
        return num*Fact(num-1);
    }
}
