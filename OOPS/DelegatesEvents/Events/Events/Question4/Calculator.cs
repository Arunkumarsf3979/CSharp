namespace Question8
{
    public delegate int Operation(int value1,int value2);
    public static class Calculator
    {
        public static void MainMenu()
        {
            int choice;
            do{
                System.Console.WriteLine("1.Addition");
                System.Console.WriteLine("2.Subtraction");
                System.Console.WriteLine("3.Multiplication");
                System.Console.WriteLine("4.division");
                System.Console.WriteLine("5.Exit");
                System.Console.WriteLine("Enter your choice  :");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Addition(5,6);
                        break;
                    }
                    case 2:
                    {
                        Subtraction(9,8);
                        break;
                    }
                    case 3:
                    {
                        Multiplication(7,8);
                        break;
                    }
                    case 4:
                    {
                        Division(90,9);
                        break;
                    }
                    case 5:
                    {
                        break;
                    }
                }
            }while(choice!=5);
        }
        
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
    }
}