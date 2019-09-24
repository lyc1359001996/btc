using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{

    class PostFaiedInfoConfig : EntityTypeConfiguration<PostFailedInfoEntity>
    {
        public PostFaiedInfoConfig()
        {
            ToTable("T_ PostFaiedInfoys");
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.PostHistory).WithMany().HasForeignKey(p => p.PostHistoryId).WillCascadeOnDelete(false);
            Property(p => p.ReadState).IsRequired();
        }
    }
}
