using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string WorkDay { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }


    }
}
