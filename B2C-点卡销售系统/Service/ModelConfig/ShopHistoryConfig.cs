using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using B2C.DTO;
using Service.Entitie;

namespace Service.ModelConfig
{
    class ShopHistoryConfig : EntityTypeConfiguration<ShopHistoryEntity>
    {
        public ShopHistoryConfig()
        {
            ToTable("T_ShopHistorys");
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.Card).WithMany().HasForeignKey(p => p.CardId).WillCascadeOnDelete(false);
        }
    }
}
