using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Doctor> Doctors { get; set; }
        public NewsRun NewsRuns { get; set; }
        public List<NewsWall> NewsWalls { get; set; }
        public List<Partner> Partners { get; set; }
        public ContactInfo ContactInfos { get; set; }
    }
}
