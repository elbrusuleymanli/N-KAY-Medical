using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class VacancyRequest
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string RequestPosition { get; set; }

        public string CV { get; set; }


        [NotMapped]
        [Required]
        public IFormFile PdfFile { get; set; }
    }
}
