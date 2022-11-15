using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the data :");
        int temp=Convert.ToInt32(Console.ReadLine());
        if(temp<0)
        {
            Console.WriteLine("Freezing Weather");
        }
        else if(temp>+0 && temp<10)
        {
            Console.WriteLine("Very Cold Weather");
        }
        else if(temp>=10 && temp<20)
        {
            Console.WriteLine("Cold Weather");
        }
        else if(temp>=20 && temp<30)
        {
            Console.WriteLine("Normal Weather");
        }
        else if(temp>=30 && temp<40)
        {
            Console.WriteLine("Hot Weather");
        }
        else 
        {
            Console.WriteLine("Very Hot Weather");
        }
    }
}