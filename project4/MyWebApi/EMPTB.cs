using System;
namespace MyWebApi
{
    public class EmpIDg
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public int ServiceID { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
