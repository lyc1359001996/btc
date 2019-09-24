using B2C.DTO;
using B2C.IService;
using Service.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.IDAL
{
    public interface ICardState: IServiceSupport
    {
        CardStateDTO SelectCardStateByID(long t_cardStateId);

        CardStateDTO[] GetAllCardState();

        long InsertCardState(CardStateDTO t_CardState);

        long UpdateCardState(CardStateDTO t_CardState);

        void DeleteCardState(long t_cardStateId);
    }
}
