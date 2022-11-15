namespace Question1
{
    // Class cylinders inherit shape
// Overridden methods: calculate area - 2 π r(r+h) , calculate volume π r2 h

    public class Cylinders:Shape
    {
        public override double Area{get{return area;}set {area=value;}}
        public override double Volume { get {return volume;} set {volume=value;}}
        public override void CalculateArea()
        {
            Area=2*3.14*Radius*(Radius+Height);
        }
        public Cylinders(double radius,double height)
        {
            Radius=radius;
            Height=height;
        }
        public override void CalculateVolume()
        {
            Volume=3.14*Radius*Radius*Height;
        }
    }
}