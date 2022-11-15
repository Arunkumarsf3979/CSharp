using System;
using System.Collections.Generic;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        List<BookInfo>bookList=new List<BookInfo>();
        BookInfo book1=new BookInfo("mechanical","B.E","BID101","Emech","arun",789,3,4);
        BookInfo book2=new BookInfo("mechanical","B.E","BID102","Emech","ajith",709,5,6);
        BookInfo book3=new BookInfo("mechanical","B.E","BID102","Emech","stefan",373,6,5);
        bookList.Add(book1);
        bookList.Add(book2);
        bookList.Add(book3);
        foreach(BookInfo books in bookList)
        {
            books.DisplayInfo();
        }
    }
}