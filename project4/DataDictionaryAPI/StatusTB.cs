using System;
namespace MyWebApi
{
    public class StatusTB1
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusText { get; set; }
        public string StatusGroup { get; set; }
        public int StatusOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}