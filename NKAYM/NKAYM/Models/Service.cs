
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string Title_RU { get; set; }
        //public string Title_EN { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public List<ServiceOption> ServiceOptions { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ServiceImageFile { get; set; }
    }
}
