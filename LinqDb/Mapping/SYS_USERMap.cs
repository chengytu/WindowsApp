using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;
namespace DataFactory.Mapping
{
    public class SYS_USERMap : EntityTypeConfiguration<SYS_USER>
    {
        public SYS_USERMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Pwd)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.RoleID)
                .HasMaxLength(40);
            
            this.Property(t => t.CreateDate);
            this.Property(t => t.State);

            //Table & Column Mappings
            this.ToTable("SYS_USER");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.State).HasColumnName("State");

            //this.HasOptional(t => t.UserRole).WithMany().HasForeignKey(t => t.RoleID);

            
        }
    }
}
