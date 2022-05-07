using Microsoft.EntityFrameworkCore;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.DAL
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<NewsRun> NewsRuns { get; set; }
        public DbSet<NewsWall> NewsWalls { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<ServiceOption> ServiceOptions { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

    }
}
