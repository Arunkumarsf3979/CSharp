using System;
using System.Collections.Generic;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        List<AccountInfo> accountList=new List<AccountInfo>();
        // Update, Show Account Info, deposit, withdraw and Show Balance  
        AccountInfo account1=new AccountInfo("Stefan","Salvatore","89034838","stefan@gmail.com",Gender.Male,12345,"Guindy","HDFC101",45000);
        AccountInfo account2=new AccountInfo("Damon","Salvatore","98309480","damon@gmail.com",Gender.Male,12346,"Guindy","HDFC102",55450);
        AccountInfo account3=new AccountInfo("Elena","Gilbert","673343278","elena@gmail.com",Gender.Female,12347,"Chetpet","HDFC103",34890);
        accountList.Add(account1);
        accountList.Add(account2);
        accountList.Add(account3);
        foreach(AccountInfo account in accountList)
        {
            if(account.AccountNumber==12347)
            {
                Console.WriteLine("------------------before update-------------------");
                account.ShowAccountInfo();
                account.Update("Damon","Salvatore","98309480","damon@gmail.com",Gender.Male,"Guindy","HDFC102");
                System.Console.WriteLine("-------------------------after update-----------------");
                account.ShowAccountInfo();
                account.Deposit(3400);
                account.Withdraw(300);
                account.Wallet();
            }
        }
    }
}