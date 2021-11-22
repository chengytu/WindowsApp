using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class View_WordPartMap : EntityTypeConfiguration<View_WordPart>
    {
        public View_WordPartMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.type)
                .HasMaxLength(16);

      

            this.Property(t => t.num);
   
            //Table & Column Mappings
            this.ToTable("View_WordPart");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.num).HasColumnName("num");
        



        }
    }
}
