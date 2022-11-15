using System;
namespace Bank
{
    public enum gender{Default,Male,Female,Transgender}
    public class BankApplication
    {
        private static int s_CustomerID=1000;
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public gender Gender { get; set; }
        public string MailID { get; set; }
        public DateOnly DOB{get;set;}
        public double Balance { get; set; }
        public string CustomerID{get;}

        public BankApplication(string name,string phone,gender gender,string mailID,DateOnly dob)
        {
            s_CustomerID++;
            CustomerID="HDFC"+s_CustomerID;
            CustomerName=name;
            Phone=phone;
            Gender=gender;
            DOB=dob;
            Balance=0;
            MailID=mailID;
        }
        public double Deposit(double amount)
        {
            Balance=Balance+amount;
            return Balance;
        }
        public void Withdraw(double amount)
        {
            if(Balance<amount)
            {
                Console.WriteLine("Money cannot be withdraw due to low balance");
            }
            else{
                Balance=Balance-amount;
                Console.WriteLine("Remaining balance is "+Balance);
            }
        }

    }
}