namespace CollegeAdmissionUpdate
{
    public delegate void EventManager();//user defined delegate
    public static partial class Operations
    {
        public static event EventManager starter;
        public static event EventManager registration,login,check,showDetail,takeAdmissions,cancel,admissionHistory;
        public static void Starter(){Subscribe();starter();}
        
        public static void Subscribe()
        {
            starter +=new EventManager(Files.Create);
            starter+=new EventManager(Files.Readfiles);
            starter+=new EventManager(MainMenu);
            starter+=new EventManager(Files.WriteToFiles);
            registration+=new EventManager(Registration);
            login+=new EventManager(LoginMenu);
            check+=new EventManager(CheckEligibility);
            showDetail+=new EventManager(TakeAdmission);
            cancel+=new EventManager(CancelAdmission);
            admissionHistory+=new EventManager(ShowAdmissionDetails);
            

            
        }
    }
}