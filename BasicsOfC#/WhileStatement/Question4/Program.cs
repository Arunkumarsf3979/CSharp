using System;
namespace Question4;
class Question4{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number :");
        int num;
        bool temp=int.TryParse(Console.ReadLine(),out num);
        while(temp==false)
        {
            Console.Write("Invalid input enter again :");
            temp=int.TryParse(Console.ReadLine(),out num);
        }
        if(num>0 && num<5)
        {
            Console.WriteLine("valid Input in range between 1-5 : "+num);
        }
        else
        {
            Console.WriteLine("valid Input not in range between 1-5 : "+num);
        }
    }
}