using System;
namespace MyWebApi
{
    public class PatientTb
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Gender { get; set;}
        public string Address { get; set;}
        public int PhoneNumber { get; set;}
        public DateTime CraeteDAte { get; set;}
        public int CraetedBy { get; set;}
        public DateTime ModifiedDAte { get; set;}
        public int ModifiedBy { get; set;}
        
    }
}