using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a count :");
        int count=Convert.ToInt32(Console.ReadLine());
        int i=1;
        int sum=0;
        int num;
        while(i<=count)
        {
            Console.Write($"number :");
            num=Convert.ToInt32(Console.ReadLine());
            sum=sum+i*i;
            i++;
        }
        Console.WriteLine($"sum of squares :{sum}");
    }
}
