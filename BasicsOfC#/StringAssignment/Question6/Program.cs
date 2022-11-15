using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the  first String: ");
        String myStr1=Console.ReadLine();
        int alphabets=0;
        int digits=0;
        int specialChar=0;
        for(int i=0;i<myStr1.Length;i++)
        {
            if((int)myStr1[i]>=48 && (int)myStr1[i]<=57)
            {
                digits++;
            }
            else if(((int)myStr1[i]>=65 && (int)myStr1[i]<=90)||((int)myStr1[i]>=97 && (int)myStr1[i]<=122))
            {
                alphabets++;
            }
            else{
                specialChar++;
            }
        }
        Console.WriteLine($"Number of Alphabets in the string is : {alphabets}");
        Console.WriteLine($"Number of Digits in the string is : {digits}");
        Console.WriteLine($"Number of Special characters in the string is : {specialChar}");
     
    }
}