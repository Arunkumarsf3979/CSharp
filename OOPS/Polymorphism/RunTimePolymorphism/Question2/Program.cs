using System;
namespace Question2;
class Program{
//     •	Declare object for bank class
// •	Assign SBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
// •	Assign ICICI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
// •	Assign HDFC class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
// •	Assign IDBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo

    public static void Main(string[] args)
    {
        SBI sbi=new SBI();
        Bank bank=new Bank();
        HDFC hDFC=new HDFC();
        bank=sbi;
    }
}