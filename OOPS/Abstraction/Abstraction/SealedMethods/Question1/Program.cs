using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("arun",Gender.Male,new DateTime(2001,04,04),890809908,798798987,MaritalDetails.Single,"ragu","anandhi",2,"chn",DateTime.Today);
        employee.Update();
    }
}