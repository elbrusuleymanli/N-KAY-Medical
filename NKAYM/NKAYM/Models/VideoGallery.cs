using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class VideoGallery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }

        [NotMapped]
        [Required]
        public IFormFile VideoFile { get; set; }
    }
}
