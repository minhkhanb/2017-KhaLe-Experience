using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class UserModel
    {
        [Required, MinLength(6), MaxLength(50), Display(Name ="Username")]
        public string UserName { get; set; }
        [Required, EmailAddress, MaxLength(256), Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Password")]
        public string PassWord { get; set; }
        
    }
}
