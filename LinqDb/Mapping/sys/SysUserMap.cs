using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using  BusModels;
namespace DataFactory.Mapping
{
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
        public SysUserMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Pwd)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.RoleID)
                .IsRequired()
                .HasMaxLength(40);
           

            // Table & Column Mappings
            this.ToTable("Sys_User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");


        }
    }
}
