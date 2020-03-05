using System;
namespace MyWebApi
{
    public class ServiceToken
    {
        public int ServiceTokenID { get; set; }
        public int ServiceID { get; set; }
        public DateTime ServiceDate { get; set; }
        public int PatientID { get; set; }
        public DateTime ServiceTokenDate { get; set; }
        public int ServiceTokenQueueNo { get; set; }
        public int CurrentStatusID { get; set; }
        public DateTime CreateDate { get; set;}
        public int CreatedBy { get; set;}
    }
}