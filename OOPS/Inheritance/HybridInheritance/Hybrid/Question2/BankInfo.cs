namespace Question2
{
    
// Class BankInfo:
// Properties: BankName, IFSC, Branch

    public interface BankInfo
    {
        public string BankName { get; set; }
        public string Branch { get; set; }
        
        public string IFSC{get;set;}
        
    }
}