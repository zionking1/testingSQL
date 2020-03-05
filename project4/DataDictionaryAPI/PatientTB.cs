using System;
namespace MyWebApi
{
    public class PatientTb
    {
        [Key]
        public int PatientID { get; set; }
        [Required]
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set;}
        [Required]
        public string Address { get; set;}
        public int PhoneNumber { get; set;}
        public DateTime CraeteDAte { get; set;}
        public int CraetedBy { get; set;}
        public DateTime ModifiedDAte { get; set;}
        public int ModifiedBy { get; set;}
        
    }
}