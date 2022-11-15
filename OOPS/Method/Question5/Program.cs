using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        PrimeNumber(num,2);
    }
    public static void PrimeNumber(int num,int div)
    {
        if(div==num)
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else if(num%div==0)
        {
            Console.WriteLine($"{num} is not a prime number.");
        }
        else{
            div++;
            PrimeNumber(num,div);
        }
    }
}
