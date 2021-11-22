using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;


namespace DataFactory.Mapping
{
    public class easyMap : EntityTypeConfiguration<easy>
    {
        public easyMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ProjectName)
               .IsRequired()
               .HasMaxLength(40);
            this.Property(t => t.ProjectCode)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.MicroBarCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.TestTime)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Reagentmanufacturer)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Reagentlotnumber)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Operator)
              .IsRequired()
              .HasMaxLength(40);


            this.Property(t => t.Wave)
              .IsRequired()
              .HasMaxLength(100);


            this.Property(t => t.Reference)
              .IsRequired()
              .HasMaxLength(20);

            this.Property(t => t.CUTOFF)
              .IsRequired()
              .HasMaxLength(20);


            this.Property(t => t.Abnormal)
             .IsRequired()
             .HasMaxLength(20);

            this.Property(t => t.normal);


            // Table & Column Mappings
            this.ToTable("word");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ProjectCode).HasColumnName("ProjectCode");
            this.Property(t => t.MicroBarCode).HasColumnName("MicroBarCode");
            this.Property(t => t.TestTime).HasColumnName("TestTime");
            this.Property(t => t.Reagentmanufacturer).HasColumnName("Reagentmanufacturer");
            this.Property(t => t.Reagentlotnumber).HasColumnName("Reagentlotnumber");
            this.Property(t => t.Operator).HasColumnName(" Operator");
            this.Property(t => t.Wave).HasColumnName("Wave");
            this.Property(t => t.Reference).HasColumnName("Reference");
            this.Property(t => t.CUTOFF).HasColumnName("CUTOFF");
            this.Property(t => t.sign).HasColumnName("sign");
            this.Property(t => t.Abnormal).HasColumnName("Abnormal");
            this.Property(t => t.normal).HasColumnName("normal");

        }
    }
}
