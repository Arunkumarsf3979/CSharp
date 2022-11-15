using System;
namespace SwitchStatement;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter first number: ");
        float num1=Convert.ToSingle(Console.ReadLine());
        Console.Write("enter second number: ");
        float num2=Convert.ToSingle(Console.ReadLine());
         Console.Write("select Operation + - * / %: ");
        char choice=Console.ReadLine()[0];

        switch(choice){
            case '+':
            {
                Console.WriteLine($"Addition = {num1+num2}");
                break;
            }
            case '-':
            {
                Console.WriteLine($"subtraction = {num1-num2}");
                break;
            }
            case '*':
            {
                Console.WriteLine($"Multiplication = {num1*num2}");
                break;
            }
            case '/':
            {
                Console.WriteLine($"Division = {num1/num2}");
                break;
            }
            case '%':
            {
                Console.WriteLine($"Modulo division = {num1%num2}");
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
