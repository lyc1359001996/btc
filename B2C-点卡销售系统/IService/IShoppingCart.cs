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
	//ShoppingCart
	///
	public interface IShoppingCart
	{
		ShoppingCartEntity SelectShoppingCartByID(int t_shoppingCartItemId);
		
		IList<ShoppingCartEntity> GetAllShoppingCart();
				
		IList<ShoppingCartEntity> GetAllShoppingCartByUserId(string t_userId);
		
		IList<ShoppingCartEntity> GetAllShoppingCartByCardTypeId(int t_cardTypeId);
		
	
		int InsertShoppingCart(ShoppingCartEntity t_ShoppingCart);
		
		int UpdateShoppingCart(ShoppingCartEntity t_ShoppingCart);
		
		int DeleteShoppingCart(int t_shoppingCartItemId);
	}
}


