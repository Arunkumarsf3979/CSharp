using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the speed: ");
        float speed=Convert.ToSingle(Console.ReadLine());
        if(speed<=10)
        {
            Console.WriteLine("Slow");
        }
        else if(speed>10 && speed<=50)
        {
            Console.WriteLine("Average");
        }
        else if(speed>50 && speed<=150)
        {
            Console.WriteLine("Fast");
        }
        else if(speed>150 && speed<=1000)
        {
            Console.WriteLine("Ultrafast");
        }
        else{
            Console.WriteLine("Extremely fast");
        }
    }
}