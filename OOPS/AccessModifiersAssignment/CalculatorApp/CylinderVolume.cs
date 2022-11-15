using MathLib;
namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        private double _height=20;
        public double  Height { get; set; }
        internal double Volume { get; set; }
        public CylinderVolume(int internalVolume)
        {
            Height=_height;
            InternalVolume=internalVolume;
        }
        public double CalculateVoulme()
        {
            return CalculateCircleArea()*Height;
        }
    }

}