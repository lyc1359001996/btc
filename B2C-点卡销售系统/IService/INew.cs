using System.Data;
using System.Collections.Generic;
using System;
using B2C.IService;
using Service.Entitie;

namespace B2C.IDAL
{
	///
	//New
	///
	public interface INew: IServiceSupport
    {
		NewsEntity SelectNewByID(int t_newsId);
		
		IList<NewsEntity> GetAllNew();
				
	
		int InsertNew(NewsEntity t_New);
		
		int UpdateNew(NewsEntity t_New);
		
		int DeleteNew(int t_newsId);
	}
}


