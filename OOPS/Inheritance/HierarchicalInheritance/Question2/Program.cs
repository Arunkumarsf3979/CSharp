using System;
using System.Collections.Generic;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        List<TemporaryEmployee> temporaryEmployeeList=new List<TemporaryEmployee>();
        List<PermanentEmployee> permanentEmployeeList=new List<PermanentEmployee>();
        TemporaryEmployee temporaryEmployee1=new TemporaryEmployee(10000,"JANUARY","Temporary");
        TemporaryEmployee temporaryEmployee2=new TemporaryEmployee(20000,"February","Temporary");
        temporaryEmployeeList.Add(temporaryEmployee1);
        temporaryEmployeeList.Add(temporaryEmployee2);
        
        PermanentEmployee permanentEmployee1=new PermanentEmployee(15000,"november","Permanent");
        PermanentEmployee permanentEmployee2=new PermanentEmployee(25000,"October","Permanent");
        permanentEmployeeList.Add(permanentEmployee1);
        permanentEmployeeList.Add(permanentEmployee2);

        foreach(TemporaryEmployee temporary in temporaryEmployeeList)
        {
            System.Console.WriteLine("                Temporary Employee");
            temporary.CalculateTotalSalary();
            temporary.ShowSalary();
        }
        foreach(PermanentEmployee permanent in permanentEmployeeList)
        {
            System.Console.WriteLine("                Permanent Employee");
            permanent.CalculateTotalSalary();
            permanent.ShowSalary();
        }
    }
}