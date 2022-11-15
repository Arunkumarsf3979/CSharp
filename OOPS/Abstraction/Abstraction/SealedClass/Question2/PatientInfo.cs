using System;
namespace Question2
{
//     Sealed Class PatientInfo:
// Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
// Method: DisplayInfo

    public sealed class PatientInfo
    {
        private static int s_patientID=1000;
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("PatientID        :"+PatientID);
            System.Console.WriteLine("Name             :"+Name);
            System.Console.WriteLine("FatherName       :"+FatherName);
            System.Console.WriteLine("BedNo            :"+BedNo);
            System.Console.WriteLine("NativePlace      :"+NativePlace);
            System.Console.WriteLine("Admitted for     :"+AdmittedFor);
        }
        
        
        
        
        
        
    }
}