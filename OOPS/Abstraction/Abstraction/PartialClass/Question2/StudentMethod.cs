namespace Question2
{
    public partial class Student
    {
        public int Total()
        {
            return (Physics+Chemistry+Maths);
        }
        public int CalculatePercentage()
        {
            return (Physics+Chemistry+Maths)/3;
        }
        public void Display()
        {
            System.Console.WriteLine("StudentID     :"+StudentID);
            System.Console.WriteLine("Name          :"+Name);
            System.Console.WriteLine("Mobile        :"+Mobile);
            System.Console.WriteLine("Gender        :"+Gender);
            System.Console.WriteLine("DOB           :"+DOB);
            System.Console.WriteLine("Physics       :"+Physics);
            System.Console.WriteLine("Chemistry     :"+Chemistry);
            System.Console.WriteLine("Maths         :"+Maths);
        }
    }
}