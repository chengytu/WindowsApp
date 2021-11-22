
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class graduate_partMap : EntityTypeConfiguration<graduate_part>
    {
        public graduate_partMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.word)
                .HasMaxLength(50);

            this.Property(t => t.etxt)
                .HasMaxLength(500);

            this.Property(t => t.ctxt)
                .HasMaxLength(100);

            this.Property(t => t.type)
                .HasMaxLength(16);

            this.Property(t => t.num);

            //Table & Column Mappings
            this.ToTable("graduate_part");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.word).HasColumnName("word");
            this.Property(t => t.ctxt).HasColumnName("ctxt");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.etxt).HasColumnName("etxt");
            this.Property(t => t.num).HasColumnName("num");


        }
    }
}
