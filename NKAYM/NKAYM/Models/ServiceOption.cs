using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class ServiceOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Service Services { get; set; }
        public int ServicesId { get; set; }
    }
}
