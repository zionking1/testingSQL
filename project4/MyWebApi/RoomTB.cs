using System;
namespace MyWebApi
{
    public class RoomTb
    {
        public int  roomNo { get; set; }
        public string bayArea { get; set; }
        public int serviceId { get; set; }
        public int isInActive { get; set; }
        public DateTime createdDAte { get; set; }
        public int createdBy { get; set; }
        public DateTime modifiedDate { get; set; }
        public int modifiedBy { get; set; }
    }
}