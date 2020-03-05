using System;
namespace MyWebApi
{
    public class serviceTB1
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string BayArea { get; set; }
        public int AvgServiceTimeSec {get; set;}
        public DateTime CreateDate { get; set;}
        public int CreatedBy { get; set;}
        public DateTime ModifiedDate { get; set;}
        public int ModifiedBy { get; set;}
    }
}