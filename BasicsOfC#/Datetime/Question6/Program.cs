using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        DateTime newdate=new DateTime();
        newdate=DateTime.Today;
        DateTime newdate2=newdate.AddDays(40);
        Console.Write(newdate2.ToString("ddddd"));
    }
}