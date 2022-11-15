using System;
namespace BankAccount
{
    public enum gender{Default,Male,Female,Transgender}
    public enum accountType{Default, SB, CA, RD, FD}
    public class CustomerDetails
    {
        private static int s_AccountNumber=10000;
        public string AccountNumber{get;set;}
        public string CustomerName{get;set;}
        public gender Gender { get; set; }
        public string MobileNumber { get; set; }
        public accountType AccountType{get; set;}
        public double Balance { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MailID { get; set; }
        public string Address { get; set; }

        public CustomerDetails(string customerName,gender gender,string mobile,accountType account,double balance,DateTime DOB,string mailId,string address)
        {
            s_AccountNumber++;
            AccountNumber=Convert.ToString(s_AccountNumber);
            CustomerName=customerName;
            Gender=gender;
            MobileNumber=mobile;
            AccountType=account;
            Balance=balance;
            DateOfBirth=DOB;
            MailID=mailId;
            Address=address;

        }
        
        
    }
}