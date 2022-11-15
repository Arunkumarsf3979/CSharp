using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string myStr=Console.ReadLine();
        int []str=new int[256];
        foreach(char i in myStr)
        {
            str[i]++;
        }
        foreach(char i in myStr)
        {
            if(str[i]>=1)
            {
                Console.Write(i);
                str[i]=0;
            }
        }
    }
}
