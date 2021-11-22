using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class word_page_synMap : EntityTypeConfiguration<word_page_syn>
    {
        public word_page_synMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.type)
                .HasMaxLength(16);

            this.Property(t => t.word)
                .HasMaxLength(40);

            this.Property(t => t.exp)
                .HasMaxLength(40);

            this.Property(t => t.memo)
                .HasMaxLength(40);


            //Table & Column Mappings
            this.ToTable("word_page_syn");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.word).HasColumnName("word");
            this.Property(t => t.exp).HasColumnName("exp");
            this.Property(t => t.memo).HasColumnName("memo");



        }
    }
}
