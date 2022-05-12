using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class NewsWall
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate{ get; set; } 
        [Required]
        public string Descr1 { get; set; }
        public string Descr2 { get; set; }
        public string Descr3 { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
