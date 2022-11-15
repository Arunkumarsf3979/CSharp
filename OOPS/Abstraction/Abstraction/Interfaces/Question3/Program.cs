using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int[]purchase={56,78,98,102};
        OnlineTransaction online=new OnlineTransaction(purchase,DateTime.Today);
        online.CalculateAmount();
        online.DisplayBill();

        int[]purchase2={56,78,98,102,89,70};
        OnlineTransaction offline=new OnlineTransaction(purchase2,DateTime.Today);
        offline.CalculateAmount();
        offline.DisplayBill();
    }
}