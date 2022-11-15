using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<4;i++)
        {
            for(int k=i;k<4;k++)
            {
                Console.Write(" ");
            }
            for(int j=0;j<i+1;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
