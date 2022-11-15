using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the lowerlimit: ");
        int lower=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the upperlimit: ");
        int upper=Convert.ToInt32(Console.ReadLine());
        int size;
        double armstrong=0;
        int temp;
        Console.Write($"Armstrong numbers present between {lower} and {upper} are ");
        for(int i=lower;i<=upper;i++)
        {
            size=Convert.ToString(i).Length;
            temp=i;
            armstrong=0;
            while(temp>0)
            {
                armstrong=armstrong+Math.Pow(temp%10,size);
                temp=temp/10;
                // Console.WriteLine(armstrong);
            }
            if(armstrong==i)
            {
                Console.Write(armstrong+" ");
            }
            
        }
    }
}