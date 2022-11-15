using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the value of x: ");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of y: ");
        int y=Convert.ToInt32(Console.ReadLine());
        int res=x;
        for(int i=0;i<y-1;i++)
        {
            res=res*x;
        }
        Console.Write("The answer is "+res);
    }
}