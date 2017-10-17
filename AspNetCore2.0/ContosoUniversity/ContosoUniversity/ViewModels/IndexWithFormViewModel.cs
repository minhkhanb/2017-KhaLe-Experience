using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.ViewModels
{
    public class IndexWithFormViewModel
    {
        [Required(ErrorMessage = "The Id field is required.")]
        public int? Id { get; set; }
        [MinLength(2, ErrorMessage = "The First Name field must contain at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "The First Name field cannot contain more than 50 characters.")]
        public string FirstName { get; set; }
        [MinLength(2, ErrorMessage = "The Last Name field must contain at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "The Last Name field cannot contain more than 50 characters.")]
        public string LastName { get; set; }
        [Phone(ErrorMessage = "Phone number must be a valid number.")]
        public string PhoneNumber { get; set; }
    }
}
