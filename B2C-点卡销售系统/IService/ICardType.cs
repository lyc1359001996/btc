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
		CardTypeEntity SelectCardTypeByID(int t_cardTypeId);
		
		IList<CardTypeEntity> GetAllCardType();
				
	
		int InsertCardType(CardTypeEntity t_CardType);
		
		int UpdateCardType(CardTypeEntity t_CardType);
		
		int DeleteCardType(int t_cardTypeId);
	}
}


