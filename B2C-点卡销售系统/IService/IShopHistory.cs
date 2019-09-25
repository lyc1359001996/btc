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
	//ShopHistory
	///
	public interface IShopHistory
	{
		ShopHistoryEntity SelectShopHistoryByID(int t_shopHistoryId);
		
		IList<ShopHistoryEntity> GetAllShopHistory();
				
		IList<ShopHistoryEntity> GetAllShopHistoryByUserId(string t_userId);
		
		IList<ShopHistoryEntity> GetAllShopHistoryByCardId(int t_cardId);
		
	
		int InsertShopHistory(ShopHistoryEntity t_ShopHistory);
		
		int UpdateShopHistory(ShopHistoryEntity t_ShopHistory);
		
		int DeleteShopHistory(int t_shopHistoryId);
	}
}


