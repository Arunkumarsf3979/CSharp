using System;
namespace Question1;

// Class VolumeCalculator inherit AreaCalculator
// Property: height
// Method: override Calculate override display

    public class VolumeCalculator:AreaCalculator
    {
        public int  Height { get; set; }
        public double Volume{get;set;}
        public override void Calculate()
        {
            Volume=3.14*Radius*Radius*Height;
            System.Console.WriteLine(Volume);
        }
        public VolumeCalculator(int radius,int height):base(radius)
        {
            Height=height;
        }
        public override void display()
        {
            System.Console.WriteLine("Volume   :"+Volume);
            System.Console.WriteLine("Height   :"+Height);
        }
    }
