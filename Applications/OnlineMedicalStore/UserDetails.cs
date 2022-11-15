namespace OnlineMedicalStore
{
    /// <summary>
    /// class <see cref=UserDetails 
    /// 
    /// </summary>
    public class UserDetails
    {
        private static int s_userID=1000;
        public string  UserID { get;}
        /// <summary>
        /// User name as mentioned in government proof
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// valid age must be entered
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Present city not the native one
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// PhoneNumber should be enter without extension
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Here the amount is stored securely
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }
        /// <summary>
        /// for getting user details
        /// </summary>
        /// <param name="userName">name of registered user</param>
        /// <param name="age">age of the user</param>
        /// <param name="city">Place where the user is present</param>
        /// <param name="phoneNumber">Mobile number of user</param>
        /// <param name="balance">Balance present in user wallet</param>
        public UserDetails(string userName,int age,string city,string phoneNumber,double balance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            UserName=userName;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }
    }
}