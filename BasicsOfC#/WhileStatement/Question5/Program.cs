using System;
namespace Question;
class Question1{
    public static void Main(string[] args)
    {
        Console.Write("enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        int temp=num;
        int sum=0;
        while(temp>0)
        {
            sum=sum+temp%10;
            temp=temp/10;
        }
        Console.WriteLine($"sum of digits of {num} is {sum}");
    }
}
