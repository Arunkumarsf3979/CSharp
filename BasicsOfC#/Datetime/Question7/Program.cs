using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime();
        Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
        newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        DateTime newDate2=new DateTime();
        Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
        newDate2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        int res1=DateTime.Compare(newDate2,newDate);
        if(res1>0)
        {
            Console.WriteLine($"{res1}:{newDate} is earlier than {newDate2} ");
        }
        else
        {
            Console.WriteLine($"{res1}:{newDate} is later than {newDate2} ");
        }
    }
}