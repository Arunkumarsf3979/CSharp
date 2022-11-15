using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo(){BookName="java",AuthorName="Arun",Price=300,DepartmentName="cse",Degree="B.Tech"};
        book.ShowBookInfo();
    }
}
