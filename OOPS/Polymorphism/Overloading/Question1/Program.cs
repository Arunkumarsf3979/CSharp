using System;
namespace Question1;
// 1.	Create a set of Multiply method inside a class
// a.	Method with one argument and display the Square value of a given number.
// b.	 Method with 2 arguments with same argument type and display result.
// c.	Method with 3 arguments with same argument type and display the result. 
// d.	Method with 2 arguments with different argument type and display result.
// e.	Method with 3 arguments with different argument type and display the result. 
// Call the above 5 methods and print the results.

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine(Display(12));
        Console.WriteLine(Display(12,15));
        Console.WriteLine(Display(10,34,10));
        Console.WriteLine(Display("Arun","Kumar"));
        Console.WriteLine(Display("Arun","Kumar","Ragu"));
    }
    public static int Display(int number)
    {
        return number*number;
    }
    public static int Display(int number1,int number2)
    {
        return number1*number2;
    }
    public static int Display(int number1,int number2,int number3)
    {
        return number1*number2*number3;
    }
    public static string Display(string myStr1,string myStr2)
    {
        return myStr1+myStr2;
    }
    public static string Display(string myStr1,string myStr2,string myStr3)
    {
        return myStr1+myStr2+myStr3;
    }
}