using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string WorkTime { get; set; }
        public string WorkDays { get; set; }
    }
}
