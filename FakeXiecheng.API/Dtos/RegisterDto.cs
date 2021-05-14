using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }
    
        [Required]
        public string Password { get; set; }
    
        [Required]
        [Compare(nameof(Password), ErrorMessage ="The password is inconsistent")]
        public string ConfirmPassword { get; set; }
    }
}
