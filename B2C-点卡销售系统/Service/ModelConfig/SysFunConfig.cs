using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class SysFunConfig : EntityTypeConfiguration<SysFunEntity>
    {
        public SysFunConfig()
        {
            ToTable("T_SysFuns");
            Property(p => p.DisplayName).IsRequired().HasMaxLength(50);
            Property(p => p.NodeURL).IsRequired().HasMaxLength(20);
            Property(p => p.DisplayOrder).IsRequired();
            Property(p => p.ParentNodeId).IsRequired();
        }
    }
}
