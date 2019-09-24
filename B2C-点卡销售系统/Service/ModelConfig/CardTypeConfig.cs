﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
   
    class CardTypeConfig : EntityTypeConfiguration<CardTypeEntity>
    {
        public CardTypeConfig()
        {
            ToTable("T_CardTypes");
            Property(p => p.CardTypeName).IsRequired().HasMaxLength(50);
            Property(p => p.CardPrice).IsRequired();
            Property(p => p.CardImage).IsRequired().HasMaxLength(50);
        }
    }
}
