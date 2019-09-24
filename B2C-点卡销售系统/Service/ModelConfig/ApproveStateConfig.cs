using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class ApproveStateConfigConfig : EntityTypeConfiguration<ApproveStateEntity>
    {
        public ApproveStateConfigConfig()
        {
            ToTable("T_ ApproveStates");
            Property(p => p.ApproveStateName).IsRequired().HasMaxLength(50);
        }
    }
}
