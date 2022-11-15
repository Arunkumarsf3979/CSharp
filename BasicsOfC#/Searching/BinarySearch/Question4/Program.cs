using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        float []arr=new float[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToSingle(Console.ReadLine());
        }
        System.Console.Write("Enter a number to be searched ");
        float search=Convert.ToSingle(Console.ReadLine());
        BinarySearching(arr,search);
    }
    public static void BinarySearching(float []arr,float search)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            if(arr[mid]==search)
            {
                System.Console.WriteLine($"Element found at {mid}");
                return;
            }
            else if(arr[mid]>search)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        System.Console.WriteLine("Not found");
    }
}