using System;
using System.Collections.Generic;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Input: ");
        String myStr=Console.ReadLine();
        Console.Write("The output of string using Hashset are ");
        UsingHashset(myStr);
        Console.Write("The output of string using naive approach are ");
        char []str=new char[256];
        foreach(char i in myStr)
        {
            if(str[i]==0)
            {
                str[i]++;
            }
        }
        foreach(char i in myStr)
        {
            if(str[i]==1)
            {
                Console.Write(i);
                str[i]--;
            }
        }
    }
    public static void UsingHashset(string myStr)
    {
        HashSet <char> s=new HashSet<char>(myStr.Length);
        foreach(char i in myStr)
        {
            s.Add(i);
        }
        foreach(char i in s)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}