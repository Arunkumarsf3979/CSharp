namespace Question2
{
    // Property: value1, value 2, Area
// Methods: virtual calculate  -> value1* value2, displayarea

    public class Dimension
    {
        public int  Value1 { get; set; }
        public int Value2 { get; set; }
        public Dimension(int value1,int value2)
        {
            Value1=value1;
            Value2=value2;
        }
        public double Area { get; set; }
        public virtual void Calculate()
        {
            Area=Value1*Value2;
            System.Console.WriteLine("Dimension area   :"+Area);
        }
        public virtual void Display()
        {
            System.Console.WriteLine("Area :"+Area);
        }
    }
}