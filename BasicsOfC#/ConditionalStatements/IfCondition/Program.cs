using System;
namespace IfConditon;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter mark :");
        int mark=Convert.ToInt32(Console.ReadLine());
        if((mark>80)&&(mark<=100))
        {
            Console.WriteLine("Grade A");
        }
        else if((mark>60)&&(mark<=80)){
            Console.WriteLine("Grade B");
        }
        else if((mark>35)&&(mark<=60)){
            Console.WriteLine("Grade C");
        }
        else if((mark<=35)&&(mark>=0))
        {
            Console.WriteLine("Grade D");
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}
