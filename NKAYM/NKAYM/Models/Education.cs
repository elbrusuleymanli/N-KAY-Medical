using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string TypeOfUniver { get; set; }
        public string NameOfUniver { get; set; }
        public string Specialty { get; set; }
        public DateTime StartUniver { get; set; }
        public DateTime  EndUniver { get; set; }
        public string Country { get; set; }
        public Doctor Doctor { get; set; }

    }
}
