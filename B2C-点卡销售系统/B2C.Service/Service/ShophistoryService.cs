using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace B2C.DAL.Service
{
    public class ShopHistoryService : IShopHistory
    {
        public void DeleteShopHistory(long t_shopHistoryId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                bs.MarkDeleted(t_shopHistoryId);
            }
        }
        private ShopHistoryDTO ToDTO(ShopHistoryEntity shopHistoryEntity)
        {
            ShopHistoryDTO shopHistoryDTO = new ShopHistoryDTO()
            {
                CardId = shopHistoryEntity.CardId,
                Id=shopHistoryEntity.Id,
                UserId=shopHistoryEntity.UserId,
                UserName=shopHistoryEntity.User.UserName
            };
            return shopHistoryDTO;
        }
        public ShopHistoryDTO[] GetAllShopHistory()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                return bs.GetAll().Include(e=>e.User).AsNoTracking().Select(e => ToDTO(e)).ToArray();
            }
        }

        public ShopHistoryDTO[] GetAllShopHistoryByCardId(long t_cardId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardEntity> cardEntity = new BaseService<CardEntity>(ctx);
                if (cardEntity.GetById(t_cardId) != null)
                {
                    BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                    return bs.GetAll().Include(e => e.User).AsNoTracking().Where(e => e.CardId== t_cardId).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }

        }

        public ShopHistoryDTO[] GetAllShopHistoryByUserId(long t_userId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> userInfobs = new BaseService<UserInfoEntity>(ctx);
                if (userInfobs.GetById(t_userId) != null)
                {
                    BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                    return bs.GetAll().Include(e => e.User).AsNoTracking().Where(e => e.UserId == t_userId).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public long InsertShopHistory(ShopHistoryDTO t_ShopHistory)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                ShopHistoryEntity shopHistoryEntity = new ShopHistoryEntity()
                {
                    CardId = t_ShopHistory.CardId,
                    UserId=t_ShopHistory.UserId
                };
                ctx.ShopHistories.Add(shopHistoryEntity);
                ctx.SaveChanges();
                return shopHistoryEntity.Id;

            }
        }

        public ShopHistoryDTO SelectShopHistoryByID(long t_shopHistoryId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                if (bs.GetById(t_shopHistoryId) != null)
                {
                    return ToDTO(bs.GetById(t_shopHistoryId));
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdateShopHistory(ShopHistoryDTO t_ShopHistory)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShopHistoryEntity> bs = new BaseService<ShopHistoryEntity>(ctx);
                if (bs.GetAll().Any(e => e.Id == t_ShopHistory.Id))
                {
                    return 0;
                }
                else
                {
                    var shopHistoryEntity = bs.GetById(t_ShopHistory.Id);
                    shopHistoryEntity.UserId = t_ShopHistory.UserId;
                    shopHistoryEntity.CardId = t_ShopHistory.CardId;
                    ctx.SaveChanges();
                    return shopHistoryEntity.Id;
                }
            }
        }
    }
}
