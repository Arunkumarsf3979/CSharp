using System;
namespace WhileStatement;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<25)
        {
            Console.WriteLine(i);
            i=i+2;
        }
        int num;
        Console.WriteLine("enter the number :");
        bool value=int.TryParse(Console.ReadLine(),out num);
        while(!value){
            Console.WriteLine("Invalid input format. Please enter the number in number format:");
            value=int.TryParse(Console.ReadLine(),out num);
        }
        Console.WriteLine($"The given number is valid and the number is {num}");
    }
}
