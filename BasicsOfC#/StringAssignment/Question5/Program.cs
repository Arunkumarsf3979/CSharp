using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the  first String: ");
        String myStr1=Console.ReadLine();
        Console.Write("Enter the  second String: ");
        String myStr2=Console.ReadLine();
        if(myStr1.Equals(myStr2) )
        {
            if(myStr1.Length==myStr2.Length){
                Console.Write("The length of both the strings are equal and also both strings are equal.");
            }
        }
        else
        {
            if(myStr1.Length==myStr2.Length){
                Console.Write("The length of both the strings are equal but strings are not equal.");
            }
            else{
                Console.Write("The length of both the strings are not equal and also both strings are not equal.");
            }
        }
    }
}