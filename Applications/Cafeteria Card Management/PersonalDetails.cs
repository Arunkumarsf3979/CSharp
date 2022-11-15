using System;
namespace Cafeteria_Card_Management
{
//     •	Name
// •	FatherName
// •	Gender
// •	Mobile
// •	MailID
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        /// <summary>
        /// It express user name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// It is a string and it holds the father name of the object
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// It holds the gender of current object
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// It holds the mobile number of current object
        /// </summary>
        /// <value></value>
        public long Mobile{get;set;}
        /// <summary>
        /// It holds the mailID of current object
        /// </summary>
        /// <value></value>
        public string MailID{get;set;}
        /// <summary>
        /// It belong to the class<see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">It express user name</param>
        /// <param name="fatherName">It is a string and it holds the father name of the object</param>
        /// <param name="mobile">It holds the mobile number of current object</param>
        /// <param name="mail">It holds the mailID of current object</param>
        /// <param name="gender">It holds the gender of current object</param>
        public PersonalDetails(string name,string fatherName,Gender gender,long mobile,string mail)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=mail;
        }
        
        
        
        
        
    }
}