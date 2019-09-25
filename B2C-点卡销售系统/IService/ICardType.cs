using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//CardType
	///
	public interface ICardType: IServiceSupport
    {
		CardTypeDTO SelectCardTypeByID(long t_cardTypeId);

        CardTypeDTO[] GetAllCardType();


        long InsertCardType(CardTypeDTO t_CardType);

        long UpdateCardType(CardTypeDTO t_CardType);
		
		void DeleteCardType(long t_cardTypeId);
	}
}


