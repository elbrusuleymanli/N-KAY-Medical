using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string WorkDay { get; set; }
        public string Position { get; set; }
        public List<DoctorPosition> DoctorPositions { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }

        [NotMapped]
        [Required]
        public IFormFile DoctorImageFile { get; set; }


    }
}
