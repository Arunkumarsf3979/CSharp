using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        long sum=0;
        for(int i=1;i<=99;i=i+2)
        {
            sum=sum+i*i;
        }
        Console.Write("The sum of squares is "+sum);
    }
}