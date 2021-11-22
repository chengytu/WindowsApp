using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class word_collegeMap : EntityTypeConfiguration<View_word_college>
    {
        public word_collegeMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties


            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.cword)
                .HasMaxLength(32);

            this.Property(t => t.cexpression)
                .HasMaxLength(40);

            //Table & Column Mappings
            this.ToTable("word_college");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.cword).HasColumnName("cword");
            this.Property(t => t.cexpression).HasColumnName("cexpression");

        }
    }
}
