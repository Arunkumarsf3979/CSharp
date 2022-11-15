using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the starting number: ");
        int start=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the difference number: ");
        int difference=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the number of elements: ");
        int terms=Convert.ToInt32(Console.ReadLine());
        Console.Write("output series: ");
        int arithmetic=start;
        int sum=arithmetic;
        Console.Write(arithmetic+" ");
        for(int i=0;i<terms-1;i++)
        {
            arithmetic=arithmetic+difference;
            sum=sum+arithmetic;
            Console.Write(arithmetic+" ");
        }
        Console.WriteLine();
        Console.WriteLine($"Sum of series is {sum}");
    }
}