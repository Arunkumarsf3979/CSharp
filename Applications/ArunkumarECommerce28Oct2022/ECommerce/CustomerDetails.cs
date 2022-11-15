using System;
namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_CustomerID=1000;
        public string Name { get; set; }
        public string City { get; set; }
        public string MobileNumber { get; set; }
        public int WalletBalance { get; set; }
        public string EmailID { get; set; }
        public string CustomerID{get;set;}

        public CustomerDetails(string name,string city,string mobile,int balance,string emailID)
        {
            s_CustomerID++;
            CustomerID="CID"+s_CustomerID;
            Name=name;
            City=city;
            MobileNumber=mobile;
            WalletBalance=balance;
            EmailID=emailID;
        }
        public int WalletBalanceRecharge(int amount)
        {
            WalletBalance=WalletBalance+amount;
            return WalletBalance;
        }
        public void RemainingBalance(int amount)
        {
            WalletBalance=WalletBalance-amount;
        }
    }
}