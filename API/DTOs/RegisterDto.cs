using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        /*
        [Phone]
        [MaxLength]
        [StringLength]
        [PasswordPropertyText] 
        [RegularExpression]*/
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}