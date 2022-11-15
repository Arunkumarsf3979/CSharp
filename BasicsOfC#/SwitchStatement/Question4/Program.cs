using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter first number: ");
        float num1=Convert.ToSingle(Console.ReadLine());
        Console.Write("enter second number: ");
        float num2=Convert.ToSingle(Console.ReadLine());
         Console.Write("select Operation 1(+) 2(-) 3(*) 4(/): ");
        int choice=Convert.ToInt32(Console.ReadLine());

        switch(choice){
            case 1:
            {
                Console.WriteLine($"Addition = {num1+num2}");
                break;
            }
            case 2:
            {
                Console.WriteLine($"subtraction = {num1-num2}");
                break;
            }
            case 3:
            {
                Console.WriteLine($"Multiplication = {num1*num2}");
                break;
            }
            case 4:
            {
                Console.WriteLine($"Division = {num1/num2}");
                break;
            }
            case 5:
            {
                Console.WriteLine("Exit");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}

