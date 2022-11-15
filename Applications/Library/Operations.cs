using System;
using System.Collections.Generic;
namespace Library
{
    public class Operations
    {
        private static List<UserDetails> userList=new List<UserDetails>();
        private static List<BookDetails> bookList=new List<BookDetails>();
        private static List<BorrowDetails> borrowList=new List<BorrowDetails>();
        private static UserDetails user;
        public static void DefaultUserDetails()
        {
            UserDetails user1=new UserDetails("Ravichandran",Gender.Male,Department.EEE,"9938388333","ravi@gmail.com");
            UserDetails user2=new UserDetails("PriyaDharshini",Gender.Female,Department.CSE,"9944444455","priya@gmail.com");
            userList.Add(user1);
            userList.Add(user2);
        }
        public static void DefaultBookDetails()
        {
            BookDetails book1=new BookDetails("C#","Author1",3);
            BookDetails book2=new BookDetails("HTML","Author2",5);
            BookDetails book3=new BookDetails("CSS","Author1",3);
            BookDetails book4=new BookDetails("JS","Author1",3);
            BookDetails book5=new BookDetails("TS","Author2",2);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
        }
        public static void DefaultBorrowDetails()
        {
            BorrowDetails borrow1=new BorrowDetails("BID101","SF3001",DateTime.Parse("04/10/2022"),Status.Borrowed);
            BorrowDetails borrow2=new BorrowDetails("BID103","SF3001",DateTime.Parse("04/12/2022"),Status.Borrowed);
            BorrowDetails borrow3=new BorrowDetails("BID104","SF3001",DateTime.Parse("04/15/2022"),Status.Returned);
            BorrowDetails borrow4=new BorrowDetails("BID102","SF3002",DateTime.Parse("04/11/2022"),Status.Borrowed);
            BorrowDetails borrow5=new BorrowDetails("BID105","SF3002",DateTime.Parse("04/15/2022"),Status.Returned);
            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);
        }
        public static void MainMenu()
        {   
            int choice;
            do{
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Main Menu");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.User Login");
            Console.WriteLine("3.Exit");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.Write("Enter your choice  :");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("Welcome to registration");
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    LoginMenu();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exited from the application");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option please enter again");
                    break;
                }
            }
            }while(choice!=3);
        }
        private static void UserRegistration()
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("                            Registration");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.Write("Enter your username                                :");
            string name=Console.ReadLine();
            Console.Write("Enter your gender(male,female,transgender)         :");
            Gender gender=Gender.Default;
            bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp)
            {
                Console.WriteLine("Invalid option                                 :");
                Console.Write("Enter your gender(male,female,transgender)     :");
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            Console.Write("Enter your department(ECE,EEE,CSE)                 :");
            Department department;
            temp=Enum.TryParse<Department>(Console.ReadLine(),true,out department);
            while(!temp)
            {
                Console.WriteLine("Invalid option                                 :");
                Console.Write("Enter your department(ECE,EEE,CSE)             :");
                temp=Enum.TryParse<Department>(Console.ReadLine(),true,out department);
            }
            Console.Write("Enter your MobileNumber                            :");
            string mobile=Console.ReadLine();
            Console.Write("Enter your MailID                                  :");
            string mailId=Console.ReadLine();
            UserDetails users=new UserDetails(name,gender,department,mobile,mailId);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"Your RegistrationId {users.RegistrationID} is generated");
            Console.WriteLine("----------------------------------------------------------------------------------");
            userList.Add(users);
        }
        private static void LoginMenu()
        {
            string userIdentity;
            Console.Write("Enter your UserId :");
            userIdentity=Console.ReadLine();
            foreach(UserDetails currentUser in userList)
            {
                
                if(userIdentity==currentUser.RegistrationID)
                {
                    user=currentUser;
                    int choice;
                    do{
                    SubMenu();
                    choice=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    switch(choice)
                    {
                        case 1:
                        {
                            BorrowBook();
                            break;
                        }
                        case 2:
                        {
                            ShowBorrowedHistory();
                            break;
                        }
                        case 3:
                        {
                            ReturnBooks();
                            break;
                        }
                        case 4:
                        {
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid option enter again");
                            break;
                        }
                    }
                    }while(choice!=4);
                }
            }
        }
        private static void SubMenu()
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Login Menu");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("1.Borrow book");
            Console.WriteLine("2.Show Borrowed history");
            Console.WriteLine("3.Return Books");
            Console.WriteLine("4.Exit");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.Write("Enter your choice :");
            
        }
        private static void BorrowBook()
        {
            int borrowedCount=0;
            Console.WriteLine("|-------------------------------------------------|");
            Console.WriteLine("| BookID | Book Name | Author Name | No. Of Books |");
            Console.WriteLine("|-------------------------------------------------|");
            foreach(BookDetails book in bookList)
            {
                Console.WriteLine("|{0,-8}|{1,-11}|{2,-13}|{3,-14}|",book.BookID,book.BookName,book.AuthorName,book.BookCount);
                Console.WriteLine("|-------------------------------------------------|");
            }
            Console.Write("Enter the bookId to borrow :");
            string bookIdentity=Console.ReadLine();
            
            foreach(BookDetails book in bookList)
            {
                if(bookIdentity==book.BookID)
                {
                    if(book.BookCount>0)
                    {
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if((user.RegistrationID==borrow.RegistrationID)&&(borrow.RegistrationID=="Borrowed"))
                            {
                                borrowedCount++;
                            }
                        }
                        if(borrowedCount>=3)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("You have borrowed more than three books so you cannot borrow the book now");
                            Console.WriteLine("----------------------------------------------------------------------------------");
                        }
                        else{
                            BorrowDetails borrowedBook=new BorrowDetails(book.BookID,user.RegistrationID,DateTime.Today,Status.Borrowed);
                            borrowList.Add(borrowedBook);
                            book.BookCount=book.BookCount-1;
                        }
                    }
                    else
                    {
                        DateTime date=new DateTime();
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.WriteLine("Books are not available for the selected count");
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if(bookIdentity==borrow.BookID)
                            {
                                date=borrow.BorrowDate;
                                if(date>borrow.BorrowDate)
                                {
                                    date=borrow.BorrowDate;
                                }
                            }
                        }
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.WriteLine("The book will be available on "+date.AddDays(15).ToShortDateString());
                        Console.WriteLine("----------------------------------------------------------------------------------");
                    }
                }
            }
        }
        private static void ShowBorrowedHistory()
        {
            Console.WriteLine("|---------------------------------------------------------------------|");
            Console.WriteLine("| BorrowID | BookID | RegistrationID | Borrowed Date |     Status     |");
            Console.WriteLine("|---------------------------------------------------------------------|");
            foreach(BorrowDetails borrow in borrowList)
            {
                if(borrow.RegistrationID==user.RegistrationID)
                {
                    Console.WriteLine("|{0,-10}|{1,-8}|{2,-16}|{3,-15}|{4,-16}|",borrow.BorrowID,borrow.BookID,borrow.RegistrationID,borrow.BorrowDate.ToShortDateString(),borrow.Status);
                    Console.WriteLine("|---------------------------------------------------------------------|");
                }
            }
        }
        private static void ReturnBooks()
        {
            Console.WriteLine("|------------------------------------------------------------------------------------|");
            Console.WriteLine("| BorrowID | BookID | RegistrationID | Borrowed Date |     Status     |   Due Date   |");
            Console.WriteLine("|------------------------------------------------------------------------------------|");
            foreach(BorrowDetails borrow in borrowList)
            {
                if((borrow.RegistrationID==user.RegistrationID)&&(borrow.Status==Status.Borrowed))
                {
                    Console.WriteLine("|{0,-10}|{1,-8}|{2,-16}|{3,-15}|{4,-16}|{5,-14}|",borrow.BorrowID,borrow.BookID,borrow.RegistrationID,borrow.BorrowDate.ToShortDateString(),borrow.Status,borrow.BorrowDate.AddDays(15).ToShortDateString());
                    Console.WriteLine("|------------------------------------------------------------------------------------|");
                }
            }
            Console.Write("Enter the borrowedId to return book :");
            string returnBookBorrowId=Console.ReadLine();
            TimeSpan newTime;
            foreach(BorrowDetails borrow in borrowList)
            {
                if(borrow.BorrowID==returnBookBorrowId)
                {
                    if(borrow.BorrowDate.AddDays(15)<DateTime.Today)
                    {
                        newTime=DateTime.Today.Subtract(borrow.BorrowDate.AddDays(15));
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.WriteLine("The amount to be paid for fine is "+newTime.TotalDays);
                        Console.Write("Are you going to pay the fine now(yes or no):");
                        if(Console.ReadLine().ToLower()=="yes")
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("The book returned successfully");
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            foreach(BookDetails book in bookList)
                            {
                                if(book.BookID==borrow.BookID)
                                {
                                    book.BookCount++;
                                }
                            }
                            borrow.Status=Status.Returned;
                        }
                    }
                    else{
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.Write("Are you going to return the book now:");
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        if(Console.ReadLine().ToLower()=="yes")
                        {
                            borrow.Status=Status.Returned;
                        }
                    }
                }
            }
        }
    }
}
