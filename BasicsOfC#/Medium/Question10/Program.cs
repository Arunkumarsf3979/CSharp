using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=num;i++)
        {
            if(i==1 || i==num)
            {
                for(int j=1;j<=num*3;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else{
                for(int j=1;j<=num*3;j++)
                {
                    if(j==1 || j==num*3){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}