using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusModels;

namespace DataFactory.Mapping
{
    public class RBAC_ROLEMap : EntityTypeConfiguration<RBAC_ROLE>
    {
        public RBAC_ROLEMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.DictCode, t.DValue });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ROLENAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CREATEDATE);
            this.Property(t => t.State);

            //Table & Column Mappings
            this.ToTable("RBAC_ROLE");

            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ROLENAME).HasColumnName("ROLENAME");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.CREATEDATE).HasColumnName("CREATEDATE");
            this.Property(t => t.State).HasColumnName("State");

        }
    }
}
