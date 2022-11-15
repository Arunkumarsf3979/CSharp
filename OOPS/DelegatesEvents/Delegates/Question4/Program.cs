using System;

namespace Question4
{
    class Program{
        static int Average(int mark1,int mark2,int mark3,int mark4)
        {
            return (mark1+mark2+mark3+mark4)/4;
        }
        static int FunctionDelegate(Func<int,int,int,int,int> operation,int mark1,int mark2,int mark3,int mark4)
        {
            return operation(mark1,mark2,mark3,mark4);
        }
        public static void Main(string[] args)
        {
            Console.Write(FunctionDelegate(Average,100,100,23,54));
            // FunctionDelegate(Average,100,100,23,54);
        }
    }
}
