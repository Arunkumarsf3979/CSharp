using System;
namespace Question7;
class Program{
    public static void Main(string[] args){
        Console.Write("enter a number :");
        int num=Convert.ToInt32(Console.ReadLine());
        double armstrong=0;
        int temp;
        int count=0;
        for(temp=num;temp>0;temp=temp/10)
        {
            count++;
        }
        Console.WriteLine(count);
        for(temp=num;temp>0;temp=temp/10)
        {
            armstrong=armstrong+Math.Pow(temp%10,count);
        }
        if(armstrong==num)
        {
            Console.WriteLine($"{num} is a armstrong number");
        }
        else{
            Console.WriteLine($"{num} is not a armstrong number");
        }
    }
}