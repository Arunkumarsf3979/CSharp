namespace Question3
{
//     Class RecurringDeposit: Inherit PersonalInfo, Calculate
// Properties: AccountNumber, AccountType->Savings, Balance
// Methods: Deposit, Withdraw, Balance check

    public class RecurringDeposit:PersonalInfo,ICalculate
    {
        private static int s_accountNumber=10000;
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public int  Balance { get; set; }
        public void Deposit(int amount){
            Balance=Balance+amount;
        }
         public void Withdraw(int amount){
            Balance=Balance+amount;
         }
         public int BalanceCheck()
         {
            return Balance;
         }
    }
}