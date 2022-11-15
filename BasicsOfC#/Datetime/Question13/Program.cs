using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("input a day: ");
        int day=Convert.ToInt32(Console.ReadLine());
        Console.Write("input a month: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.Write("input a year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        DateTime newDate=new DateTime(year,month,day);
        Console.WriteLine($"The formatted date is {newDate.ToString("dd/MM/yyyy")}");
        string dayName=newDate.ToString("ddddd").ToLower();
        Console.WriteLine(dayName);
        Console.Write("The last day of the week for the above date is: ");
        if(dayName=="monday"){
            Console.Write(newDate.AddDays(5).ToString("dd/MM/yyyy"));
        }
        else if(dayName=="tuesday")
        {
            Console.Write(newDate.AddDays(4).ToString("dd/MM/yyyy"));
        }
        else if(dayName=="wednesday")
        {
            Console.Write(newDate.AddDays(3).ToString("dd/MM/yyyy"));
        }
        else if(dayName=="thursday")
        {
            Console.Write(newDate.AddDays(2).ToString("dd/MM/yyyy"));
        }
        else if(dayName=="friday")
        {
            Console.Write(newDate.AddDays(1).ToString("dd/MM/yyyy"));
        }
        else if(dayName=="saturday")
        {
            Console.Write(newDate.ToString("dd/MM/yyyy"));
        }
        else{
            Console.Write(newDate.AddDays(6).ToString("dd/MM/yyyy"));
        }
    }
}