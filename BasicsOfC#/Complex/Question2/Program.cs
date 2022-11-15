using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        double res=1;
        for(int i=1;i<=num;i++)
        {
            res=res+Math.Pow(2,i)/fact(i);
        }
        Console.WriteLine(Math.Round(res,4));
    }
    public static int fact(int num)
    {
        int product=1;
        for(int i=1;i<=num;i++)
        {
            product=product*i;
        }
        return product;
    }
}
