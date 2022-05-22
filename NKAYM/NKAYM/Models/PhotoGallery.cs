using Microsoft.AspNetCore.Http;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class PhotoGallery
    {
       

        public int Id { get; set; }
        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile PhotoImageFile { get; set; }
    }
}
