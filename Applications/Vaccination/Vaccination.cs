using System;
namespace Vaccination
{
    public enum DoseNumber{Default,one,two,three}
    public class Vaccination
    {
        private static int s_vaccinationID=1000;
        public string RegistrationNumber { get; set; }
        public string VaccineID { get; set; }
        public DoseNumber DoseNumber { get; set; }
        public DateTime VaccinatedDate{get;set;}
        public string VaccinationID{get;}
        public Vaccination(){}
        public Vaccination(string registrationNumber,string vaccineID,DoseNumber doseNumber,DateTime vaccinatedDate)
        {
            s_vaccinationID++;
            VaccinationID="VID"+s_vaccinationID;
            RegistrationNumber=registrationNumber;
            VaccineID=vaccineID;
            DoseNumber=doseNumber;
            VaccinatedDate=vaccinatedDate;

        }
    }
}