///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;

namespace B2C.IDAL
{
	///
	//TempRelativeCard
	///
	public interface ITempRelativeCard: IServiceSupport
    {
		TempRelativeCardDTO SelectTempRelativeCardByID(int t_tempRelativeCardId);
		
		IList<TempRelativeCardDTO> GetAllTempRelativeCard();
				
		IList<TempRelativeCardDTO> GetAllTempRelativeCardByUserId(string t_userId);
		
		IList<TempRelativeCardDTO> GetAllTempRelativeCardByCardTypeid(int t_cardTypeid);
		
	
		int InsertTempRelativeCard(TempRelativeCardDTO t_TempRelativeCard);
		
		int UpdateTempRelativeCard(TempRelativeCardDTO t_TempRelativeCard);
		
		int DeleteTempRelativeCard(int t_tempRelativeCardId);
	}
}


