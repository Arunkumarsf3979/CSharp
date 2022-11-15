namespace Question2
{
//     2.	Create a class that will get semester marks of 6 subjects.
// a.	Create four objects named Sem1, Sem 2, Sem 3, Sem 4 using calculate method 
// that will calculate the total mark, percentage of 6 subject.
// b.	Create a operator overloaded method that will calculate the total mark of 
// 4 semesters and display the total marks and percentage.  

    public class Semester
    {
        public float Tamil { get; set; }
        public float English { get; set; }
        public float Physics { get; set; }
        public float Chemistry{get;set;}
        public float Maths { get; set; }
        public float Biology { get; set; }
        public float TotalMarks { get; set; }
        public float Percentage { get; set; }
        public Semester(float tamil,float english,float physics,float chemsitry,float maths,float biology)
        
        {
            Tamil=tamil;
            English=english;
            Physics=physics;
            Chemistry=chemsitry;
            Maths=maths;
            Biology=biology;
        }
        public Semester(){}
        public void CalculateTotal()
        {
            TotalMarks=Tamil+English+Maths+Physics+Chemistry+Biology;
        }
        public void CalculatePercentage()
        {
            Percentage=TotalMarks/6;
        }

        public static Semester operator +(Semester sem1,Semester sem2)
    {
        Semester tempSem=new Semester();
        sem1.CalculateTotal();
        sem2.CalculateTotal();
        sem1.CalculatePercentage();
        sem1.CalculatePercentage();
        tempSem.TotalMarks=sem1.TotalMarks+sem2.TotalMarks;
        tempSem.Percentage=(sem2.Percentage+sem1.Percentage)/2;
        tempSem.Biology=sem1.Biology+sem2.Biology;
        tempSem.Tamil=sem1.Tamil+sem2.Tamil;
        tempSem.English=sem1.English+sem2.English;
        tempSem.Physics=sem1.Physics+sem2.Physics;
        tempSem.Chemistry=sem1.Chemistry+sem2.Chemistry;
        tempSem.Maths=sem1.Maths+sem2.Maths;
        return tempSem;
    }
    }
}