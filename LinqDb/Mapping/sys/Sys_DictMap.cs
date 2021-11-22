using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using  BusModels;
namespace DataFactory.Mapping
{
    public class SysDictMap : EntityTypeConfiguration<SysDict>
    {
        public SysDictMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.DictCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DValue)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DText)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Sys_Dict");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DictCode).HasColumnName("DictCode");
            this.Property(t => t.DValue).HasColumnName("DValue");
            this.Property(t => t.DText).HasColumnName("DText");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
           

        }
    }
}
