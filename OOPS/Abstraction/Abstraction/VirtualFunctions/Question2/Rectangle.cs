namespace Question2
{
    // 
// Class Rectangle inherit dimension
// Property: Length, height
// Methods: overriden calculate >use base class calculate method , displayarea

    public class Rectangle:Dimension
    {
        public float Length { get; set; }
        public float Height { get; set; }
        public Rectangle(int value1,int value2,float length,float height):base(value1,value2)
        {
            Length=length;
            Height=height;
        }
        public override void Calculate()
        {
            base.Calculate();
            Area=Length*Height;
            // System.Console.WriteLine("Area  :"+(Length*Height));
        }
        public override void Display()
        {
            System.Console.WriteLine("Length :"+Length);
            System.Console.WriteLine("Height :"+Height);
            System.Console.WriteLine("Area   :"+Area);
        }
    }
}