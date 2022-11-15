using System;
namespace Question1
{
//     Class PGCouncelling inherits HSCInfo, UGInfo
// Properties: ApplicationID, DateOfApplication, FeeStatus.
// Method: UpdateInfo, ShowInfo, PayFees ->500 Rs. 
    public enum FeeStatus{Paid,Pending};
    public class PGCancelling:HSCInfo,UGInfo
    {
        private static int s_applicationID=1000;
        public string ApplicationID { get; set; }
        public DateTime DateOfApplication{get;set;}
        public FeeStatus FeeStatus{get;set;}
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public float PercentageMarks { get; set; }
        public string UGMarkSheetNumber { get; set; }
        public float Sem1 { get; set; }
        public float Sem2 { get; set; }
        public float Sem3 { get; set; }
        public float Sem4 { get; set; }
        public float TotalMarks { get; set; }
        public float Percentage { get; set; }
        public string AdharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public PGCancelling(string name,string fatherName,long phone,DateTime dob,Gender gender,string AdharNumber,String UGMarkSheetNumber,int physics,int chemistry,int maths,string HSCMarksheetNumber,float sem1,float sem2,float sem3,float sem4,DateTime dateOfApplication)
        {
            s_applicationID++;
            ApplicationID="AID"+s_applicationID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            this.AdharNumber=AdharNumber;
            Gender=gender;
            this.UGMarkSheetNumber=UGMarkSheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            this.HSCMarksheetNumber=HSCMarksheetNumber;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
            DateOfApplication=dateOfApplication;
        }
        public void ShowHSCMarksheet()
        {
            System.Console.WriteLine("Physics     :"+Physics);
            System.Console.WriteLine("Chemistry   :"+Chemistry);
            System.Console.WriteLine("Maths       :"+Maths);
            System.Console.WriteLine("Total       :"+Total);
            System.Console.WriteLine("Percentage  :"+PercentageMarks);
        }
        public void CalculateHSC()
        {
            Total=Physics+Maths+Chemistry;
            PercentageMarks=Total/3;
        }
        public void CalculateUG()
        {
            TotalMarks=Sem1+Sem2+Sem3+Sem4;
            Percentage=TotalMarks/4;
        }
        public void UpdateInfo(string name,string fatherName,long phone,DateTime dob,Gender gender,string AdharNumber,String UGMarkSheetNumber,int physics,int chemistry,int maths,string HSCMarksheetNumber,float sem1,float sem2,float sem3,float sem4,DateTime dateOfApplication)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            this.AdharNumber=AdharNumber;
            Gender=gender;
            this.UGMarkSheetNumber=UGMarkSheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            this.HSCMarksheetNumber=HSCMarksheetNumber;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
            DateOfApplication=dateOfApplication;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("ApplicationID     :"+ApplicationID);
            System.Console.WriteLine("Name              :"+Name);
            System.Console.WriteLine("FatherName        :"+FatherName);
            System.Console.WriteLine("Phone             :"+Phone);
            System.Console.WriteLine("DOB               :"+DOB);
            System.Console.WriteLine("AdharNumber       :"+AdharNumber);
            System.Console.WriteLine("Gender            :"+Gender);
            System.Console.WriteLine("UGMarksheetNumber :"+UGMarkSheetNumber);
            System.Console.WriteLine("Physics           :"+Physics);
            System.Console.WriteLine("Chemistry         :"+Chemistry);
            System.Console.WriteLine("Maths             :"+Maths);
            System.Console.WriteLine("HSCMarksheetNumber:"+HSCMarksheetNumber);
            System.Console.WriteLine("Sem1              :"+Sem1);
            System.Console.WriteLine("Sem2              :"+Sem2);
            System.Console.WriteLine("Sem3              :"+Sem3);
            System.Console.WriteLine("Sem4              :"+Sem4);
            System.Console.WriteLine("DateOfApplication :"+DateOfApplication);

        }
        public void PayFees(int amount)
        {
            if(amount>500)
            {
                FeeStatus=FeeStatus.Paid;
            }
            else{
                FeeStatus=FeeStatus.Pending;
            }
        }
    }
}