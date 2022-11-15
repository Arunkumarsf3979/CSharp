using System;
namespace HierarchicalInheritance
{
    public enum AccountType{Default,SB,RD}
    public class AccountDetails:StudentDetails
    {
        private static int s_accountID=1000;
        public string AccountID { get; set; }
        public AccountType AccountType { get; set; }

        public AccountDetails(string studentID,string aID,string name,string fatherName,Gender gender,DateTime dob,Department department,Year year,AccountType accountType):base(aID,name,fatherName,gender,dob,department,year)
        {
            s_accountID++;
            AccountID="AC"+s_accountID;
            AccountType=AccountType.SB;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("AccountID     :"+AccountID);
            Console.WriteLine("Accounttype   :"+AccountType);
            ShowStudent();
        }
    }
}