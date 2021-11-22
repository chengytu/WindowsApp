using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class view_word_page_syn_typeMap : EntityTypeConfiguration<view_word_page_syn_type>
    {
        public view_word_page_syn_typeMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.type)
                .HasMaxLength(40);

            
            //Table & Column Mappings
            this.ToTable("view_word_page_syn_type");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.num).HasColumnName("num");
         



        }
    }
}
