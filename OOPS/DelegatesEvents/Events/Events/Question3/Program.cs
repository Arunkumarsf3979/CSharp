using System;
namespace Question3;
public delegate bool Events(string str);
public class Program{
    public static event Events Operation;
    public static string Upper(string mystr)
    {
        return mystr.ToUpper();
    }
    public static string Lower(string mystr)
    {
        return mystr.ToLower();
    }
    public static bool Palindrome(string mystr)
    {
        int j=-1;
        for(int i=mystr.Length-1;i>=0;i--)
        {
            j++;
            if(mystr[i].Equals(mystr[j]))
            {
                continue;
            }
            else{
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        Operation = new Events(Palindrome);
        // Operation+=new Events(Upper);
        System.Console.WriteLine(Operation("malayalam"));
    }
}