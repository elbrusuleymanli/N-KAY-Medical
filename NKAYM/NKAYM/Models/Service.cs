
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public List<ServiceOption> ServiceOptions { get; set; }
    }
}
