using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Service.Entitie;

namespace Service.ModelConfig
{
    class UserConfig:EntityTypeConfiguration<UserInfoEntity>
    {
        public UserConfig()
        {
            ToTable("T_UserInfos");
            Property(u => u.UserName).IsRequired().HasMaxLength(50);
            Property(u => u.PassWordSalt).IsRequired().HasMaxLength(20);
            Property(u => u.PassWordHash).IsRequired().HasMaxLength(50);
            Property(u => u.Gender).IsRequired();
            Property(u => u.PassQuestion).IsRequired().HasMaxLength(50);
            Property(u => u.PassAnswer).IsRequired().HasMaxLength(20);
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Property(u => u.PhoneNumber).IsRequired().HasMaxLength(20).IsUnicode(false);
            Property(u => u.Address).IsRequired().HasMaxLength(20);
            Property(u => u.IDCardNo).IsRequired().HasMaxLength(18);
            Property(u => u.Money).IsRequired();
            HasRequired(h => h.UserState).WithMany().HasForeignKey(h => h.UserStateId).WillCascadeOnDelete(false);
            HasRequired(h => h.RoleInfo).WithMany().HasForeignKey(h => h.RoleInfoId).WillCascadeOnDelete(false);
            HasMany(p => p.CardTypes).WithMany(p => p.UserInfos).Map(e => e.ToTable("T_TempRelativeCard").MapLeftKey("CardTypeId").MapRightKey("UserInfoId"));
        }
    }
}
