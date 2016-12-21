using DGTempCF.DataModels;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DGTempCF.Data
{
    public class DGTempCFContext : DbContext
    {
        public DGTempCFContext() : base("DGTempCF")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
