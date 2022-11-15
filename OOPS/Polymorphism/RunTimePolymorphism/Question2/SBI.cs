using System;
namespace Question2
{
    // a.	Create a class SBI and override GetIntresetInfo method and return 7.5%.
    public class SBI:Bank
    {
        public override double GetIntresetInfo()
        {
            return 7.5;
        }
    }
}