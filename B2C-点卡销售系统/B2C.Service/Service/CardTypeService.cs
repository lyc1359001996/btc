using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Data.Entity;
using System.Linq;

namespace B2C.DAL.Service
{
    public class CardTypeService : ICardType
    {
        public void DeleteCardType(long t_cardTypeId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> bs = new BaseService<CardTypeEntity>(ctx);
                bs.MarkDeleted(t_cardTypeId);
            }
        }
        private CardTypeDTO ToDTO(CardTypeEntity cardTypeEntity)
        {
            CardTypeDTO cardType = new CardTypeDTO();
            cardType.Id = cardTypeEntity.Id;
            cardType.CardTypeName = cardTypeEntity.CardTypeName;
            cardType.CardImage = cardTypeEntity.CardImage;
            cardType.CardPrice = cardTypeEntity.CardPrice;
            cardType.UserInfoIds = cardTypeEntity.UserInfos.Select(a => a.Id).ToArray();
            return cardType;
        }
        public CardTypeDTO[] GetAllCardType()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> bs = new BaseService<CardTypeEntity>(ctx);
                return bs.GetAll().Include(e=>e.UserInfos).AsNoTracking().ToList().Select(e=>ToDTO(e)).ToArray();
            }
            
        }

        public long InsertCardType(CardTypeDTO t_CardType)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> cardTypebs = new BaseService<CardTypeEntity>(ctx);
                if (cardTypebs.GetById(t_CardType.Id) == null)
                {
                    BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                    CardTypeEntity cardTypeEntity = new CardTypeEntity();
                    cardTypeEntity.CardImage = t_CardType.CardImage;
                    cardTypeEntity.CardPrice = t_CardType.CardPrice;
                    cardTypeEntity.CardTypeName = t_CardType.CardTypeName;
                    foreach (var item in bs.GetAll().Where(a => t_CardType.UserInfoIds.Contains(a.Id)))
                    {
                        cardTypeEntity.UserInfos.Add(item);
                    }
                    ctx.CardType.Add(cardTypeEntity);
                    ctx.SaveChanges();
                    return cardTypeEntity.Id;
                }
                else
                {
                    return 0;
                }
                
            }
        }

        public CardTypeDTO SelectCardTypeByID(long t_cardTypeId)
        {
             using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> bs = new BaseService<CardTypeEntity>(ctx);
                if (bs.GetById(t_cardTypeId) != null)
                {
                    return ToDTO(bs.GetById(t_cardTypeId));
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdateCardType(CardTypeDTO t_CardType)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardTypeEntity> cardTypebs = new BaseService<CardTypeEntity>(ctx);
                BaseService<UserInfoEntity> bs = new BaseService<UserInfoEntity>(ctx);
                if (cardTypebs.GetById(t_CardType.Id) != null)
                {
                    CardTypeEntity cardTypeEntity = new CardTypeEntity();
                    cardTypeEntity.CardImage = t_CardType.CardImage;
                    cardTypeEntity.CardPrice = t_CardType.CardPrice;
                    cardTypeEntity.CardTypeName = t_CardType.CardTypeName;
                    foreach (var item in bs.GetAll().Where(a => t_CardType.UserInfoIds.Contains(a.Id)))
                    {
                        cardTypeEntity.UserInfos.Add(item);
                    }
                    ctx.SaveChanges();
                    return cardTypeEntity.Id;
                }
                else
                {
                    return 0;
                }
                
            }
        }
    }
}
