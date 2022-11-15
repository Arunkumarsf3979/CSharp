using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the grade E V G A F: ");
        Char grade=Console.ReadLine()[0];
        switch(grade)
        {
            case 'V':
            {
                Console.WriteLine("Very Good");
                break;
            }
            case 'E':
            {
                Console.WriteLine("Excellent");
                break;
            }
            case 'G':
            {
                Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                Console.WriteLine("Fail");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}