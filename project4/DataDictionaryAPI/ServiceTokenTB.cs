using System;
namespace MyWebApi
{
    public class ServiceToken
    {
        [Key]
        public int ServiceTokenID { get; set; }
        [Required]
        public int ServiceID { get; set; }
        public DateTime ServiceDate { get; set; }
        [Required]
        public int PatientID { get; set; }
        [Required]
        public DateTime ServiceTokenDate { get; set; }
        [Required]
        public int ServiceTokenQueueNo { get; set; }
        public int CurrentStatusID { get; set; }
        public DateTime CreateDate { get; set;}
        public int CreatedBy { get; set;}
    }
}