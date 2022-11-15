using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime(2021,10,26);
        DateTime newDate2=new DateTime(2023,11,26);
        int res1=DateTime.Compare(newDate,DateTime.Today);
        int res2=DateTime.Compare(newDate2,DateTime.Today);
        if(res1>0)
        {
            Console.WriteLine($"{res1}:{DateTime.Today.ToShortDateString()} is earlier than {newDate.ToShortDateString()} ");
        }
        else
        {
            Console.WriteLine($"{res1}:{DateTime.Today.ToShortDateString()} is later than {newDate.ToShortDateString()} ");
        }
        if(res2>0)
        {
            Console.WriteLine($"{res2}:{DateTime.Today.ToShortDateString()} is earlier than {newDate2.ToShortDateString()} ");
        }
        else
        {
            Console.WriteLine($"{res2}:{DateTime.Today.ToShortDateString()} is later than {newDate2.ToShortDateString()} ");
        }
    }
}