using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//ShopHistory
	///
	public interface IShopHistory: IServiceSupport
    {
        ShophistoryDTO SelectShopHistoryByID(long t_shopHistoryId);

        ShophistoryDTO[] GetAllShopHistory();
				
		ShophistoryDTO[] GetAllShopHistoryByUserId(long t_userId);
		
		ShophistoryDTO[] GetAllShopHistoryByCardId(long t_cardId);


        long InsertShopHistory(ShophistoryDTO t_ShopHistory);

        long UpdateShopHistory(ShophistoryDTO t_ShopHistory);
		
		void DeleteShopHistory(long t_shopHistoryId);
	}
}


