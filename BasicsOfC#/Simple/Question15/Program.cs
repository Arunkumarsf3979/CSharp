using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        bool flag=true;
        if(num==2)
        {
            Console.Write("It is a prime number");
        }
        else{
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    flag=false;
                    Console.Write("It is not a prime number");
                    break;
                }
            }
            if(flag)
            {
                Console.Write("It is prime number");
            }
        }
    }
}