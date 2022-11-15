using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo(10000,"January",DateTime.Today,8);
        salary.DisplaySalary();
    }
}
