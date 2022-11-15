using System;
namespace Library
{
    public enum Status{Default,Borrowed,Returned}
    public class BorrowDetails
    {
        private static int s_BorrowID=300;
        public string BookID { get; set; }
        public string RegistrationID { get; set; }
        public DateTime BorrowDate { get; set; }
        public Status Status { get; set; }
        public string BorrowID{get;}

        public BorrowDetails(string bookId,string registrationId,DateTime borrowDate,Status status)
        {
            s_BorrowID++;
            BorrowID="LB"+s_BorrowID;
            BookID=bookId;
            RegistrationID=registrationId;
            BorrowDate=borrowDate;
            Status=status;
        }
    }
}