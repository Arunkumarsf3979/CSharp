using System;
namespace BankAccount
{
    public enum transactionType{Default, Deposit, Withdraw, Transfer};
    public class TransactionDetails
    {
        private static int s_transactionID=5000;
        public string TransactionID{get;}
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public accountType AccountType{ get; set; }
        public transactionType TransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public TransactionDetails(string fromAccount,string toAccount,accountType accountType,transactionType transaction,double amount,DateTime transactionDate)
        {
            s_transactionID++;
            TransactionID="TID"+s_transactionID;
            FromAccount=fromAccount;
            ToAccount=toAccount;
            AccountType=accountType;
            TransactionType=transaction;
            Amount=amount;
            TransactionDate=transactionDate;


        }
    }
}