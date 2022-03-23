using System.ComponentModel.DataAnnotations;
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

        public enum Section//部分
        {
            First,

            Second,

            Third
        }
    }
}
