using System;
using System.Collections.Generic;
namespace Question1
{
    public class PrincipalInfo:PersonalInfo
    {
//         Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
// Methods: Update, Show
        private static int s_princpalID=1000;
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name,string fatherName,string phone,string mail,Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phone,mail,gender)
        {
            s_princpalID++;
            PrincipalID="PID"+s_princpalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void Update(string name,string fatherName,string phone,string mail,Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining)
        {
            
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowInfo()
        {
            ShowPersonalInfo();
            System.Console.WriteLine("PrincipalID   :"+PrincipalID);
            System.Console.WriteLine("Qualification :"+Qualification);
            System.Console.WriteLine("YearOfExperience :"+YearOfExperience);
            System.Console.WriteLine("DateofJoining :"+DateOfJoining);
        }

    }
}