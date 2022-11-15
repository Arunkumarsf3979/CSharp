namespace EB
{
    public class EBBill
    {
        private static int s_meterId=1000;
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public double UnitsUsed { get; set; }
        public string MeterID{get;}

        public EBBill(string name,string phone,string mail,double units)
        {
            s_meterId++;
            MeterID="EB"+s_meterId;
            UserName=name;
            PhoneNumber=phone;
            Mail=mail;
            UnitsUsed=units;
        }
        public double CalculateAmount()
        {
            return UnitsUsed*5;
        }
    }

}