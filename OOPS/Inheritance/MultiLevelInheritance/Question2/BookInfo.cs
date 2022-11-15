using System;
namespace Question2
{
    public class BookInfo:RackInfo
    {
        // Class BookInfo: Inherit DepartmentDetails
// Properties: BookID, BookName, AuthorName, Price
// Method: Display info
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public BookInfo(string departmentName,string degree,string bookID,string bookName,string authorName,double price,int rackNumber,int columnNumber):base(departmentName,degree,rackNumber,columnNumber)
        {
            BookID=bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("BookID  :"+BookID);
            System.Console.WriteLine("BookName :"+BookName);
            System.Console.WriteLine("AuthorName :"+AuthorName);
            System.Console.WriteLine("Price  :"+Price);
            System.Console.WriteLine("Department :"+DepartmentName);
            System.Console.WriteLine("RackNumber  :"+RackNumber);
            
        }

    }
}