using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the salary: ");
        double salary=Convert.ToDouble(Console.ReadLine());
        double monthlySalary;
        if(salary<=10000)
        {
            monthlySalary=salary+salary*0.80+salary*0.20;
        }
        else if (salary<=20000)
        {
            monthlySalary=salary+salary*0.90+salary*0.25;
        }
        else
        {
            monthlySalary=salary+salary*0.30+salary*0.95;
        }
        Console.WriteLine("Take home salary is "+monthlySalary);
        double annualSalary=monthlySalary*12;
        Console.WriteLine("Annaul gross salary is "+(annualSalary-annualSalary*0.06-annualSalary*0.01));
        Console.WriteLine("Annual Gross salary is "+(monthlySalary-monthlySalary*0.06-monthlySalary*0.01)*12);
        // Console.Write("Annual Gross salary is "+annualSalary*12);
        
    }
}