using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1.Models
{
    public class Credit
    {
        [Key]
        public int CreditNumber { get; set; }
        public bool IsValid { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string HolderName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
