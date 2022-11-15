using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int num;
        string condition="";
        do{
            Console.Write("Enter the number: ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("The given number is even ");
            }
            else
            {
                Console.WriteLine("The given number is odd ");
            }
            Console.Write("Do you want to continue yes or no :");
            condition=Console.ReadLine().ToLower();
            
            while(condition!="yes" && condition!="no")
            {
                Console.Write("Input is invalid please enter again :");
                condition=Console.ReadLine().ToLower();
            }
        }while(condition=="yes");
    }
}
