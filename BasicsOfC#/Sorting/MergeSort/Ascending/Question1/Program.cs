using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        // MergeArray(arr,0,(0+arr.Length-1)/2,arr.Length-1);
        MergeSort(arr,0,arr.Length-1);
        foreach(int item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
    public static void MergeArray(int[] array, int left, int middle, int right)
    {
        int leftArrayLength = middle - left + 1;
        int rightArrayLength = right - middle;
        int[] leftTempArray = new int[leftArrayLength];
        int[] rightTempArray = new int[rightArrayLength];
        int i, j;

        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = array[left + i];
        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = array[middle + 1 + j];

        i = 0;
        j = 0;
        int k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftTempArray[i] <= rightTempArray[j])
            {
            array[k++] = leftTempArray[i++];
            }
            else
            {
            array[k++] = rightTempArray[j++];
            }
        }

        while (i < leftArrayLength)
        {
            array[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength)
        {
            array[k++] = rightTempArray[j++];
        }
    }
    static public void MergeSort(int[] arr, int start, int end) {
        if (start < end) {
        int q = (start + end) / 2;
        MergeSort(arr, start, q);
        MergeSort(arr, q + 1, end);
        MergeArray(arr, start, q, end);
        }
      }
}
