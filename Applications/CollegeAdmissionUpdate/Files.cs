using System;
using System.IO;
namespace CollegeAdmissionUpdate
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CollegeAdmission"))
            {
                System.Console.WriteLine("Creating the folder");
                Directory.CreateDirectory("CollegeAdmission");
                System.Console.WriteLine("folder created sucessfully....");
            }
            else{
                System.Console.WriteLine("Folder existing.....");
            }
            if(!File.Exists("CollegeAdmission/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating  the file");
                var file=File.Create("CollegeAdmission/StudentDetails.csv");
                System.Console.WriteLine("file created successfully...");
                file.Close();
            }
            else{
                System.Console.WriteLine("File existing....");
            }
            if(!File.Exists("CollegeAdmission/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating  the file");
                var file=File.Create("CollegeAdmission/AdmissionDetails.csv");
                System.Console.WriteLine("file created successfully...");
                file.Close();
            }
            else{
                System.Console.WriteLine("File existing....");
            }
            if(!File.Exists("CollegeAdmission/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating  the file");
                var file=File.Create("CollegeAdmission/DepartmentDetails.csv");
                System.Console.WriteLine("file created successfully...");
                file.Close();
            }
            else{
                System.Console.WriteLine("File existing....");
            }
        }
        // string studentName,string fatherName,DateTime dob,Gender gender,float physics,float chemistry,float maths
        public static void WriteToFiles()
        {
            
            String [] studentDetails=new String[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentID+','+Operations.studentList[i].StudentName+','+Operations.studentList[i].FatherName+','+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+','+Operations.studentList[i].Gender+','+Operations.studentList[i].Physics+','+Operations.studentList[i].Chemistry+','+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("CollegeAdmission/StudentDetails.csv",studentDetails);
            // string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus
            String[] admissionDetails=new String[Operations.admissionList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i]=Operations.admissionList[i].AdmissionID+','+Operations.admissionList[i].StudentID+','+Operations.admissionList[i].DepartmentID+','+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+','+Operations.admissionList[i].AdmissionStatus+','+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("CollegeAdmission/AdmissionDetails.csv",admissionDetails);
            // string departmentName,int numberOfSeats
            String[] departmentDetails=new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.departmentList.Count;i++)
            {
                departmentDetails[i]=Operations.departmentList[i].DepartmentID+','+Operations.departmentList[i].DepartmentName+','+Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("CollegeAdmission/DepartmentDetails.csv",departmentDetails);
        }
        public static void Readfiles()
        {
            string[] studentInfo=File.ReadAllLines("CollegeAdmission/StudentDetails.csv");
            foreach(string data in studentInfo)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }
            string[] admissionInfo=File.ReadAllLines("CollegeAdmission/AdmissionDetails.csv");
            foreach(string data in admissionInfo)
            {
                AdmissionDetails admission=new AdmissionDetails(data);
                Operations.admissionList.Add(admission);
            }
            string[] departmentInfo=File.ReadAllLines("CollegeAdmission/DepartmentDetails.csv");
            foreach(string data in departmentInfo)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operations.departmentList.Add(department);
            }
        }
    }
}