using System;
namespace OnlineGroceryStore
{
// Customer registration class: Inherits Personal Details,IBalance
// Properties: CustomerID, WalletBalance
// Methods: ShowCustomerDetails, WalletRecharge

    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerID=3000;
        public string CustomerID { get; set; }
        public float WalletBalance { get; set; }
        public CustomerRegistration(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID):base(name,fatherName,gender,mobile,dob,mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
        }
        public CustomerRegistration(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID,float walletBalance):base(name,fatherName,gender,mobile,dob,mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
            WalletBalance=walletBalance;
        }
        public void WalletRecharge(float amount)
        {
            WalletBalance+=amount;
        }
    }
}