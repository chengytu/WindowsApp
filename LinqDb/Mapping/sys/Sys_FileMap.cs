using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using  BusModels;
namespace DataFactory.Mapping
{
    public class SysFileMap : EntityTypeConfiguration<SysFile>
    {
        public SysFileMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.RelID)
                .HasMaxLength(40);

            this.Property(t => t.FileName)
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(100);

            this.Property(t => t.FType)
                .HasMaxLength(5);

       
            // Table & Column Mappings
            this.ToTable("Sys_File");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RelID).HasColumnName("RelID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.FType).HasColumnName("FType");
            
        }
    }
}
