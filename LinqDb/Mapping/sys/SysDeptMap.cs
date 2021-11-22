using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using  BusModels;
namespace DataFactory.Mapping
{
    public class SysDeptMap : EntityTypeConfiguration<SysDept>
    {
        public SysDeptMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BH)
                .IsRequired()
                .HasMaxLength(10);
            this.Property(t => t.memo)
               .IsRequired()
               .HasMaxLength(150);
            this.Property(t => t.status);
            // Table & Column Mappings
            this.ToTable("Sys_Dept");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PID).HasColumnName("PID");
            this.Property(t => t.BH).HasColumnName("BH");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");

            this.Property(t => t.memo).HasColumnName("memo");
            this.Property(t => t.status).HasColumnName("status");

        }
    }
}
