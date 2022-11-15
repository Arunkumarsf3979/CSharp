using System;
namespace Question3;
public delegate int Operation(int number1,int number2);
class Program{
    public static int Addition(int number1,int number2)
        {
            return number1+number2;
        }
        public static int Subtraction(int number1,int number2)
        {
            return number1-number2;
        }
        public static int Multiplication(int number1,int number2)
        {
            return number1*number2;
        }
        public static int Division(int number1,int number2)
        {
            return number1/number2;
        }

    public static void Main(string[] args)
    {
        Operation operation=new Operation(Addition);
        System.Console.WriteLine(operation(32,32));
        operation=new Operation(Subtraction);
        System.Console.WriteLine(operation(32,32));
        operation=new Operation(Multiplication);
        System.Console.WriteLine(operation(32,32));
        operation=new Operation(Division);
        System.Console.WriteLine(operation(32,32));

        operation=new Operation(Addition);
        operation+=new Operation(Subtraction);
        operation+=new Operation(Multiplication);
        operation+=new Operation(Division);
        System.Console.WriteLine(operation(9,8));


    }
}
