using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        int num1=0;
        int num2=1;
        int temp;
        int i=0;
        while(i<num)
        {
            Console.Write(num1+" ");
            temp=num1;
            num1=num2;
            num2=temp+num1;
            i++;
        }
    }
}