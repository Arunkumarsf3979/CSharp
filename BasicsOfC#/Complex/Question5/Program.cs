using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your date of birth: ");
        DateTime DOB=new DateTime();
        DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        TimeSpan newdate=DateTime.Today.Subtract(DOB);
        Console.WriteLine("Your age is "+newdate.Days/365);
        Console.WriteLine("Day you were born "+DOB.ToString("ddddd"));
        Console.WriteLine("Days: "+newdate.Days);
        Console.WriteLine("Hours: "+newdate.Hours);
        Console.WriteLine("Minutes: "+newdate.Minutes);
        Console.WriteLine("Seconds: "+newdate.Seconds);
        Console.WriteLine("Milliseconds: "+newdate.Milliseconds);
    }
}