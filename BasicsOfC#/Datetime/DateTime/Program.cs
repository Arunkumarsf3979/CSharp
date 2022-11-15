using System;
namespace Datetime;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine("year "+ newDate.Year);
        Console.WriteLine("Month "+ newDate.Month);
        Console.WriteLine("Day "+ newDate.Day);
        Console.WriteLine("Hour "+ newDate.Hour);
        Console.WriteLine("Minute "+ newDate.Minute);
        Console.WriteLine("Second "+ newDate.Second);

        // Console.WriteLine(newDate.ToString("yyyy/MM/dd HH:mm:ss tt"));
        String []arr=newDate.ToString("yyyy/MM/dd HH:mm:ss tt").Split('/',':',' ');
        for(int i=arr.Length-1;i>=0;i--)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();

        DateTime newDate2=new DateTime();
        Console.Write("Enter the date and time in yyyy/MM/dd hh:mm:ss tt  :");
        newDate2=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine("year "+ newDate2.Year);
        Console.WriteLine("Month "+ newDate2.Month);
        Console.WriteLine("Day "+ newDate2.Day);
    }
}
