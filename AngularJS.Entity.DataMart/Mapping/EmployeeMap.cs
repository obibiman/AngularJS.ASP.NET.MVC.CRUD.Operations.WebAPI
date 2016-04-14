using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Country");
            HasKey(t => t.CountryId);
            Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("CountryId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.CountryCode)
                .IsRequired()
                .HasColumnName("CountryCode")
                .HasMaxLength(25)
                .HasColumnType("NVARCHAR");
            Property(t => t.CountryName)
                .IsOptional()
                .HasColumnName("CountryName")
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR");
        }
    }
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            ToTable("State");
            HasKey(t => t.StateId);
            Property(t => t.StateId)
                .IsRequired()
                .HasColumnName("StateId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.StateCode)
                .IsRequired()
                .HasColumnName("StateCode")
                .HasMaxLength(25)
                .HasColumnType("NVARCHAR");
            Property(t => t.StateName)
                .IsOptional()
                .HasColumnName("StateName")
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR");
        }
    }
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employee");
            HasKey(t => t.EmployeeId);
            Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(20)
                .HasColumnType("NVARCHAR");
            Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasMaxLength(20)
                .HasColumnType("NVARCHAR");
            Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.Salary)
                .IsOptional()
                .HasColumnName("Salary")
                .HasColumnType("Decimal");
            Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR");
            Property(t => t.State)
                .IsOptional()
                .HasColumnName("State")
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR");
            Property(t => t.DateOfBirth)
                .IsRequired()
                .HasColumnName("DateOfBirth")
                .HasColumnType("DateTime");
            Property(t => t.IsActive)
                .IsOptional()
                .HasColumnName("IsActive")
                .HasColumnType("BIT");
        }
    }
}