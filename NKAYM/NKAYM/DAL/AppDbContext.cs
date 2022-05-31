
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


       
        public DbSet<Service> Services { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<NewsRun> NewsRuns { get; set; }
        public DbSet<NewsWall> NewsWalls { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<DoctorPosition> DoctorPositions { get; set; }
        public DbSet<ServiceOption> ServiceOptions { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public DbSet<VideoGallery> VideoGalleries { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<NavMenu> NavMenus { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<DocRequest> DocRequests { get; set; }
        public DbSet<VacancyRequest> VacancyRequests { get; set; }


    }
}
