using System;
using System.Collections.Generic;
namespace Bank;
class Program{
    public static void Main(string[] args)
    {
        List<BankApplication> bankList=new List<BankApplication>();
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
            Console.Write("Enter your gender: ");
            gender gender=Enum.Parse<gender>(Console.ReadLine(),true);
            Console.Write("Enter your Phone number: ");
            string phone=Console.ReadLine();
            Console.Write("Enter your mailID: ");
            string mailID=Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            DateOnly dob=DateOnly.Parse(Console.ReadLine());
            BankApplication customer1=new BankApplication(name,phone,gender,mailID,dob);
            bankList.Add(customer1);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Your customerID is generated :"+customer1.CustomerID);
            Console.WriteLine("-----------------------------------------------------------------");
            goto menu;
        }
        else if(choice==2)
        { 
            Console.Write("Enter your customer ID: ");
            string customerID=Console.ReadLine();
            
            foreach(BankApplication customer in bankList)
            {
                if(customer.CustomerID==customerID)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    submenu:
                    Console.WriteLine("                          Sub Menu                              ");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("1.Deposit");
                    Console.WriteLine("2.Withdraw");
                    Console.WriteLine("3.Balance Check");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.Write("Enter your choice: ");
                    choice=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------------------");
                    if(choice==1)
                    {
                        Console.Write("Enter the amount to be deposited: ");
                        double amount=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The account balance after deposition is "+customer.Deposit(amount));
                        Console.WriteLine("-----------------------------------------------------------------");
                        goto submenu;
                    }
                    else if(choice==2)
                    {
                        Console.Write("Enter the amount to be withdraw: ");
                        double amount=Convert.ToInt32(Console.ReadLine());
                        customer.Withdraw(amount);
                        Console.WriteLine("-----------------------------------------------------------------");
                        goto submenu;
                    }
                    else if(choice==3)
                    {
                        Console.WriteLine("Your balance is "+customer.Balance);
                        Console.WriteLine("-----------------------------------------------------------------");
                        goto submenu;
                    }
                    else
                    {
                        goto menu;
                    }
                }
                else{
                    Console.WriteLine("Invalid Id");
                    goto menu;
                }
            }
        }
        else
            {
                Console.WriteLine("Exited from application");
            }
    }
    
}
