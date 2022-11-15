using System;
using System.Collections.Generic;
namespace Vaccination
{
    public static class Operation
    {
        private static List<Beneficiary> beneficiariesList=new List<Beneficiary>();
        private static List<Vaccination> vaccinationList=new List<Vaccination>();
        private static List<Vaccine> vaccineList=new List<Vaccine>();
        private static Beneficiary currentUser;
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to MainMenu");
            int choice;
            do{
                Console.WriteLine("1.Beneficiary Registration");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Get Vaccine Info");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice :");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Welcome to Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Welcome to Login page");
                        Login();
                        // SubMenu();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Get Vaccine Info");
                        GetVaccineInfo();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Exited from the application");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice Please enter again");
                        break;
                    }
                }
            }while(choice!=4);
        }
        private static void Registration()
        {
            Console.Write("Enter your name                     :");
            string name=Console.ReadLine();
            Console.Write("Enter your age                      :");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your gender                   :");
            Gender gender=Gender.Default;
            bool flag=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!flag)
            {
                Console.Write("Invalid Enter your gender again :");
                flag=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            Console.Write("Enter your mobile number            :");
            string mobileNumber=Console.ReadLine();
            Console.Write("Enter your city                     :");
            string city=Console.ReadLine();
            Beneficiary beneficiary=new Beneficiary(name,gender,mobileNumber,city,age);
            beneficiariesList.Add(beneficiary);
            Console.WriteLine($"Registration successfully and your Register Number is {beneficiary.RegistrationNumber}");
        }
        private static void Login()
        {
            Console.Write("Enter your register number              :");
            string registerNumber=Console.ReadLine();
            bool flag=true;
            foreach(Beneficiary beneficiary in beneficiariesList)
            {
                if(beneficiary.RegistrationNumber==registerNumber)
                {
                    flag=false;
                    currentUser=beneficiary;
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Register Number");
            }
        }
        private static void SubMenu()
        {
            int choice;
            do{
                Console.WriteLine("Login successfully");
                Console.WriteLine("1.Show My Details");
                Console.WriteLine("2.Take Vaccination");
                Console.WriteLine("3.My Vaccination History");
                Console.WriteLine("4.Next Due Date");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice        :");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Beneficiaries Information");
                        ShowMyDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Vaccination form");
                        TakeVaccination();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Vaccination History");
                        VaccinationHistory();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Your Next due date");
                        NextDueDate();
                        break;
                    }

                }
            }while(choice!=5);
        }
        private static void ShowMyDetails()
        {
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",currentUser.RegistrationNumber,currentUser.Name,currentUser.Gender,currentUser.MobileNumber,currentUser.City);
        }
        private static void VaccinationHistory()
        {
            bool flag=true;
            foreach(Vaccination vaccination in vaccinationList)
            {
                if(vaccination.RegistrationNumber==currentUser.RegistrationNumber)
                {
                    flag=false;
                    Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",vaccination.VaccinationID,vaccination.RegistrationNumber,vaccination.VaccineID,(int)vaccination.DoseNumber,vaccination.VaccinatedDate.ToString("dd/MM/yyyy"));
                }
            }
            if(flag)
            {
                Console.WriteLine("You haven't taken any vaccination yet");
            }
        }
        private static void TakeVaccination()
        {
            foreach(Vaccine vaccine in vaccineList)
            {
                Console.WriteLine("|{0}|{1}|{2}|",vaccine.VaccineID,vaccine.VaccineName,vaccine.NoOfDoseAvailable);
            }
            Console.Write("Enter a vaccineId for vaccination :");
            string vaccineID=Console.ReadLine();
            foreach(Vaccine vaccine in vaccineList)
            {
                if(vaccineID==vaccine.VaccineID)
                {
                    foreach(Beneficiary beneficiary in beneficiariesList)
                    {
                        Vaccination tempVaccination=new Vaccination();
                        if(beneficiary.RegistrationNumber==currentUser.RegistrationNumber)
                        {
                            foreach(Vaccination vaccination in vaccinationList)
                            {
                                if(currentUser.RegistrationNumber==vaccination.RegistrationNumber)
                                {tempVaccination=vaccination;}
                            }
                            if((int)tempVaccination.DoseNumber==3)
                            {
                                System.Console.WriteLine("All three Vaccines are vaccinated...");
                            }
                            else if((int)tempVaccination.DoseNumber==2)
                            {
                                if(vaccineID==tempVaccination.VaccineID)
                                {
                                    if(tempVaccination.VaccinatedDate.AddDays(30)<DateTime.Today)
                                    {
                                        Vaccination newVaccination=new Vaccination(currentUser.RegistrationNumber,vaccineID,DoseNumber.three,DateTime.Today);
                                        vaccinationList.Add(newVaccination);
                                        vaccine.NoOfDoseAvailable--;
                                        System.Console.WriteLine("Vaccinated Successfully...");
                                    }
                                    else{
                                        System.Console.WriteLine("You did not reach the due date "+tempVaccination.VaccinatedDate.AddDays(30).ToString("dd/MM/yyyy"));
                                    }
                                }
                                else{
                                    System.Console.WriteLine("You have chose the wrong vaccine");
                                }
                            }
                            else if((int)tempVaccination.DoseNumber==1)
                            {
                                if(vaccineID==tempVaccination.VaccineID)
                                {
                                    if(tempVaccination.VaccinatedDate.AddDays(30)<DateTime.Today)
                                    {
                                        Vaccination newVaccination=new Vaccination(currentUser.RegistrationNumber,vaccineID,DoseNumber.two,DateTime.Today);
                                        vaccinationList.Add(newVaccination);
                                        vaccine.NoOfDoseAvailable--;
                                        System.Console.WriteLine("Vaccinated Sucessfully...");
                                    }
                                    else{
                                        System.Console.WriteLine("You did not reach the due date "+tempVaccination.VaccinatedDate.AddDays(30).ToString("dd/MM/yyyy"));
                                    }
                                }
                                else{
                                    System.Console.WriteLine("You have chose the wrong vaccine");
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void NextDueDate()
        {
            bool flag=true;
            int doseCount=0;
            Vaccination currentUserVaccination=vaccinationList[0];
            foreach(Vaccination vaccination in vaccinationList)
            {
                if(vaccination.RegistrationNumber==currentUser.RegistrationNumber)
                {
                    flag=false;
                    if(doseCount<(int)vaccination.DoseNumber)
                    {
                        doseCount=(int)vaccination.DoseNumber;
                        currentUserVaccination=vaccination;
                    }
                }
            }
            if(flag)
            {
                Console.WriteLine("You haven't taken any vaccination yet");
            }
            else
            {
                Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}|",currentUserVaccination.VaccinationID,currentUserVaccination.RegistrationNumber,currentUserVaccination.VaccineID,(int)currentUserVaccination.DoseNumber,currentUserVaccination.VaccinatedDate.ToString("dd/MM/yyyy"),currentUserVaccination.VaccinatedDate.AddDays(30).ToString("dd/MM/yyyy"));
            }
        }
        private static void GetVaccineInfo()
        {
            foreach(Vaccine vaccine in vaccineList)
            {
                vaccine.ShowVaccineInfo();
            }
        }        
        public static void DefaultData()
        {
            Beneficiary beneficiary1=new Beneficiary("Ravichandran",Gender.Male,"8484484","Chennai",21);
            Beneficiary beneficiary2=new Beneficiary("Baskaran",Gender.Male,"8484747","Chennai",22);
            beneficiariesList.Add(beneficiary1);
            beneficiariesList.Add(beneficiary2);

            Vaccine vaccine1=new Vaccine("Covishield",50);
            Vaccine vaccine2=new Vaccine("Covaccine",50);
            vaccineList.Add(vaccine1);
            vaccineList.Add(vaccine2);

            Vaccination vaccination1=new Vaccination("BID1001","CID101",(DoseNumber)1,new DateTime(2021,11,11));
            Vaccination vaccination2=new Vaccination("BID1001","CID101",DoseNumber.two,new DateTime(2021,11,03));
            Vaccination vaccination3=new Vaccination("BID1002","CID102",DoseNumber.one,new DateTime(2021,04,04));
            vaccinationList.Add(vaccination1);
            vaccinationList.Add(vaccination2);
            vaccinationList.Add(vaccination3);
        }
    }
}