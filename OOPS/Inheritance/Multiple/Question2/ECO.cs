namespace Question2
{
//     Class Eco  inherit Car, Brand
// Property:   MakingID(Auto),, EngineNumber, ChasisNumber
// Method: UpdateDetails

    public class ECO:Car,IBrand
    {
        private static int s_makingID=1000;
        public string MakingID { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        
        public void ShowDetails()
        {
            System.Console.WriteLine("TankCapacity    :"+TankCapacity);
            System.Console.WriteLine("Fueltype        :"+FuelType);
            System.Console.WriteLine("BrandName       :"+BrandName);
            System.Console.WriteLine("Modelname       :"+ModelName);
            System.Console.WriteLine("Milage          :"+Milage);

        }
    }
}