using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"/^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$/")]
        public string PhoneNumber { get; set; }
    }
}
