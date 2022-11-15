using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=num;i++)
        {
            Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}");
        }
    }
}
