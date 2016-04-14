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
}