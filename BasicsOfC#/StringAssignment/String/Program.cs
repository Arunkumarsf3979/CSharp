using System;
namespace Program;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string :");
        string myStr=Console.ReadLine();
        Console.Write("Enter the substring :");
        string subStr=Console.ReadLine();
        int count=0;
        for(int i=0;i<myStr.Length-subStr.Length+1;i++)
        {
            if(myStr.Substring(i,subStr.Length).Equals(subStr))
            {
                count++;
            }
            // Console.WriteLine(myStr.Substring(i,subStr.Length));
        }
        Console.Write("the frequency is :"+count);
        
    }
}
