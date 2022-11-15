using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        int temp=1;
        Console.Write("Enter the rows: ");
        int row=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=row;i++)
        {
            for(int j=0;j<row-i;j++)
            {
                Console.Write(" ");
            }
            for(int k=0;k<temp;k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            temp=temp+2;
        }
    }
}