using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input a string: ");
        String myStr=Console.ReadLine();
        int start=0;
        int end=myStr.Length-1;
        Palindrome(myStr,start,end);
    }
    public static void Palindrome(String myStr,int start,int end)
    {
        if(start==myStr.Length)
        {
            Console.WriteLine("The string is palindrome.");
        }
        else if(myStr[start]==myStr[end])
        {
            start++;
            end--;
            Palindrome(myStr,start,end);
        }
        else{
            Console.WriteLine("The string is not palindrome.");
        }
    }
}