using System;
namespace Question1
{
//     Sealed Class EmployeeInfo:
// Properties: UserID, Password, KeyInfo = 100
// Methods: UpdateInfo, DisplayInfo

    public sealed class EmployeeInfo
    {
        private static int s_userID=1000;
        public string UserID { get; set; }
        public string PassWord { get; set; }
        public int KeyInfo=100;
        public EmployeeInfo(string Password)
        {
            s_userID++;
            UserID="UID"+s_userID;
            this.PassWord=PassWord;
        }
        public void UpdateInfo(string PassWord)
        {
            this.PassWord=PassWord;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("User ID   :"+UserID);
            System.Console.WriteLine("Password  :"+PassWord);
        }
        
        
    }
}