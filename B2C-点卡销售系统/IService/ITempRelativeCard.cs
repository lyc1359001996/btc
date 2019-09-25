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
	//TempRelativeCard
	///
	public interface ITempRelativeCard
	{
		TempRelativeCardEntity SelectTempRelativeCardByID(int t_tempRelativeCardId);
		
		IList<TempRelativeCardEntity> GetAllTempRelativeCard();
				
		IList<TempRelativeCardEntity> GetAllTempRelativeCardByUserId(string t_userId);
		
		IList<TempRelativeCardEntity> GetAllTempRelativeCardByCardTypeid(int t_cardTypeid);
		
	
		int InsertTempRelativeCard(TempRelativeCardEntity t_TempRelativeCard);
		
		int UpdateTempRelativeCard(TempRelativeCardEntity t_TempRelativeCard);
		
		int DeleteTempRelativeCard(int t_tempRelativeCardId);
	}
}


