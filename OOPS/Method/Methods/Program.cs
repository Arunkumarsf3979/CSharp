using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Options for Arithmetic operations: ");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");

        int choice;int num1;int num2;
        bool temp;
        string value="";
        do{
            Console.Write("Enter the choice: ");
            temp=int.TryParse(Console.ReadLine(),out choice);

            Console.Write("Please enter the first number :");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number :");
            num2=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("Addition :"+Addition(num1,num2));
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Subtraction :"+Subtraction(num1,num2));
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Multiplication :"+Multiplication(num1,num2));
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Division :"+Division(num1,num2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid choice please enter the valid option: ");
                    break;
                }
            }
            Console.Write("Do you want to continue say yes or no:");
            value=Console.ReadLine().ToLower();
            while(value!="yes" && value!="no" )
            {
                Console.WriteLine("Invalid choice please enter the valid option: ");
                Console.Write("Do you want to continue say yes or no:");
                value=Console.ReadLine().ToLower();
            }
        }while(value=="yes");

        // Addition
        int Addition(int num1,int num2)
        {
            return num1+num2;
        }

        // Subtraction
        int Subtraction(int num1,int num2)
        {
            return num1-num2;
        }
        int Multiplication(int num1,int num2)
        {
            return num1*num2;
        }
        int Division(int num1,int num2)
        {
            return num1/num2;
        }
        
    }
}
