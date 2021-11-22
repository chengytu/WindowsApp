using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class StudentMap : EntityTypeConfiguration<StudentModel>
    {


        public StudentMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .HasMaxLength(40);

            this.Property(t => t.StudentID)
                .HasMaxLength(16);

            this.Property(t => t.StudentName)
                .HasMaxLength(20);

            this.Property(t => t.ClassName)
                .HasMaxLength(20);
            this.Property(t => t.Gender)
                 .HasMaxLength(2);



            //Table & Column Mappings
            this.ToTable("Student");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.StudentID).HasColumnName("StudentID");
            this.Property(t => t.StudentName).HasColumnName("StudentName");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.Gender).HasColumnName("Gender");



        }
    }
}

