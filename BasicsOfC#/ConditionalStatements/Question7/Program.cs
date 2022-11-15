using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter your ID :");
        int id=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter your name :");
        string name=Console.ReadLine();
        Console.Write("enter your unit :");
        int unit=Convert.ToInt32(Console.ReadLine());
        double amountCharges;
        double amount;
        double taxAmount=0;
        if(unit<=199)
        {
            amountCharges=1.20;
            amount=unit*amountCharges;
        }
        else if(unit>199 && unit<400)
        {
            amountCharges=1.50;
            amount=unit*amountCharges;
        }
        else if(unit>399 && unit<600)
        {
            amountCharges=1.80;
            amount=unit*amountCharges;
        }
        else
        {
            amountCharges=2;
            amount=unit*amountCharges;
        }
        
        
        if(amount<100)
        {
            amount=100;
            // taxAmount=0;
        }
        if(amount>400)
        {
            taxAmount=amount*0.15;
        }


        Console.WriteLine($"Customer IDNO: {id}");
        Console.WriteLine($"Customer Name: {name}");
        Console.WriteLine($"Unit consumer: {unit}");
        Console.WriteLine($"AmountCharges@ {amountCharges} per unit: {amount}");
        Console.WriteLine($"SurchageAmount: {taxAmount} ");
        Console.WriteLine($"Net Amount Paid By the Customer: {amount+taxAmount}");

    }
}