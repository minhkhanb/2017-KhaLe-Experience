using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
