using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AngularJS.Entity.DataMart.DataSeeding;
using AngularJS.Entity.DataMart.Mapping;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.DataContext
{
    public class AngularContext : DbContext
    {
        public AngularContext() : base("Name=AngularCrudDb")
        {
            {
                Database.SetInitializer(new DataContextInitializer());
            }
            //if (Database.Exists() && !Database.CompatibleWithModel(false))
            //{
            //    Database.Delete();
            //}

            //if (!Database.Exists())
            //{
            //    Database.Create();
            //}
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new StateMap());


            //Enable-Migrations -EnableAutomaticMigrations -Force
            //Update-Database -Script -ProjectName MoneyMatters.DataAccess
            //Enable-Migrations -ProjectName MoneyMatters.DataAccess

            modelBuilder.Entity<State>().HasRequired(p => p.Country);

            //
            base.OnModelCreating(modelBuilder);
        }
    }
}