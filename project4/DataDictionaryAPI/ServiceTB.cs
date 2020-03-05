using System;
namespace MyWebApi
{
    public class serviceTB1
    {
        [Key]
        public int ServiceID { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public string BayArea { get; set; }
        [Required]
        public int AvgServiceTimeSec {get; set;}
        public DateTime CreateDate { get; set;}
        public int CreatedBy { get; set;}
        public DateTime ModifiedDate { get; set;}
        public int ModifiedBy { get; set;}
    }
}