namespace Question1
{
//     Interface FamilyInfo: inherit ShowData
// Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings   
// Method: Show Info
    public interface FamilyInfo:ShowData
    {
        public string FatherName{get;set;}
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSibilings { get; set; }
    }
}