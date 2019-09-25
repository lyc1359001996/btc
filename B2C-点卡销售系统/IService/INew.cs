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
		NewsDTO SelectNewByID(long t_newsId);

        NewsDTO[] GetAllNew();
				
	
		int InsertNew(NewsDTO t_New);
		
		int UpdateNew(NewsDTO t_New);
		
		void DeleteNew(long t_newsId);
	}
}


