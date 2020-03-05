using System;
using System.ComponentModel.DataAnnotations;
namespace MyWebApi
{
    public class EmpIDg
    {
        [Key]
        public string EmpID { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Password { get; set; }
        public string Department { get; set; }
        public int ServiceID { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
