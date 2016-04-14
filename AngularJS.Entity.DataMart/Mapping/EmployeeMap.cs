using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.Mapping
{
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