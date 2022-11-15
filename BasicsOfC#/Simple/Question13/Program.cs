using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=20;i++)
        {
            Console.WriteLine($"{num} X {i} = {num*i}");
        }
    }
}