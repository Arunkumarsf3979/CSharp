using System;
namespace Question3
{
//     Class UGInfo: Inhertis PersonalInfo
// Properties: UGMarksheet Num, Degree, Branch, Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.
// Method: CheckEligiblity ->75% and above in all semester

    public class UGInfo:PersonalInfo
    {
        public string UGMarksheetNum { get; set; }
        public string Degree { get; set; }
        public string Branch { get; set; }
        public float[] Sem1 { get; set; }
        public float[] Sem2{get;set;}
        public float[] Sem3{get;set;}
        public float[] Sem4{get;set;}
        public UGInfo(string degree,string branch,float[]sem1,float[]sem2,float[]sem3,float[]sem4,string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender):base(name,fatherName,motherName,address,phone,mail,gender)
        {
            Degree=degree;
            Branch=branch;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        
        public void MethodEligibility()
        {
            float total=0;
            foreach (float item in Sem1)
            {
                total=total+item;
            }
            foreach (float item in Sem2)
            {
                total=total+item;
            }
            foreach (float item in Sem3)
            {
                total=total+item;
            }
            foreach (float item in Sem4)
            {
                total=total+item;
            }
            if((total)/28<75)
            {
                System.Console.WriteLine("Eligible");
            }
            else{
                System.Console.WriteLine("Not eligible");
            }
        }
        
        
        
    }
}