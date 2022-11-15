using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int num;
        bool value;
        do{
            Console.Write("enter the input :");
            value=int.TryParse(Console.ReadLine(),out num);
            if(value==false || (value==true && (num<0 || num>10)))
            {
                Console.WriteLine("Invalid Input please enter the valid input.");
            }
        }while(value==false || (value==true && (num<0 || num>10)));
        Console.WriteLine($"The given number is {num}");
    }
}