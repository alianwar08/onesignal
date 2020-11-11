namespace Backend.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Migrations;

    internal sealed class onesignalDB2_Configuration : DbMigrationsConfiguration<onesignalDB2>
    {
        public onesignalDB2_Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "onesignalDB2";
        }
    }
    public partial class onesignalDB2 : DbContext
    {
        public onesignalDB2()
            : base("name=onesignalDB2")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<onesignalDB2, onesignalDB2_Configuration>());

        }

        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<App> apps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
