using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{

    class CardConfig : EntityTypeConfiguration<CardEntity>
    {
        public CardConfig()
        {
            ToTable("T_Cards");
            Property(p => p.CardNo).IsRequired();
            Property(p => p.CardPassword).IsRequired().HasMaxLength(50);
            Property(p => p.CardDesc).IsRequired().HasMaxLength(50);
            HasRequired(p => p.CardState).WithMany().HasForeignKey(p=>p.CardStateId).WillCascadeOnDelete(false);
            HasRequired(p => p.CardType).WithMany().HasForeignKey(p => p.CardTypeId).WillCascadeOnDelete(false);
        }
    }
}
