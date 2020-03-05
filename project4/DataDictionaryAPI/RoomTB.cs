using System;
namespace MyWebApi
{
    public class RoomTb
    {
        [Key]
        public int  roomNo { get; set; }
        [Required]
        public string bayArea { get; set; }
        [Required]
        public int serviceId { get; set; }
        public int isInActive { get; set; }
        public DateTime createdDAte { get; set; }
        public int createdBy { get; set; }
        public DateTime modifiedDate { get; set; }
        public int modifiedBy { get; set; }
    }
}