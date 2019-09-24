using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
 
    class RoleInfoConfig : EntityTypeConfiguration<RoleInfoEntity>
    {
        public RoleInfoConfig()
        {
            ToTable("T_RoleInfos");
            Property(p => p.RoleName).IsRequired().HasMaxLength(20);
            Property(p => p.RoleDesc).IsRequired().HasMaxLength(20);
            Property(p => p.DisCount).IsRequired();
            HasMany(p => p.SysFuns).WithMany(p => p.Roles).Map(e => e.ToTable("T_RoleRight").MapLeftKey("RoleId").MapRightKey("SysFunsId"));
        }
    }
}
