namespace Question1
{
    
// Interface: ICalculate
// Properties: ProjectMark
// Methods: CalculateUG -> Total, percentage.

    public interface ICalculate
    {
         public float ProjectMark { get; set; }
         public void CalculateUG();
         
    }
}