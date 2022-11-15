using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the String: ");
        String myStr=Console.ReadLine();
        Console.Write("Total number of words in the string is :");
        int count=0;
        for(int i=0;i<myStr.Length;i++)
        {
            if(myStr[i]==' ')
            {
                count++;
            }
        }
        Console.WriteLine(count+1);
    }
}