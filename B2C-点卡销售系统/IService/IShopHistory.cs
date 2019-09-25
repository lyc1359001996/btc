using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//ShopHistory
	///
	public interface IShopHistory: IServiceSupport
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


