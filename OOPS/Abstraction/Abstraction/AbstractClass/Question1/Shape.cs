namespace Question1
{
//     Abstract class shape
// Abstract Properties: area, volume
// Non abstract properties: radius, height, width, page - a
// Abstract methods: calculate area, calculate volume

    public abstract class Shape
    {
        protected double area;
        protected double volume;

        public abstract double Area{get;set;}
        public abstract double Volume{get;set;}
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Side {get;set;}
        public abstract void CalculateArea();
        public abstract void CalculateVolume();

    }
}