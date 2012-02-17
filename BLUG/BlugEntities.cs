using System.Data.Entity;
using BLUG.Models;

namespace BLUG
{
    public class BlugEntities : DbContext
    {
        public DbSet<ClassOffering> ClassOfferings { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
