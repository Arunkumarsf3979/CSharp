using System;
namespace Question8;
class Program{
    static int a;
    public static void Main(string[] args)
    {
        
        Console.Write("Enter number of subjects: ");
        int noOfSubject=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[noOfSubject];
        for(int i=0;i<noOfSubject;i++){
        arr[i]=GetDetails();
        }
        Console.WriteLine($"Percentage : {Percentage(arr,noOfSubject)}");
    }
    public static int GetDetails()
    {
        a++;
        Console.Write($"Mark {a}:");
        int mark=Convert.ToInt32(Console.ReadLine());
        return mark;
    }
    public static int Percentage(int[]arr,int noOfSubject)
    {
        int total=0;
        for(int i=0;i<arr.Length;i++)
        {
            total=total+arr[i];
        }
        return total/noOfSubject;
    }
}