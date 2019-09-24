using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class PostHistoryConfig : EntityTypeConfiguration<PostHistoryEntity>
    {
        public PostHistoryConfig()
        {
            ToTable("T_ PostHistorys");
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.ApproveState).WithMany().HasForeignKey(p => p.ApproveStateId).WillCascadeOnDelete(false);
            Property(p => p.Bank).IsRequired().HasMaxLength(50);
            Property(p => p.PostDesc).IsRequired().HasMaxLength(50);
            Property(p => p.Money).IsRequired();
        }
    }
}
