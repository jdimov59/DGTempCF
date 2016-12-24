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
         
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
