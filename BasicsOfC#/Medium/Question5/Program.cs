using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Leap years from 1 to {year}:");
        for(int i=0;i<=year;i=i+4)
        {
            if(i%400==0 || (i%4==0 && i%100!=0))
            {
                Console.Write(i+" ");
            }
        }
    }
}