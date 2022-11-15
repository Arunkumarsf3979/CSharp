using System;
namespace Question1
{
    public class FunctionDelegate
    {
        public static string Show()
        {
            return "Welcome to syncfusion";
        }
        public static string Message()
        {
            return "This is a product based company";
        }
        public static string Display2(Func<string> operation)
        {
            return operation();
        }
    }
}