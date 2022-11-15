using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string mystr=Console.ReadLine();
        Console.Write("enter the string to be searched: ");
        string substr=Console.ReadLine();
        bool flag=true;
        for(int i=0;i<mystr.Length-substr.Length+1;i++)
        {
            if(mystr.Substring(i,substr.Length).Equals(substr))
            {
                Console.WriteLine("The substring exists in the string");
                flag=false;
                break;
            }
        }
        if(flag)
        {
            Console.Write("The given substring does not exists in the string");
        }
    }
}