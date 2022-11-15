namespace Question4
{
    
// Class BookInfo: Inherit DepartmentDetails
// Properties: BookID, BookName, AuthorName, Price

    public class BookInfo:DepartmentDetails
    {
        private static int s_bookID=2000;
        public string BookID { get{s_bookID++;return "BID"+s_bookID;} }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        
        public void ShowBookInfo()
        {
            System.Console.WriteLine("Book Name    :"+BookName);
            System.Console.WriteLine("Author Name  :"+AuthorName);
            System.Console.WriteLine("BookID       :"+BookID);
            System.Console.WriteLine("Price        :"+Price);
            System.Console.WriteLine("Department   :"+DepartmentName);
        }
        
        
        
    }
}