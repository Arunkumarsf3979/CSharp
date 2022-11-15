using System;
// using System.Collections.Generic;
namespace CollegeAdmissionUpdate
{
    public static partial class Operations
    {
        public static List<StudentDetails> studentList=new List<StudentDetails>();
	    public static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();
	    public static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
        private static StudentDetails studentUser;
        public static void MainMenu()
        {
            int choice;
            do{
                Console.WriteLine("Welcome to Main Menu");
                Console.WriteLine("1.Student Registration");
                Console.WriteLine("2.Student Login");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice: ");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Welcome to Registration");
                        registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Welcome to login page");
                        login();
                        SubMenu();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exited from the application");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
                }
               
            }while(choice!=3);
        }

        private static void Registration()
        {
            Console.Write("Enter your student name                  :");
            string name=Console.ReadLine();
            Console.Write("Enter your father name                   :");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your Date of Birth                 :");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt" ,null);
            Console.Write("Enter your gender                        :");
            Gender gender=Gender.Default;
            bool flag=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!flag)
            {
                Console.Write("Invalid Enter your gender again          :");
                flag=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            Console.Write("Enter your physics mark                  :");
            float physics=Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your chemistry mark                :");
            float chemistry=Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your maths mark                    :");
            float maths=Convert.ToSingle(Console.ReadLine());
            StudentDetails student=new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
            Console.WriteLine($"Your studentID {student.StudentID} is generated");
            studentList.Add(student);
        }

        private static void LoginMenu()
        {
            Console.Write("Enter your studentId   :");
            string studentID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(StudentDetails student in studentList)
            {
                if(student.StudentID==studentID)
                {
                    flag=false;
                    Console.WriteLine("Login Successfully");
                    studentUser=student;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid studentID");
                MainMenu();
            }
        }
        private static void SubMenu()
        {
            char option;
            do{
                Console.WriteLine("a.Check Eligibility");
                Console.WriteLine("b.Show Details");
                Console.WriteLine("c.Take Admission");
                Console.WriteLine("d.Cancel Admission");
                Console.WriteLine("e.Show Admission Details");
                Console.WriteLine("f.Exit");
                Console.Write("Enter your choice    :");
                option=Console.ReadLine().ToLower()[0];
                switch (option)
                {
                    case 'a':
                    {
                        check();
                        break;
                    }
                    case 'b':
                    {
                        showDetail();
                        break;
                    }
                    case 'c':
                    {
                        takeAdmissions();
                        break;
                    }
                    case 'd':
                    {
                        cancel();
                        break;
                    }
                    case 'e':
                    {
                        ShowAdmissionDetails();
                        break;
                    }
                    case 'f':
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
                }
            }while(option!='f');

        }
        private static void CheckEligibility()
        {
            if(studentUser.CheckEligibility(75))
            {
                Console.WriteLine("Student is eligible");
            }
            else{
                Console.WriteLine("Student is ineligible");
            }
        }
        private static void ShowDetails()
        {
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| StudentID |       Student Name       |      Father Name      | DateOfBirth |    Gender    | Physics | Chemistry | Maths |");
             Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|{0,-11}|{1,-26}|{2,-23}|{3,-13}|{4,-14}|{5,-9}|{6,-11}|{7,-7}|",studentUser.StudentID,studentUser.StudentName,studentUser.FatherName,studentUser.DOB.ToString("dd/MM/yyyy"),studentUser.Gender,studentUser.Physics,studentUser.Chemistry,studentUser.Maths);
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------|");
        }
        public static void DefaultDetails()
        {
            StudentDetails student1=new StudentDetails("Ravichandran E","Ettapparajan",DateTime.Parse("11/11/1999"),Gender.Male,95,95,95);
	        StudentDetails student2=new StudentDetails("Baskaran S","Sethurajan",DateTime.Parse("11/11/1999"),Gender.Male,95,95,95);
	        studentList.Add(student1);
	        studentList.Add(student2);
            AdmissionDetails admission1=new AdmissionDetails("SF3001","DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
	        AdmissionDetails admission2=new AdmissionDetails("SF3002","DID102",new DateTime(2022,05,12),AdmissionStatus.Admitted);
	        admissionList.Add(admission1);
	        admissionList.Add(admission2);
            DepartmentDetails department1=new DepartmentDetails("EEE",29);
            DepartmentDetails department2=new DepartmentDetails("CSE",29);
            DepartmentDetails department3=new DepartmentDetails("MECH",30);
            DepartmentDetails department4=new DepartmentDetails("ECE",30);
            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);
        }
        private static void TakeAdmission()
        {
            Console.WriteLine("Admission form");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("| DepartmentID | DepartmentName | NumberOfSeats |");
            Console.WriteLine("|-----------------------------------------------|");
            foreach(DepartmentDetails department in departmentList)
            {
                Console.WriteLine("|{0,-14}|{1,-16}|{2,-15}|",department.DepartmentID,department.DepartmentName,department.NumberOfSeats);
                Console.WriteLine("|-----------------------------------------------|");
            }
            Console.Write("Enter the departmentID ");
            string departmentID=Console.ReadLine().ToUpper();
            bool noSeatAvailable=true;
            foreach(DepartmentDetails department in departmentList)
            {
                if((departmentID==department.DepartmentID)&&(department.NumberOfSeats>0))
                {
                    noSeatAvailable=false;
                    if(studentUser.CheckEligibility(75))
                    {
                        bool flag=true;
                        foreach(AdmissionDetails admission in admissionList)
                        {
                            if((admission.StudentID==studentUser.StudentID)&&(admission.AdmissionStatus==AdmissionStatus.Admitted))
                            {
                                flag=false;
                                Console.WriteLine("You have taken admission already");
                                break;
                            }
                        }
                        if(flag)
                        {
                            AdmissionDetails newAdmission=new AdmissionDetails(studentUser.StudentID,departmentID,DateTime.Today,AdmissionStatus.Admitted);
                            admissionList.Add(newAdmission);
                            department.NumberOfSeats=department.NumberOfSeats-1;
                            Console.WriteLine($"Your admission booked successfully and your admissionID is {newAdmission.AdmissionID}");
                        }
                    }
                }
                
            }
            if(noSeatAvailable)
            {
                Console.WriteLine("No seats are available");
            }
        }
        private static void ShowAdmissionDetails()
        {
            bool flag=true;
            Console.WriteLine("|--------------------------------------------------------------------------|");
            Console.WriteLine("| AdmissionId | StudentId | DepartmentID | AdmissionDate | AdmissionStatus |");
            Console.WriteLine("|--------------------------------------------------------------------------|");
            foreach(AdmissionDetails admission in admissionList)
            {
                if(admission.StudentID==studentUser.StudentID)
                {
                    flag=false;
                    Console.WriteLine("|{0,-13}|{1,-11}|{2,-14}|{3,-15}|{4,-17}",admission.AdmissionID,admission.StudentID,admission.DepartmentID,admission.AdmissionDate.ToString("dd/MM/yyyy"),admission.AdmissionStatus);
                    Console.WriteLine("|--------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                Console.WriteLine("No admission data available for the user");
            }
        }
        private static void CancelAdmission()
        {
            Console.WriteLine("|--------------------------------------------------------------------------|");
            Console.WriteLine("| AdmissionId | StudentId | DepartmentID | AdmissionDate | AdmissionStatus |");
            Console.WriteLine("|--------------------------------------------------------------------------|");
            foreach(AdmissionDetails admission in admissionList)
            {
                if((admission.StudentID==studentUser.StudentID)&&(admission.AdmissionStatus==AdmissionStatus.Admitted))
                {
                    Console.WriteLine("|{0,-13}|{1,-11}|{2,-14}|{3,-15}|{4,-17}",admission.AdmissionID,admission.StudentID,admission.DepartmentID,admission.AdmissionDate.ToString("dd/MM/yyyy"),admission.AdmissionStatus);
                    Console.WriteLine("|--------------------------------------------------------------------------|");
                    admission.AdmissionStatus=AdmissionStatus.Cancelled;
                    Console.WriteLine("Your admission cancelled successfully");
                }
            }
        }
    }
}