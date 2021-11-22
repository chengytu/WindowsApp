using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class view_Course_ChapPageMap : EntityTypeConfiguration<view_Course_ChapPage>
    {
        public view_Course_ChapPageMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Coursebh)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bh)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(20);

            this.ToTable("view_Focus_Course_ChapPage");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Coursebh).HasColumnName("Coursebh");
            this.Property(t => t.bh).HasColumnName("bh");
            this.Property(t => t.name).HasColumnName("name");
            
        }
    }
}
