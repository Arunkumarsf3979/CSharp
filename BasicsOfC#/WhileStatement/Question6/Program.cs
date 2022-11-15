using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        Console.WriteLine("even numbers are: ");
        while(i<=100){
            Console.Write($"{i} ");
            i=i+2;
        }

        Console.WriteLine();
        Console.WriteLine("odd numbers are :");
        i=1;
        while(i<=100)
        {
            Console.Write($"{i} ");
            i=i+2;
        }

        Console.WriteLine();
        Console.WriteLine("prime numbers are :");
        i=3;
        int j;
        bool temp;
        Console.Write($"{2} ");
        while(i<100)
        {
            j=2;
            temp=true;
            while(j<i)
            {
                if(i%j==0)
                {
                    temp=false;
                    break;
                }
                j++;
            }
            if(temp)
            {
                Console.Write($"{i} ");
            }
            i++;
        }
    }
}