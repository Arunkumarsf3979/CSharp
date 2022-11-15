using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int num;
        int sum=0;
        do{
            Console.Write("Enter the number:");
            num=Convert.ToInt32(Console.ReadLine());
            if(num>0)
            {
                sum=sum+num;
            }
        }while(num>0);
        Console.WriteLine($"The sum is {sum}");
    }
}