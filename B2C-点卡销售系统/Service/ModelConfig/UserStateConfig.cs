using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class UserStateConfig:EntityTypeConfiguration<UserStateEntity>
    {
        public UserStateConfig()
        {
            ToTable("T_UserStates");
            Property(p => p.UserStateName).IsRequired().HasMaxLength(20);
            Property(p => p.UserState).IsRequired();
        }
    }
}
