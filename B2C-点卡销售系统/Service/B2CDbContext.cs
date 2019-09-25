using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Text;
using Service.Entitie;

namespace Service
{
    public class B2CDbContext : DbContext
    {
        public B2CDbContext() : base("name=conn")
        {
            //Database.SetInitializer<ZSZDbContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
            public DbSet<AdviceEntity> Advice { get; set; }
            public DbSet<ApproveStateEntity> ApproveState { get; set; }
            public DbSet<CardEntity> Card { get; set; }
            public DbSet<CardStateEntity> CardState { get; set; }
            public DbSet<CardTypeDTO> CardType { get; set; }
            public DbSet<NewsEntity> News { get; set; }
            public DbSet<PostFailedInfoEntity> PostFailedInfos { get; set; }
            public DbSet<PostHistoryEntity> PostHistories { get; set; }
            public DbSet<RoleInfoEntity> Roles { get; set; }
            public DbSet<ShopHistoryDTO> ShopHistories { get; set; }
            public DbSet<ShoppingCartEntity> ShoppingCarts { get; set; }
            public DbSet<SysFunEntity> SysFuns { get; set; }
            public DbSet<UserInfoEntity> UserInfos { get; set; }
            public DbSet<UserStateEntity> UserStates { get; set; }
    
    }

    }

