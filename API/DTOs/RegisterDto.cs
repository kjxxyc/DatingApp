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
        public string Password { get; set; }
    }
}