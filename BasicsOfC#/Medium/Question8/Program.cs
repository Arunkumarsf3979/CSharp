using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter a string: ");
        string myStr=Console.ReadLine();
        string myStr2="";
        foreach(char i in myStr)
        {
            if(i>=48 && i<=57)
            {
                myStr2=myStr2+i;
            }
        }
        if(myStr2.Equals(""))
        {
            Console.WriteLine("There is no number entered in the string");
        }
        else if(Convert.ToInt32(myStr2)%2==0)
        {
            Console.WriteLine($"{myStr2} is an Even number");
        }
        else{
            Console.WriteLine($"{myStr2} is an odd number");
        }
    }
}