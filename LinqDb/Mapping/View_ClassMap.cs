using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class View_ClassMap : EntityTypeConfiguration<View_Class>
    {
        public View_ClassMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties


            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.ClassName)
                .HasMaxLength(20);

            
            this.ToTable("View_class");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
        }
    }
}

