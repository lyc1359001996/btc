using B2C.DTO;
using B2C.IService;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.IDAL
{
    public interface ICard: IServiceSupport
    {
        CardDTO SelectCardByID(long t_cardId);

        CardDTO[] GetAllCard();

        CardDTO[] GetAllCardByCardTypeId(long t_cardTypeId);

        CardDTO[] GetAllCardByCardState(long t_cardState);


        long InsertCard(CardDTO t_Card);

        long UpdateCard(CardDTO t_Card);

        void DeleteCard(long t_cardId);
    }
}
