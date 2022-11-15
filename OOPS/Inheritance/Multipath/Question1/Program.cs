using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        PGCancelling student=new PGCancelling("Arun","Ragu",98023202,new DateTime(2001,04,04),Gender.Male,"980283892828","989898",98,98,98,"838942",9,8,7,9,DateTime.Today);
        System.Console.WriteLine("                 Before Update");
        student.ShowInfo();
        System.Console.WriteLine("                  After Update");
        student.UpdateInfo("Ajtih","Ragu",98023202,new DateTime(2001,04,04),Gender.Male,"980283892828","989898",98,98,98,"838942",9,8,7,9,DateTime.Today);
        student.ShowInfo();
    }
}