using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{

    class NewsConfig : EntityTypeConfiguration<NewsDTO>
    {
        public NewsConfig()
        {
            ToTable("T_News");
            Property(p => p.Title).IsRequired().HasMaxLength(50);
            Property(p => p.NewsState).IsRequired();
            Property(p => p.Content).IsRequired().HasMaxLength(500);
        }
    }
}
