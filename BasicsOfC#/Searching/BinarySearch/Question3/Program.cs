using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        char []arr=new char[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a character :");
            arr[i]=Console.ReadLine()[0];
        }
        System.Console.Write("Enter a char to be searched ");
        char search=Console.ReadLine()[0];
        BinarySearching(arr,search);
    }
    public static void BinarySearching(char []arr,char search)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            int result=search.CompareTo(arr[mid]);
            if(result==0)
            {
                System.Console.WriteLine($"Element found at {mid}");
                return;
            }
            else if(result<0)
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
