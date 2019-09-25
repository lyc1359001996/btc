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
		ShopHistoryDTO SelectShopHistoryByID(long t_shopHistoryId);
		
		ShopHistoryDTO[] GetAllShopHistory();
				
		ShopHistoryDTO[] GetAllShopHistoryByUserId(long t_userId);
		
		ShopHistoryDTO[] GetAllShopHistoryByCardId(long t_cardId);


        long InsertShopHistory(ShopHistoryDTO t_ShopHistory);

        long UpdateShopHistory(ShopHistoryDTO t_ShopHistory);
		
		void DeleteShopHistory(long t_shopHistoryId);
	}
}


