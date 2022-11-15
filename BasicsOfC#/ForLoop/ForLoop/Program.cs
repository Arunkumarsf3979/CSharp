using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<25;i+=2)
        {
            Console.WriteLine(i);
        }

        Console.Write("Enter the initial: ");
        int start=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the initial: ");
        int final=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i=start;i<=final;i++)
        {
            sum=sum+i*i;
        }
        Console.WriteLine($"sum of squares: {sum}");
    }
}
