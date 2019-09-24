using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class ShoppingCartConfig : EntityTypeConfiguration<ShoppingCartEntity>
    {
        public ShoppingCartConfig()
        {
            ToTable("T_ShoppingCarts");
            Property(p => p.Num).IsRequired();
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.CardType).WithMany().HasForeignKey(p => p.CardTypeId).WillCascadeOnDelete(false);
        }
    }
}
