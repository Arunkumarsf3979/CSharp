using System;
namespace Question3
{
//     Interface Transaction
// Property :  TotalAmount
// Method: CalculateAmount, DisplayBill

    public interface ITransaction
    {
         public int TotalAmount { get; set; }
         public void CalculateAmount();
         public void DisplayBill();
         
         
    }
}