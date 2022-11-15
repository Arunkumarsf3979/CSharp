using System;
namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
// Properties: AccountNumber, Branchname, IFSCCode, Balance
// Methods: Update, ShowAccountInfo, deposit,withdraw, ShowBalance.
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }
        public AccountInfo(string name,string fatherName,string phone,string mail,Gender gender,int accountNumber,string branchName,string iFSCCode,double balance):base(name,fatherName,phone,mail,gender)
        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Balance=balance;
            
        }
        public void Update(string name,string fatherName,string phone,string mail,Gender gender,string branchName,string iFSCCode)
        {
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;

        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Number       :"+AccountNumber);
            Console.WriteLine("Branch Name          :"+BranchName);
            Console.WriteLine("IFSC Code            :"+IFSCCode);
            Console.WriteLine("Balance              :"+Balance);
            ShowPersonalInfo();
        }
        public void Deposit(double amount)
        {
            Balance=Balance+amount;
        }
        public void Withdraw(double amount)
        {
            Balance=Balance-amount;
        }
        public void Wallet()
        {
            Console.WriteLine("Your balance in the wallet is "+Balance);
        }
    }
}