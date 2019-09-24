using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{

    class AdviceConfig : EntityTypeConfiguration<AdviceEntity>
    {
        public AdviceConfig()
        {
            ToTable("T_ Advices");
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            Property(p => p.Content).IsRequired().HasMaxLength(2000);
        }
    }
}
