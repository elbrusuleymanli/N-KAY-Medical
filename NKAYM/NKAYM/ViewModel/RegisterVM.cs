using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.ViewModel
{
    public class RegisterVM
    {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required,MaxLength(15)]
        public string Username { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
