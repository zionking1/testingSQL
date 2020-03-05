using System;
namespace MyWebApi
{
    public class ServiceTokenStatusHistoryTBq
    {
        public int ServiceTokenHistoryID { get; set; }
        public int ServiceTokenID { get; set; }
        public int ServiceRoomID { get; set; }
        public int StatusID { get; set; }
        public int TimeSpentSec { get; set;}
        public DateTime CreateDate { get; set;}
        public int CreatedBy { get; set;}
    } 
}