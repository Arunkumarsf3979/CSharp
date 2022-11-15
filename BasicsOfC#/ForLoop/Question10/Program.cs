using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        bool temp=true;
        for(int i=2;i<num;i++)
        {
            if(num%i==0)
            {
                Console.WriteLine($"{num} is not an primenumber");
                temp=false;
                break;
            }
        }
        if(temp)
        {
            Console.WriteLine($"{num} is a prime number");
        }
    }
}