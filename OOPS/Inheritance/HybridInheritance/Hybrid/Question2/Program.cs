using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        SavingAccount customer=new SavingAccount(){Name="Arun",Gender="Male",DOB=new DateTime(2001,04,04),phone="8384390043",VoterID="980394",AadharID="98989043",PanNumber="899834309",BankName="HDFC",IFSC="98989"};
        customer.Deposit(400);
        Console.WriteLine("Your balance is "+customer.BalanceCheck());
        customer.Withdraw(230);
        Console.WriteLine("Your balance is "+customer.BalanceCheck());

    }
}