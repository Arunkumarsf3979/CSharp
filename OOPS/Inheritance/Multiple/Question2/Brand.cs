namespace Question2
{
//     Interface  Brand:
// Property: BrandName, ModelName
// Method: Show Details

    public interface IBrand
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        
        public void ShowDetails();
        
    }
}