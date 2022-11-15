using System;
using System.Collections.Generic;
namespace BankAccount
{
    public static class Operations
    {
        private static CustomerDetails customer;
        private static List<CustomerDetails> customerList=new List<CustomerDetails>();
        private static List<TransactionDetails> transactionList=new List<TransactionDetails>();
        public static void MainMenu()
        {
            int choice;
            do{
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("                                     Main Menu");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("1.AccountCreation");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.Exit");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------");
            switch(choice)
            {
                case 1:
                {
                    AccountCreation();
                    break;
                }
                case 2:
                {
                    LoginMenu();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exited from the application");
                    break;
                }
                default:
                {
                    Console.WriteLine("Ivalid option enter again");
                    break;
                }
            }
        }while(choice!=3);
    }
        
        private static void LoginMenu()
        {
            int choice;
            Console.Write("Enter your account number :");
            string accNum=Console.ReadLine();
            foreach(CustomerDetails user in customerList)
            {
                if(accNum==user.AccountNumber)
                {
                    customer=user;
                    do{
                        SubMenu();
                        choice=Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                            {
                                ShowAccountDetails();
                                break;
                            }
                            case 2:
                            {
                                
                                Deposit();
                                break;
                            }
                            case 3:
                            {
                                Withdraw();
                                break;
                            }
                            case 4:
                            {
                                Console.WriteLine($"Your balance is {customer.Balance}");
                                break;
                            }
                            case 5:
                            {
                                
                                MoneyTransfer();
                                break;
                            }
                            case 6:
                            {
                                ShowTransactionHistory();
                                break;
                            }
                            case 7:
                            {
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Invalid Option please enter the valid option");
                                break;;
                            }
                        }
                    }while(choice!=7);
                }
            }
        }
        private static void SubMenu()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("                                     Sub Menu");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("1.Show Account Details");
        Console.WriteLine("2.Deposit");
        Console.WriteLine("3.Withdraw");
        Console.WriteLine("4.Show Balance");
        Console.WriteLine("5.Transfer Amount");
        Console.WriteLine("6.Show Transaction History");
        Console.WriteLine("7.Exit");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.Write("Enter your choice: ");
        }
        private static void AccountCreation()
        {
            Console.Write("Enter your name                                     :");
            string name=Console.ReadLine();
            Console.Write("Select Gender Options Male, Female,Transgender      :");
            gender gender= gender.Default;
            bool temp1= Enum.TryParse<gender>(Console.ReadLine(),true, out gender );// True will ignore the case
            while(!temp1)
            {
                Console.WriteLine("Invalid Gender Enter again                  :");
                temp1= Enum.TryParse<gender>(Console.ReadLine(),true, out gender);
            }
            Console.Write("Enter your mobile number                            :");
            string mobile=Console.ReadLine();
            Console.Write("Enter the accounttype SB,CA,RD,FD                   :");
            accountType accType=accountType.Default;
            bool temp2=Enum.TryParse<accountType>(Console.ReadLine(),true,out accType);
            while(!temp2)
            {
                Console.WriteLine("Invalid account type Enter again            :");
                temp2= Enum.TryParse<accountType>(Console.ReadLine(),true, out accType);
            }
            Console.Write("Enter the amount to be deposit at intial            :");
            double amount=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your date of birth                            :");
            DateTime DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your mailID                                   :");
            string mailID=Console.ReadLine();
            Console.Write("Enter your Address                                  :");
            string address=Console.ReadLine();
            CustomerDetails customer1=new CustomerDetails(name,gender,mobile,accType,amount,DOB,mailID,address);
            customerList.Add(customer1);
            Console.WriteLine("Your generated account number is "+customer1.AccountNumber);
        }
        static void ShowAccountDetails()
    {
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("| Account Number |        Name        |   Gender   |   Mobile   | AccountType | Balance | DateOfBirth |          Mail          |   Address   |");
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|{0,-16}|{1,-20}|{2,-12}|{3,-12}|{4,-13}|{5,-9}|{6,-13}|{7,-24}|{8,-13}|",customer.AccountNumber,customer.CustomerName,customer.Gender,customer.MobileNumber,customer.AccountType,customer.Balance,customer.DateOfBirth.ToShortDateString(),customer.MailID,customer.Address);
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");
    }
    private static void Deposit()
    {
        Console.Write("Enter the amount to be deposited :");
        double amount=Convert.ToInt32(Console.ReadLine());
        customer.Balance=customer.Balance+amount;
        TransactionDetails transaction=new TransactionDetails(customer.AccountNumber,customer.AccountNumber,customer.AccountType,Enum.Parse<transactionType>("Deposit",true),amount,DateTime.Today);
        transactionList.Add(transaction);
        Console.WriteLine("Your amount have been depsoited");
    }
    private static void Withdraw()
    {
        Console.Write("Enter the amount to be withdraw :");
        double amount=Convert.ToInt32(Console.ReadLine());
        if(customer.Balance<amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            customer.Balance=customer.Balance-amount;
            TransactionDetails transaction=new TransactionDetails(customer.AccountNumber,customer.AccountNumber,customer.AccountType,Enum.Parse<transactionType>("Withdraw",true),amount,DateTime.Today);
            transactionList.Add(transaction);
            Console.WriteLine("Withdrew successfully and your remaining balance is "+customer.Balance);
        }
    }
    private static void MoneyTransfer()
    {
        Console.Write("Enter account number for money transfer :");
        string transferAcc=Console.ReadLine();
        bool flag=true;
        foreach(CustomerDetails customer1 in customerList)
        {
            if(customer1.AccountNumber==transferAcc)
            {
                Console.Write("Enter the amount to be transfered :");
                int amount=Convert.ToInt32(Console.ReadLine());
                if(customer.Balance>amount)
                {
                    flag=false;
                    customer.Balance=customer.Balance-amount;
                    customer1.Balance=customer1.Balance+amount;
                    TransactionDetails transaction=new TransactionDetails(customer.AccountNumber,transferAcc,customer.AccountType,Enum.Parse<transactionType>("Transfer",true),amount,DateTime.Today);
                    transactionList.Add(transaction);
                    Console.WriteLine("Money transferred successfully");
                }
                else
                {
                    Console.WriteLine("Insufficient Fund to Transfer");
                    break;
                }
                break;
            }
        }
        if(flag)
        {
            Console.WriteLine("Invalid Account Information");
        }
    }
    private static void ShowTransactionHistory()
    {
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("| TransactionID | FromAccount | ToAccount | AccountType | TransactionType |   Amount   |     TxnDate     |");
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
        foreach(TransactionDetails transaction in transactionList)
        {
            if((customer.AccountNumber==transaction.FromAccount)||(customer.AccountNumber==transaction.ToAccount))
            {
                Console.WriteLine("|{0,-15}|{1,-13}|{2,-11}|{3,-13}|{4,-17}|{5,-12}|{6,-17}|",transaction.TransactionID,transaction.FromAccount,transaction.ToAccount,transaction.AccountType,transaction.TransactionType,transaction.Amount,transaction.TransactionDate.ToShortDateString());
                Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
            }
        }
    }


    public static void DefaultDetailsOfCustomer()
    {
        CustomerDetails customer1=new CustomerDetails("Ravi",Enum.Parse<gender>("Male",true),"995699",Enum.Parse<accountType>("SB",true),10000,Convert.ToDateTime("11/11/1999"),"ravi@gmail.com","Theni");
        CustomerDetails customer2=new CustomerDetails("Baskaran",Enum.Parse<gender>("Male",true),"959558",Enum.Parse<accountType>("SB",true),10000,Convert.ToDateTime("11/11/1999"),"baskar@gmail.com","Chennai");
        CustomerDetails customer3=new CustomerDetails("Ravi",Enum.Parse<gender>("Male",true),"959558",Enum.Parse<accountType>("CA",true),10000,Convert.ToDateTime("11/11/1999"),"ravi@gmail.com","Theni");
        customerList.Add(customer1);
        customerList.Add(customer2);
        customerList.Add(customer3);
    }
    public static void DefaultDetailsOfTransaction()
    {
        TransactionDetails transaction1=new TransactionDetails("10001","10001",Enum.Parse<accountType>("SB",true),Enum.Parse<transactionType>("Deposit",true),10000,Convert.ToDateTime("10/11/2022"));
        TransactionDetails transaction2=new TransactionDetails("10001","10002",Enum.Parse<accountType>("SB",true),Enum.Parse<transactionType>("Transfer",true),5000,Convert.ToDateTime("10/11/2022"));
        TransactionDetails transaction3=new TransactionDetails("10002","10003",Enum.Parse<accountType>("CA",true),Enum.Parse<transactionType>("Transfer",true),6000,Convert.ToDateTime("10/15/2022"));
        TransactionDetails transaction4=new TransactionDetails("10002","10002",Enum.Parse<accountType>("SB",true),Enum.Parse<transactionType>("Withdraw",true),1000,Convert.ToDateTime("10/17/2022"));
        transactionList.Add(transaction1);
        transactionList.Add(transaction2);
        transactionList.Add(transaction3);
        transactionList.Add(transaction4);
    }
    }
}