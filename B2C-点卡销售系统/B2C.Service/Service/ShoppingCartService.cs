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
    public class ShoppingCartService : IShoppingCart
    {
        public void DeleteShoppingCart(long t_shoppingCartItemId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                bs.MarkDeleted(t_shoppingCartItemId);
            }
        }
        private ShoppingCartDTO ToDTO(ShoppingCartEntity shoppingCartEntity)
        {
            ShoppingCartDTO shoppingCartDTO = new ShoppingCartDTO()
            {
                CardTypeId=shoppingCartEntity.CardTypeId,
                Id=shoppingCartEntity.Id,
                CardTypeName=shoppingCartEntity.CardType.CardTypeName,
                Num=shoppingCartEntity.Num,
                UserId=shoppingCartEntity.UserId,
                UserName=shoppingCartEntity.User.UserName
            };
            return shoppingCartDTO;
        }
        public ShoppingCartDTO[] GetAllShoppingCart()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                return bs.GetAll().Include(e=>e.User).Include(e=>e.CardType).AsNoTracking().Select(e => ToDTO(e)).ToArray();
            }
        }

        public ShoppingCartDTO[] GetAllShoppingCartByCardTypeId(long t_cardTypeId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardEntity> cardbs = new BaseService<CardEntity>(ctx);
                if (cardbs.GetById(t_cardTypeId) != null)
                {
                    BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                    return bs.GetAll().Include(e => e.User).Include(e => e.CardType).AsNoTracking().Where(e => e.CardTypeId == t_cardTypeId).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public ShoppingCartDTO[] GetAllShoppingCartByUserId(long t_userId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<UserInfoEntity> userInfobs = new BaseService<UserInfoEntity>(ctx);
                if (userInfobs.GetById(t_userId) != null)
                {
                    BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                    return bs.GetAll().Include(e => e.User).Include(e => e.CardType).AsNoTracking().Where(e => e.UserId == t_userId).Select(e => ToDTO(e)).ToArray();
                }
                else
                {
                    return null;
                }
            }
        }

        public long InsertShoppingCart(ShoppingCartDTO t_ShoppingCart)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                ShoppingCartEntity ShoppingCartEntity = new ShoppingCartEntity()
                {
                    CardTypeId=t_ShoppingCart.CardTypeId,
                    Num=t_ShoppingCart.Num,
                    UserId=t_ShoppingCart.UserId
                };
                ctx.ShoppingCarts.Add(ShoppingCartEntity);
                ctx.SaveChanges();
                return ShoppingCartEntity.Id;

            }
        }

        public ShoppingCartDTO SelectShoppingCartByID(long t_shoppingCartItemId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                if (bs.GetById(t_shoppingCartItemId) != null)
                {
                    return ToDTO(bs.GetById(t_shoppingCartItemId));
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdateShoppingCart(ShoppingCartDTO t_ShoppingCart)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<ShoppingCartEntity> bs = new BaseService<ShoppingCartEntity>(ctx);
                if (bs.GetAll().Any(e => e.Id == t_ShoppingCart.Id))
                {
                    return 0;
                }
                else
                {
                    var shoopingCart = bs.GetById(t_ShoppingCart.Id);
                    shoopingCart.Num = t_ShoppingCart.Num;
                    shoopingCart.UserId = t_ShoppingCart.UserId;
                    shoopingCart.CardTypeId = t_ShoppingCart.CardTypeId;
                    ctx.SaveChanges();
                    return t_ShoppingCart.Id;
                }
            }
        }
    }
}
