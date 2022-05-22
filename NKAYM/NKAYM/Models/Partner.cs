using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string WebAdress { get; set; }
        public int Order { get; set; }

        [NotMapped]
        [Required]

        public IFormFile PartnerImageFile { get; set; }
    }
}
