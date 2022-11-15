using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Input: ");
        String myStr=Console.ReadLine();
        int sum=0;
        for(int i=0;i<myStr.Length;i++)
        {
            if((int)myStr[i]>=48 && (int)myStr[i]<=57)
            {
                sum=sum+(int)myStr[i]-48;
            }
        }
        Console.WriteLine($"The sum of numbers in the string is : {sum}");
    }
}