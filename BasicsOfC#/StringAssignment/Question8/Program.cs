using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the  first String: ");
        String myStr1=Console.ReadLine();
        Console.Write("Input the position to start extraction :");
        int pos=Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the length of substring :");
        int subPos=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(myStr1.Substring(pos,subPos));
    }
}