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
    public class CardService : ICard
    {
        public void DeleteCard(long t_cardId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                bs.MarkDeleted(t_cardId);
            }
        }
        private CardDTO ToDTO(CardEntity cardEntity)
        {
            CardDTO cardDTO = new CardDTO()
            {
                CardDesc = cardEntity.CardDesc,
                CardNo = cardEntity.CardNo,
                CardPassword = cardEntity.CardPassword,
                CardStateId = cardEntity.CardStateId,
                CardStateName = cardEntity.CardState.CardStateName,
                CardTypeId = cardEntity.CardTypeId,
                CardTypeName = cardEntity.CardType.CardTypeName,
                Id = cardEntity.Id
            };
            return cardDTO;
        }
        public CardDTO[] GetAllCard()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                var cards = bs.GetAll().Include(e => e.CardType).Include(e => e.CardState).AsNoTracking().ToList().Select(l => ToDTO(l)).ToArray();
                return cards;
            }
        }

        public CardDTO[] GetAllCardByCardState(long t_cardState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                if (ctx.CardState.Any(e => e.Id == t_cardState))
                {
                    BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                    var cards = bs.GetAll().Include(e => e.CardType).Include(e => e.CardState).AsNoTracking().Where(e=>e.CardStateId== t_cardState)
                        .ToList().Select(l => ToDTO(l)).ToArray();
                    return cards;
                }
                else
                {
                    return null;
                }
            }
        }

        public CardDTO[] GetAllCardByCardTypeId(long t_cardTypeId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                if (ctx.CardType.Any(e => e.Id == t_cardTypeId))
                {
                    BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                    var cards = bs.GetAll().Include(e => e.CardType).Include(e => e.CardState).AsNoTracking().
                        Where(e=>e.CardTypeId== t_cardTypeId).ToList().Select(l => ToDTO(l)).ToArray();
                    return cards;
                }
                else
                {
                    return null;
                }
            }
        }

        public long InsertCard(CardDTO t_Card)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                CardEntity cardEntity = new CardEntity()
                {
                    CardDesc = t_Card.CardDesc,
                    CardNo=t_Card.CardNo,
                    CardPassword=t_Card.CardPassword,
                    CardStateId=t_Card.CardStateId,
                    CardTypeId=t_Card.CardTypeId
                };
                ctx.Card.Add(cardEntity);
                ctx.SaveChanges();
                return cardEntity.Id;
            }
        }

        public CardDTO SelectCardByID(long t_cardId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                if (ctx.CardState.Any(e => e.Id == t_cardId))
                {
                    BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                    var cards = bs.GetAll().Include(e => e.CardType).Include(e => e.CardState).AsNoTracking().Where(e => e.Id == t_cardId).
                        SingleOrDefault();
                    return ToDTO(cards);
                }
                else
                {
                    return null;
                }
            }
        }

        public long UpdateCard(CardDTO t_Card)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                if (ctx.Card.Any(e => e.Id == t_Card.Id))
                {
                    BaseService<CardEntity> bs = new BaseService<CardEntity>(ctx);
                    var cardInfo=bs.GetById(t_Card.Id);
                    cardInfo.CardDesc = t_Card.CardDesc;
                    cardInfo.CardNo = t_Card.CardNo;
                    cardInfo.CardPassword = t_Card.CardPassword;
                    cardInfo.CardStateId = t_Card.CardStateId;
                    cardInfo.CardTypeId = t_Card.CardTypeId;
                    return cardInfo.Id;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
