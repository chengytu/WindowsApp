using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class View_gWord_lenTspaceMap : EntityTypeConfiguration<View_gWord_lenTspace>
    {
        public View_gWord_lenTspaceMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.ch)
                .HasMaxLength(1);


            this.Property(t => t.c1);
            this.Property(t => t.c2);
            this.Property(t => t.c3);
            this.Property(t => t.c4);
            this.Property(t => t.c5);
            this.Property(t => t.c6);
            this.Property(t => t.c7);
            this.Property(t => t.c8);
            this.Property(t => t.c9);
            this.Property(t => t.c10);
            this.Property(t => t.c11);
            this.Property(t => t.c12);
            this.Property(t => t.c13);
            this.Property(t => t.c14);
            this.Property(t => t.c15);
            this.Property(t => t.c16);

            //Table & Column Mappings
            //this.ToTable("wordlen");
            this.ToTable("View_gWord_lenTspace");


            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ch).HasColumnName("ch");
            this.Property(t => t.c1).HasColumnName("c1");
            this.Property(t => t.c2).HasColumnName("c2");
            this.Property(t => t.c3).HasColumnName("c3");
            this.Property(t => t.c4).HasColumnName("c4");
            this.Property(t => t.c5).HasColumnName("c5");
            this.Property(t => t.c6).HasColumnName("c6");
            this.Property(t => t.c7).HasColumnName("c7");
            this.Property(t => t.c8).HasColumnName("c8");
            this.Property(t => t.c9).HasColumnName("c9");
            this.Property(t => t.c10).HasColumnName("c10");
            this.Property(t => t.c11).HasColumnName("c11");
            this.Property(t => t.c12).HasColumnName("c12");
            this.Property(t => t.c13).HasColumnName("c13");
            this.Property(t => t.c14).HasColumnName("c14");
            this.Property(t => t.c15).HasColumnName("c15");
            this.Property(t => t.c16).HasColumnName("c16");



        }
    }
}
