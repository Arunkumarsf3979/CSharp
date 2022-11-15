using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        Console.Write("The odd numbers are : ");
        for(int i=1;i<num*2;i+=2)
        {
            Console.Write($"{i} ");
            sum=sum+i;
        }
        Console.WriteLine();
        Console.WriteLine($"The Sum of odd Natural Number upto 10 terms : {sum}");
    }
}