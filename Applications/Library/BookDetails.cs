namespace Library
{
    public class BookDetails
    {
        private static int s_BookID=100;
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }
        public string BookID{get;}

        public BookDetails(string bookName,string authorName,int bookCount)
        {
            s_BookID++;
            BookID="BID"+s_BookID;
            BookName=bookName;
            AuthorName=authorName;
            BookCount=bookCount;
        }
    }
}