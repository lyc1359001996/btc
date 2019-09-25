///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;
using B2C.DTO;

namespace B2C.IDAL
{
	///
	//ShoppingCart
	///
	public interface IShoppingCart: IServiceSupport
    {
		ShoppingCartDTO SelectShoppingCartByID(long t_shoppingCartItemId);
		
		ShoppingCartDTO[] GetAllShoppingCart();

        ShoppingCartDTO[] GetAllShoppingCartByUserId(long t_userId);

        ShoppingCartDTO[] GetAllShoppingCartByCardTypeId(long t_cardTypeId);
		
	
		int InsertShoppingCart(ShoppingCartDTO t_ShoppingCart);
		
		int UpdateShoppingCart(ShoppingCartDTO t_ShoppingCart);
		
		void DeleteShoppingCart(long t_shoppingCartItemId);
	}
}


