using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        float[]sem1={90,98,98,97,96,95};
        float[]sem2={90,99,98,97,96,95};
        float[]sem3={90,98,98,94,96,95};
        float[]sem4={90,97,98,97,96,95};

        RegisterApplication student=new RegisterApplication("2018308006",3,"Physics","b.tech","Pharma",sem1,sem2,sem3,sem4,"Arun","Ragu","Anandhi","Chn","980980980","arun@mail.com",Gender.Male);
        student.ShowInfo();
    }
}