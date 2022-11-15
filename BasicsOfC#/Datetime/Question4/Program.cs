using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime();
        Console.Write("Enter date: ");
        newDate=DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"The day of the week for {newDate.ToShortDateString()} is {newDate.ToString("ddddd")}");
    }
}