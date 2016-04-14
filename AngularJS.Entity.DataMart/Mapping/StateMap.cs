using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AngularJS.Entity.Domain;

namespace AngularJS.Entity.DataMart.Mapping
{
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
}