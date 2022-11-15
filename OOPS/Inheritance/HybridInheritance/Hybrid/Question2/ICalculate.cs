namespace Question2
{
//     Interface Calculate:
// Methods: Deposit, Withdraw, Balance check

    public interface ICalculate
    {
        public void Deposit(int amount);
        public void Withdraw(int amount);
        public int BalanceCheck();
    }
}