namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        // Properties: StudentID, Degree, Department, semester 
// Methods: Update, Show
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public StudentInfo(string name,string fatherName,string phone,string mail,Gender gender,string degree,string department,string semester):base(name,fatherName,phone,mail,gender)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void Update(string name,string fatherName,string phone,string mail,Gender gender,string degree,string department,string semester)
        {
            Degree=degree;
            Department=department;
            Semester=semester;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
        }
        public void ShowStudentInfo()
        {
            ShowPersonalInfo();
            System.Console.WriteLine("StudentID  :"+StudentID);
            System.Console.WriteLine("Degree     :"+Degree);
            System.Console.WriteLine("Department :"+Department);
            System.Console.WriteLine("Semester   :"+Semester);
        }
    }
}