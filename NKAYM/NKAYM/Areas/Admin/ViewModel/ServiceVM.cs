using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.ViewModel
{
    public class ServiceVM
    {
        public List<Service> Services { get; set; }
        public List<ServiceOption> ServiceOptions { get; set; }
    }
}
