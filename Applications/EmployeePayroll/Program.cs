using System;
using System.Collections.Generic;
namespace EmployeePayroll;

class Program{
    public static void Main(string[] args)
    {
        List<EmployeePayrollManagement> employeeList=new List<EmployeePayrollManagement>();
        Console.WriteLine("-----------------------------------------------------------------------");
        int choice;
        menu:
        do{
            Console.WriteLine("                              Main Menu                               ");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.Exit");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");
        }while(choice<0 || choice>3);
        
        if(choice==1)
        {
            Console.WriteLine("Registration");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Enter your name               :");
            string name=Console.ReadLine();
            Console.Write("Enter you role                :");
            string role=Console.ReadLine();
            Console.Write("Enter your work location      :");
            string workLocation=Console.ReadLine();
            Console.Write("Enter your team name          :");
            string teamName=Console.ReadLine();
            Console.Write("Enter your date of joining    :");
            DateOnly doj=DateOnly.Parse(Console.ReadLine());
            Console.Write("Enter number of working days  :");
            int workingDays=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of leave taken   :");
            double leaveTaken=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your gender             :");
            gender gender=Enum.Parse<gender>(Console.ReadLine(),true);
            Console.WriteLine("-----------------------------------------------------------------");
            EmployeePayrollManagement employee=new EmployeePayrollManagement(name,role,workLocation,teamName,doj,workingDays,leaveTaken,gender);
            Console.WriteLine("Your EmployeeID is generated : "+employee.EmployeeID);
            Console.WriteLine("-----------------------------------------------------------------");
            employeeList.Add(employee);
            goto menu;
        }
        else if(choice==2)
        {
            Console.Write("Enter your employeeID :");
            string employeeID=Console.ReadLine();
            foreach(EmployeePayrollManagement employee in employeeList)
            {
                Console.WriteLine(employee.NumberOfLeaveTaken);
                if(employeeID==employee.EmployeeID)
                {
                    submenu:
                    do{
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("                        Sub Menu                           ");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("1.Calculate salary");
                        Console.WriteLine("2.Display details");
                        Console.WriteLine("3.Exit");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.Write("Enter your choice: ");
                        choice=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------------------------");
                    }while(choice<0 || choice>3);
                    if(choice==1)
                    {
                        Console.WriteLine("Your salary is "+employee.SalaryCalculation(500));
                        goto submenu;
                    }
                    else if(choice==2)
                    {
                        ShowDetails(employee);
                        goto submenu;
                    }
                    else if(choice==3){
                        goto menu;
                    }
                    else{
                        Console.WriteLine("User ID not found");
                        goto menu;
                    }
                }
                else{
                    Console.WriteLine("Invalid ID");
                    goto menu;
                }
            }
            
        }
        else{
            Console.WriteLine("Exited from the application");
        }
    }
    static void ShowDetails(EmployeePayrollManagement employee)
    {
        Console.WriteLine("|-----------------------------------------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|       NAME       |          ROLE         |   WORKLOCATION   |  TEAMNAME  |  DATEOFJOININIG  | WORKING DAYS | LEAVE TAKEN |    GENDER    |");
        Console.WriteLine("|-----------------------------------------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|{0,-18}|{1,-23}|{2,-18}|{3,-12}|{4,-18}|{5,-14}|{6,-13}|{7,-14}|",employee.EmployeeName,employee.Role,employee.WorkLocation,employee.TeamName,employee.DateOfJoining,employee.NumberOfWorkingDays,employee.NumberOfLeaveTaken,employee.Gender);
        Console.WriteLine("|-----------------------------------------------------------------------------------------------------------------------------------------|");
    }
}