namespace Question2
{
//     Abstract class library
// Field : serial number -LIB1000
// Property : serial number
// Abstract properties:, author name, book name, publisher name, year
// Abstract methods: set book info, display info

    public abstract class Library
    {
        private static int _serialNumber=1000;
        public string SerialNumber{get {_serialNumber++;return "LIB"+_serialNumber;}}
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract DateTime Year { get; set; }

        public abstract void SetBookInfo(string AuthorName,string BookName,string PublisherName,DateTime Year);
        public abstract void DisplayInfo();
    }
}