using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        float[]sem1={95,98,93,92,91,99};
        float[]sem2={95,99,96,92,91,99};
        float[]sem3={96,98,93,92,91,99};
        float[]sem4={95,99,93,92,91,99};
        MarkSheet user=new MarkSheet("9890842","Arun","Ragu","Anandhi","Chennai","98938920","arun@mail.com",Gender.Male,"988098942",sem1,sem2,sem3,sem4,98);
        user.CalculateUG();
    }
}
