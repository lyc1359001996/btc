///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using B2C.Model;


namespace B2C.IDAL
{
	///
	//CardType
	///
	public interface ICardType
	{
		CardTypeEntity SelectCardTypeByID(int t_cardTypeId);
		
		IList<CardTypeEntity> GetAllCardType();
				
	
		int InsertCardType(CardTypeEntity t_CardType);
		
		int UpdateCardType(CardTypeEntity t_CardType);
		
		int DeleteCardType(int t_cardTypeId);
	}
}


