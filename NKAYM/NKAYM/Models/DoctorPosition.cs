using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class DoctorPosition
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PositionId { get; set; }
        public Doctor Doctor { get; set; }
        public Position Position { get; set; }
    }
}
