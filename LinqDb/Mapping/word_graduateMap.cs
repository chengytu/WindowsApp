
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class word_graduateMap : EntityTypeConfiguration<word_graduate>
    {
        public word_graduateMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.word)
                .HasMaxLength(50);

            this.Property(t => t.exp)
                .HasMaxLength(500);


            this.Property(t => t.IID);
            this.Property(t => t.testrank);
            this.Property(t => t.wordlen);

            //Table & Column Mappings
            this.ToTable("word_graduate");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.word).HasColumnName("word");
            this.Property(t => t.exp).HasColumnName("exp");
            this.Property(t => t.wordlen).HasColumnName("wordlen");
            this.Property(t => t.testrank).HasColumnName("testrank");



        }
    }
}
