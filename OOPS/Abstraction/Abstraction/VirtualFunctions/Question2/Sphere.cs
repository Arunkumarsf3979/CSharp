namespace Question2
{
//     Class sphere inherit dimension
// Property : Radius
// Method: overrided calculate -> 4*3.14*Radius* Radius, displayarea.  
    public class Sphere:Dimension
    {
        public double Volume{get;set;}
        public double Radius { get; set; }
        public Sphere(int value1,int value2,double Radius):base(value1,value2)
        {
            this.Radius=Radius;
        }
        public override void Calculate()
        {
            Volume=4*3.14*Radius*Radius;
        }
        
        public override void Display()
        {
            System.Console.WriteLine("Volume   :"+Volume);
        }
    }
}