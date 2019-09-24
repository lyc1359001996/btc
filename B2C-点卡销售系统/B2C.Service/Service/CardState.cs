using B2C.DTO;
using B2C.IDAL;
using B2C.Service.Service;
using Service;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2C.DAL.Service
{
    public class CardState : ICardState
    {
        public void DeleteCardState(long t_cardStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardStateEntity> bs = new BaseService<CardStateEntity>(ctx);
                bs.MarkDeleted(t_cardStateId);
            }
        }
        private CardStateDTO ToDTO(CardStateEntity cardStateEntity)
        {
            CardStateDTO cardStateDTO = new CardStateDTO()
            {
                CardState=cardStateEntity.CardState,
                CardStateName=cardStateEntity.CardStateName,
                Id=cardStateEntity.Id
            };
            return cardStateDTO;
        }
        public CardStateDTO[] GetAllCardState()
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardStateEntity> bs = new BaseService<CardStateEntity>(ctx);
                return bs.GetAll().Select(e => ToDTO(e)).ToArray();
            }
        }

        public long InsertCardState(CardStateDTO t_CardState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                CardStateEntity cardStateEntity = new CardStateEntity()
                {
                    CardState= t_CardState.CardState,
                    CardStateName= t_CardState.CardStateName
                };
                ctx.CardState.Add(cardStateEntity);
                ctx.SaveChanges();
                return cardStateEntity.Id;
            }
        }

        public CardStateDTO SelectCardStateByID(long t_cardStateId)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                BaseService<CardStateEntity> bs = new BaseService<CardStateEntity>(ctx);
                var cardState=bs.GetById(t_cardStateId);
                CardStateDTO cardStateDTO = new CardStateDTO()
                {
                    CardState = cardState.CardState,
                    CardStateName = cardState.CardStateName,
                    Id = cardState.Id
                };
                return cardStateDTO;
            }
        }

        public long UpdateCardState(CardStateDTO t_CardState)
        {
            using (B2CDbContext ctx = new B2CDbContext())
            {
                if (ctx.Card.Any(e => e.Id == t_CardState.Id))
                {
                    BaseService<CardStateEntity> bs = new BaseService<CardStateEntity>(ctx);
                    var cardState = bs.GetById(t_CardState.Id);
                    cardState.CardState = t_CardState.CardState;
                    cardState.CardStateName = t_CardState.CardStateName;
                    ctx.SaveChanges();
                    return cardState.Id;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
