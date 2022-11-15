namespace Vaccination
{
    public class Vaccine
    {
        private static int s_vaccineID=100;
        public string VaccineName { get; set; }
        public int NoOfDoseAvailable { get; set; }
        public string VaccineID { get; }
        public Vaccine(string vaccineName,int noOfDoseAvailable)
        {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=vaccineName;
            NoOfDoseAvailable=noOfDoseAvailable;
        }
        public void ShowVaccineInfo()
        {
            System.Console.WriteLine("|{0}|{1}|{2}|",VaccineID,VaccineName,NoOfDoseAvailable);
        }
    }
}