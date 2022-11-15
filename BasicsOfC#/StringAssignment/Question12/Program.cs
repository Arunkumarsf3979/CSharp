using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Input: ");
        String myStr=Console.ReadLine();
        int max=(int)myStr[0]-48;
        int min=(int)myStr[0]-48;
        for(int i=1;i<myStr.Length;i++)
        {
            if((int)myStr[i]>=48 && (int)myStr[i]<=57)
            {
                if(max<=(int)myStr[i]-48)
                {
                    max=(int)myStr[i]-48;
                    Console.Write(max);
                }
                else if(min>=(int)myStr[i]-48)
                {
                    min=(int)myStr[i]-48;
                }
            }
        }
        Console.WriteLine($"Maximum and minimum number of said string are: {max} and {min}");
    }
}