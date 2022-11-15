using System;
namespace Question14;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=num;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}