using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class View_graduword_lenMap : EntityTypeConfiguration<View_graduword_len>
    {
        public View_graduword_lenMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

          

            this.Property(t => t.wordlen);
            this.Property(t => t.num);

            //Table & Column Mappings
            //this.ToTable("wordlen");
            this.ToTable("View_graduword_len");


            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.wordlen).HasColumnName("wordlen");
            this.Property(t => t.num).HasColumnName("num");
            


        }
    }
}
