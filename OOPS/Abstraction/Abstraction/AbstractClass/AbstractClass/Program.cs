using System;
namespace AbstractClass;
class Program{
    public static void Main(string[] args)
    {
        Syncfusion job1=new Syncfusion();
        job1.Name="Developer";
        job1.Salary(30);

        TCS job2=new TCS();
        job2.Name="Testing engineer";
        job2.Salary(15);
    }
}
