namespace Question1
{
//     Interface HSC Info: Inherits PersonalInfo
// Properties: HSCMarksheetNumber, Physics, chemistry, maths, Total, percentage Marks
// Methods: ShowHSCMarksheet, CalculateHSC -> Total, percentage.

    public interface HSCInfo:PersonalInfo
    {
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public float PercentageMarks { get; set; }
        public void ShowHSCMarksheet();
        public void CalculateHSC();
     
    }
}