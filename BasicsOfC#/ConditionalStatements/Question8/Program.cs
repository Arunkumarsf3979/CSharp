using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter your sugar level :");
        float level=Convert.ToSingle(Console.ReadLine());
        if(level<90)
        {
            Console.WriteLine("Low sugar");
        }
        else if(level>=90 && level<130)
        {
            Console.WriteLine("Normal");
        }
        else if(level>=130 && level<140)
        {
            Console.WriteLine("Medium");
        }
        else if(level>=140 && level<170)
        {
            Console.WriteLine("High sugar – try to reduce it from now");
        }
        else{
            Console.WriteLine(" You are a very high Sugar Patient");
        }
    }
}