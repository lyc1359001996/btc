///
//?????,?????CodeSmith??
//???:??
//????:2009?10?15?
///

using System.Data;
using System.Collections.Generic;
using System;



namespace B2C.IDAL
{
	///
	//New
	///
	public interface INew
	{
		NewEntity SelectNewByID(int t_newsId);
		
		IList<NewEntity> GetAllNew();
				
	
		int InsertNew(NewEntity t_New);
		
		int UpdateNew(NewEntity t_New);
		
		int DeleteNew(int t_newsId);
	}
}


