using System;
namespace Exception2;
class Program{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter the number: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number: ");
            int num2=Convert.ToInt32(Console.ReadLine());
            int result=num1/num2;
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Message);
        }
    }
}
