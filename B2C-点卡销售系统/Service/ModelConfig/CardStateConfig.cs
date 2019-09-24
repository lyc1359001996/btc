using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class CardStateConfig : EntityTypeConfiguration<CardStateEntity>
    {
        public CardStateConfig()
        {
            ToTable("T_CardStates");
            Property(p => p.CardStateName).IsRequired().HasMaxLength(50);
            Property(p => p.CardState).IsRequired();
        }
    }
}
