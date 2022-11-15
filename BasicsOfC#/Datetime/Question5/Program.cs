using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the starting date: ");
        DateTime newDate1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.Write("enter the ending date: ");
        DateTime newDate2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        for(int i=newDate1.Year;i<=newDate2.Year-1;i++)
        {
            newDate1=newDate1.AddYears(1);
            if(DateTime.IsLeapYear(i)){
                Console.WriteLine($"{newDate1.ToString("d")}: day 366 of {newDate1.AddYears(-1).ToString("d")}(Leap year)" );
            }
            else{
                Console.WriteLine($"{newDate1.ToString("d")}: day 365 of {newDate1.AddYears(-1).ToString("d")}" );
            }
        }
        TimeSpan newTime=newDate2.Subtract(newDate1);
        Console.WriteLine($"{newDate1.ToString("d")}: day {newTime.Days} of {newDate2.ToString("d")}" );
    }
}