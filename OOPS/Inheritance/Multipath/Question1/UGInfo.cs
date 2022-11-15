namespace Question1
{
    
// Interface UGInfo: Inhertis PersonalInfo
// Properties: UGMarksheetNumber, Sem1, Sem2, Sem3, Sem4 Marks, Total and Percentage
// Methods: SHowUGMarkSHeet, CalculateUG -> Total, percentage.

    public interface UGInfo:PersonalInfo
    {
        public string UGMarkSheetNumber { get; set; }
        public float Sem1 { get; set; }
        public float Sem2 { get; set; }
        public float Sem3 { get; set; }
        public float Sem4 { get; set; }
        public float TotalMarks { get; set; }
        public float Percentage { get; set; }
        public void ShowHSCMarksheet();
        public void CalculateUG();
        
    }
}