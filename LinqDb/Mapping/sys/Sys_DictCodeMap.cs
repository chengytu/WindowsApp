using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using  BusModels;
namespace DataFactory.Mapping
{
    public class SysDictCodeMap : EntityTypeConfiguration<SysDictCode>
    {
        public SysDictCodeMap()
        {
            // Primary Key
            //this.HasKey(t => t.Code);

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_DictCode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
