using System;
namespace Question2
{
//     Class Car
// Property: FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven
// Method: CalculateMilage
    public enum FuelType{Petrol,Diesel}
    public class Car
    {
        public FuelType FuelType { get; set; }
        public int  NoOfSeats { get; set; }
        public string Color { get; set; }
        public float TankCapacity { get; set; }
        public float NoOfKmDriven { get; set; }
        public float Milage { get; set; }
        
        
        public void CalculateMilage()
        {
            Milage=NoOfKmDriven/TankCapacity;
        }
        
        
        
        
        
        
    }
}