using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class DocRequest
    {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
       
       
        [Required]
        public DateTime Birhtday { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
      
        [Required]
        public string Unit { get; set; }
        
        public string DoctorsFullname { get; set; }
        [Required]
        public DateTime RequestDay { get; set; }
        [Required]
        public DateTime RequestTime { get; set; }

    }
}
