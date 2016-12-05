using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace usdxstartupconnector.Models
{
    public class StartupConnectorDBContext : DbContext
    {
        public StartupConnectorDBContext() : base("StartupConnectorDBContext")
        {

        }

        public DbSet<StartupCard> StartupCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}