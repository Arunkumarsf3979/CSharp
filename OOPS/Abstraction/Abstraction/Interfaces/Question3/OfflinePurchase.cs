using System;
namespace Question3
{
//     Class OfflineTransaction inherit Transaction
// Property:  TransactionID, Purchase [], DateOfPurchase
// Method: CalculateTotalAmount

    public class OfflineTransaction:ITransaction
    {
        private static int s_transactionID=1000;
        public string TransactionID {get;set;}
        public int[] Purchase{get;set;}
        public DateTime DateOfPurchase{get;set;}
        public int TotalAmount { get; set; }
        public OfflineTransaction(int[] purchase,DateTime date)
        {
            s_transactionID++;
            TransactionID="TID"+s_transactionID;
            Purchase=purchase;
            DateOfPurchase=date;
        }
         public void CalculateAmount()
         {
            int total=0;
            foreach(int amount in Purchase)
            {
                total=total+amount;
            }
            TotalAmount=total;
         }
         public void DisplayBill()
         {
            System.Console.WriteLine("Your total amount   :"+TotalAmount);
         }
    }
}