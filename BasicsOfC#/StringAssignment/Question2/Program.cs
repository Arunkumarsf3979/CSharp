using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the String: ");
        String myStr=Console.ReadLine();
        Console.Write("The character of the string are: ");
        for(int i=0;i<myStr.Length;i++)
        {
        Console.Write($"{myStr[i]} ");
        }
    }
}
