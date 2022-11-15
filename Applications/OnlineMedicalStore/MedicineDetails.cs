using System;
namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID=100;
        /// <summary>
        /// each medicine has its own unique id
        /// </summary>
        /// <value></value>
        public string MedicineID { get;  }
        /// <summary>
        /// medicine name
        /// </summary>
        /// <value></value>
        public string MedicineName { get; set; }
        /// <summary>
        /// Number of medicines in the stock
        /// </summary>
        /// <value></value>
        public int AvailableCount { get; set; }
        /// <summary>
        /// amount of medicine
        /// </summary>
        /// <value></value>
        public double Price { get; set; }
        /// <summary>
        /// Date of expiry
        /// </summary>
        /// <value></value>
        public DateTime DateOfExpiry { get; set; }
        /// <summary>
        /// for getting medicinal details
        /// </summary>
        /// <param name="medicineName">Name of the medicine</param>
        /// <param name="availableCount">available stock of medicines</param>
        /// <param name="price">each product has its own price</param>
        /// <param name="dateOfExpiry">each product has an expiry date</param>
        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

    }
}