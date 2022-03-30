using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Collections.Specialized.BitVector32;    

namespace Lab1.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Key]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public Section section { get; set; }


        [InverseProperty("PreviousRoomId")]
        public int? PreviousClientId { get; set; }
        public Client? PreviousClient { get; set; }


        [InverseProperty("CurrentRoomId")]
        public int? CurrentClientId { get; set; }
        public Client? CurrentClient { get; set; }
        public enum Section//部分
        {
            First,

            Second,

            Third
        }
    }
}
