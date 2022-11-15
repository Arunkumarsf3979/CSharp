using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        int num;
        for(int i=0;i<10;i++)
        {
            Console.Write("enter a number: ");
            num=Convert.ToInt32(Console.ReadLine());
            sum=sum+num;
        }
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {sum/10}");
        
    }
}