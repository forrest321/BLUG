using System.Data.Entity;

namespace BLUG.Models
{
    public class BlugEntities : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}