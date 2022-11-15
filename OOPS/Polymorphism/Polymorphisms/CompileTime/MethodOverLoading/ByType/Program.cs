using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        Display(10,20);
        Display("arun","kumar");
    }
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine($"Numbers  are {number1} and {number2}");
    }
    static void Display(string myStr1,string myStr2)
    {
        System.Console.WriteLine($"String are {myStr1} and{myStr2}");
    }
}