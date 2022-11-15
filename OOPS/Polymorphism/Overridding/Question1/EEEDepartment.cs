namespace Question1
{
    // Class EEEdepartment  inherit library
// Overridden methods set bookinfo, display info

    public class EEEDepartment:Library
    {
        public override string AuthorName {get;set;}
        public override string BookName {get;set;}
        public override string PublisherName{get;set;}
        public override DateTime Year{get;set;}
        public EEEDepartment(string AuthorName,string BookName,string PublisherName,DateTime Year)
        {
            this.AuthorName=AuthorName;
            this.PublisherName=PublisherName;
            this.Year=Year;
            this.BookName=BookName;
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("AuthorName        :"+AuthorName);
            System.Console.WriteLine("BookName          :"+BookName);
            System.Console.WriteLine("PublisherName     :"+PublisherName);
            System.Console.WriteLine("Year              :"+Year);
            System.Console.WriteLine("SeraialNumber     :"+SerialNumber);
        }
        public override void SetBookInfo(string AuthorName,string BookName,string PublisherName,DateTime Year)
        {
            this.AuthorName=AuthorName;
            this.PublisherName=PublisherName;
            this.Year=Year;
            this.BookName=BookName;
        }
    }

}