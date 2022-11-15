using System;
using System.Collections.Generic;
namespace EB;
class Program{
    public static void Main(string[] args)
    {
        List<EBBill> EBList=new List<EBBill>();
        Console.WriteLine("-----------------------------------------------------------------");
        menu:
        Console.WriteLine("                          Main Menu                              ");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("1.Registration");
        Console.WriteLine("2.Login");
        Console.WriteLine("3.Exit");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.Write("Enter your choice: ");
        int choice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------------------------------------------------------");
        if(choice==1)
        {
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your phonenumber: ");
            string phone=Console.ReadLine();
            Console.Write("Enter your mailID: ");
            string mailID=Console.ReadLine();
            Console.Write("Enter total units used: ");
            double units=Convert.ToDouble(Console.ReadLine());
            EBBill customer=new EBBill(name,phone,mailID,units);
            EBList.Add(customer);
            Console.WriteLine("Your customer ID is generated :"+customer.MeterID);
            goto menu;
        }
        else if(choice==2)
        {
            foreach(EBBill customer in EBList)
            {
                Console.Write("Enter your meterID: ");
                string meterID=Console.ReadLine();
                if(meterID==customer.MeterID)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    submenu:
                    Console.WriteLine("                          Sub Menu                              ");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("1.Calculate Amount");
                    Console.WriteLine("2.Show details");
                    Console.WriteLine("3.Exit");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.Write("Enter your choice: ");
                    choice=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------------------");
                    if(choice==1)
                    {
                        Console.WriteLine("The amount to be paid: "+customer.CalculateAmount());
                        goto submenu;
                    }
                    else if(choice==2)
                    {
                        ShowDetails(customer);
                        goto submenu;
                    }
                    else 
                    {
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
    static void ShowDetails(EBBill customer)
            {
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
                Console.WriteLine("|   MeterID   |      UserName      |   PhoneNumber   |          MailID          |  UnitsUsed  |   Amount   |");
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
                Console.WriteLine("|{4,-13}|{0,-20}|{1,-17}|{2,-26}|{3,-13}|{5,-18}|",customer.UserName,customer.PhoneNumber,customer.Mail,customer.UnitsUsed,customer.MeterID,Math.Round(customer.CalculateAmount(),2));
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            }
}