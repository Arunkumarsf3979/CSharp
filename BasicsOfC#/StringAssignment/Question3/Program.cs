using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the String: ");
        String myStr=Console.ReadLine();
        Console.Write("The characters of the string in reverse are :");
        for(int i=myStr.Length-1;i>=0;i--)
        {
            Console.Write($"{myStr[i]} ");
        }
    }
}
