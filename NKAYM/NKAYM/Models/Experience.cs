using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Section { get; set; }
        public string Position { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime  EndWork { get; set; }
        public string Country { get; set; }
        public Doctor Doctor { get; set; }

    }
}
